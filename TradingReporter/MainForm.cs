using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using SpreadsheetLight;

namespace TradingReporter2
{
    public partial class MainForm : Form
    {
        const int INDEX_ORDERNO = 1;
        const int INDEX_OPENTIME = 4;
        const int INDEX_CLOSETIME = 9;
        const int INDEX_PL = 11;
        private List<TradeData> mTradeDataList = new List<TradeData>();
        private List<ReportData> mReportDataList = new List<ReportData>();
        private double mTotalProfit = 0;
        private double mMaxLoss = 0;
        private double mMinProfit = 0;
        public MainForm()
        {
            InitializeComponent();
            loadHistory();
        }

        private void loadHistory()
        {
            if (!System.IO.File.Exists("History.txt"))
            {
                return;
            }

            string[] lines = System.IO.File.ReadAllLines("History.txt");

            double accountSize = 0;
            foreach (string line in lines)
            {
                if (line.Contains("*") == true)
                {
                    string currentFile = line.Remove(line.Length - 1);
                    cbbFilePath.Items.Add(currentFile);
                    cbbFilePath.Text = currentFile;
                } else if (line.Contains("\\") == true)
                {
                    cbbFilePath.Items.Add(line);
                } else if (double.TryParse(line, out accountSize) == true)
                {
                    numAccountSize.Value = (decimal)accountSize;
                }
            }
        }

        private void reloadTradeDataToTable()
        {
            // Fill data to raw table
            // clear old data
            grvRaw.Rows.Clear();
            grvWeeklyReport.Rows.Clear();
            mReportDataList.Clear();
            mTotalProfit = 0;
            mMaxLoss = 0;
            double accSize = Decimal.ToDouble(numAccountSize.Value);
            mMinProfit = accSize / 100;

            double tpSum = 0;
            double slStreak = 0;
            int tpCount = 0;
            int slCount = 0;

            // A. Handle Report Data
            ReportData reportData = new ReportData();
            DayOfWeek curDayOfWeek = DayOfWeek.Sunday;
            foreach (TradeData tradeData in mTradeDataList)
            {
                // 1. Check Cw and Day of Week
                int cw = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(tradeData.OpenTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                DayOfWeek dayOfWeek = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(tradeData.OpenTime);
                if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
                {
                    dayOfWeek = DayOfWeek.Friday;
                }
                // 2. Create new Weekly Data
                if (cw != reportData.WeekNumber)
                {
                    reportData = new ReportData();
                    reportData.WeekNumber = cw;
                    reportData.DailyPL = new Dictionary<DayOfWeek, double>();
                    reportData.DailyDetail = new Dictionary<DayOfWeek, List<TradeData>>();
                    reportData.DailyDetail[DayOfWeek.Monday] = new List<TradeData>();
                    reportData.DailyDetail[DayOfWeek.Tuesday] = new List<TradeData>();
                    reportData.DailyDetail[DayOfWeek.Wednesday] = new List<TradeData>();
                    reportData.DailyDetail[DayOfWeek.Thursday] = new List<TradeData>();
                    reportData.DailyDetail[DayOfWeek.Friday] = new List<TradeData>();
                    reportData.DailyPL.Add(DayOfWeek.Monday, 0);
                    reportData.DailyPL.Add(DayOfWeek.Tuesday, 0);
                    reportData.DailyPL.Add(DayOfWeek.Wednesday, 0);
                    reportData.DailyPL.Add(DayOfWeek.Thursday, 0);
                    reportData.DailyPL.Add(DayOfWeek.Friday, 0);
                    mReportDataList.Add(reportData);
                }

                // 3. Add data to Weekly Report
                reportData.DailyPL[dayOfWeek] += tradeData.ProfitLoss;
                reportData.DailyDetail[dayOfWeek].Add(tradeData);
                reportData.TotalProfit += tradeData.ProfitLoss;

                // 4. Calculate Overal information
                mTotalProfit += tradeData.ProfitLoss;
                if (tradeData.ProfitLoss < 0)
                {
                    slStreak += tradeData.ProfitLoss;
                    if (slStreak < mMaxLoss)
                    {
                        mMaxLoss = slStreak;
                    }
                    slCount++;
                } else if (tradeData.ProfitLoss > mMinProfit)
                {
                    slStreak = 0;
                    tpCount++;
                    tpSum += tradeData.ProfitLoss;
                }
                // 5. Fill Raw data
                if (curDayOfWeek == DayOfWeek.Sunday) curDayOfWeek = dayOfWeek;
                if (curDayOfWeek != dayOfWeek)
                {
                    curDayOfWeek = dayOfWeek;
                    grvRaw.Rows.Add(
                    grvRaw.Rows.Count,
                    "",
                    "",
                    ""
                    );
                }
                grvRaw.Rows.Add(
                    grvRaw.Rows.Count,
                    cw,
                    curDayOfWeek.ToString(),
                    tradeData.ProfitLoss
                    );
            }

            // B. Fill Data
            // 1. Fill Weekly Report
            foreach (ReportData rpd in mReportDataList)
            {
                int lastIdx = grvWeeklyReport.Rows.Count;
                if (bRRDisplay.Checked)
                {
                    grvWeeklyReport.Rows.Add(
                        rpd.WeekNumber,
                        Math.Round(rpd.DailyPL[DayOfWeek.Monday] * 100 / accSize, 1),
                        Math.Round(rpd.DailyPL[DayOfWeek.Tuesday] * 100 / accSize, 1),
                        Math.Round(rpd.DailyPL[DayOfWeek.Wednesday] * 100 / accSize, 1),
                        Math.Round(rpd.DailyPL[DayOfWeek.Thursday] * 100 / accSize, 1),
                        Math.Round(rpd.DailyPL[DayOfWeek.Friday] * 100 / accSize, 1),
                        Math.Round(rpd.TotalProfit * 100 / accSize, 1)
                    );
                }
                else
                {
                    grvWeeklyReport.Rows.Add(
                        rpd.WeekNumber,
                        rpd.DailyPL[DayOfWeek.Monday],
                        rpd.DailyPL[DayOfWeek.Tuesday],
                        rpd.DailyPL[DayOfWeek.Wednesday],
                        rpd.DailyPL[DayOfWeek.Thursday],
                        rpd.DailyPL[DayOfWeek.Friday],
                        rpd.TotalProfit
                        );
                }
                if (rpd.DailyPL[DayOfWeek.Monday] > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[1].Style.BackColor = System.Drawing.Color.GreenYellow;
                if (rpd.DailyPL[DayOfWeek.Tuesday] > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[2].Style.BackColor = System.Drawing.Color.GreenYellow;
                if (rpd.DailyPL[DayOfWeek.Wednesday] > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[3].Style.BackColor = System.Drawing.Color.GreenYellow;
                if (rpd.DailyPL[DayOfWeek.Thursday] > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[4].Style.BackColor = System.Drawing.Color.GreenYellow;
                if (rpd.DailyPL[DayOfWeek.Friday] > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[5].Style.BackColor = System.Drawing.Color.GreenYellow;
                if (rpd.TotalProfit > mMinProfit) grvWeeklyReport.Rows[lastIdx].Cells[6].Style.BackColor = System.Drawing.Color.GreenYellow;

                if (rpd.DailyPL[DayOfWeek.Monday] < 0) grvWeeklyReport.Rows[lastIdx].Cells[1].Style.BackColor = System.Drawing.Color.Brown;
                if (rpd.DailyPL[DayOfWeek.Tuesday] < 0) grvWeeklyReport.Rows[lastIdx].Cells[2].Style.BackColor = System.Drawing.Color.Brown;
                if (rpd.DailyPL[DayOfWeek.Wednesday] < 0) grvWeeklyReport.Rows[lastIdx].Cells[3].Style.BackColor = System.Drawing.Color.Brown;
                if (rpd.DailyPL[DayOfWeek.Thursday] < 0) grvWeeklyReport.Rows[lastIdx].Cells[4].Style.BackColor = System.Drawing.Color.Brown;
                if (rpd.DailyPL[DayOfWeek.Friday] < 0) grvWeeklyReport.Rows[lastIdx].Cells[5].Style.BackColor = System.Drawing.Color.Brown;
                if (rpd.TotalProfit < 0) grvWeeklyReport.Rows[lastIdx].Cells[6].Style.BackColor = System.Drawing.Color.Brown;
            }
            // 2. Fill Overal Data
            txtTotalProfit.Text = mTotalProfit.ToString("###,###,###.##");
            txtMaxLoss.Text = mMaxLoss.ToString("###,###,###.##");
            txtTotalProfitPercent.Text = (mTotalProfit / accSize).ToString("+##.##%;-##.##%");
            txtMaxLossPercent.Text = (mMaxLoss / accSize).ToString("+##.##%;-##.##%");

            txtWinrate.Text = ((float)tpCount / (tpCount + slCount)).ToString("###.##%");
            txtAvgRR.Text = (tpSum / tpCount / (accSize/100)).ToString("##.# R");
        }

        private void readingTradeDataFromFile(string filePath)
        {
            #region Reading excel file
            SLDocument sl;
            try
            {
                sl = new SLDocument(filePath, "Trades");
            }
            catch (Exception)
            {
                MessageBox.Show("There is an issue when open excel file!");
                cbbFilePath.Items.Remove(cbbFilePath.Text);
                return;
            }
            int row = 2;
            int orderNo = sl.GetCellValueAsInt32(row, INDEX_ORDERNO);
            mTradeDataList.Clear();
            while (orderNo != 0)
            {
                TradeData tradeData = new TradeData();
                tradeData.OrderNo = orderNo;
                tradeData.OpenTime = sl.GetCellValueAsDateTime(row, INDEX_OPENTIME);
                tradeData.CloseTime = sl.GetCellValueAsDateTime(row, INDEX_CLOSETIME);
                tradeData.ProfitLoss = sl.GetCellValueAsDouble(row, INDEX_PL);
                mTradeDataList.Add(tradeData);
                row++;
                orderNo = sl.GetCellValueAsInt32(row, 1);
            }
            #endregion

            reloadTradeDataToTable();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                readingTradeDataFromFile(ofd.FileName);
                cbbFilePath.Text = ofd.FileName;
                cbbFilePath.Items.Add(ofd.FileName);
            }
            else
            {
                ofd.Dispose();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("History.txt");
            file.WriteLine(numAccountSize.Value.ToString());
            foreach (var item in cbbFilePath.Items)
            {
                string filePath = item.ToString();
                if (filePath == cbbFilePath.Text)
                {
                    filePath += "*";
                }
                file.WriteLine(filePath);
            }
            file.Close();
        }

        private void cbbFilePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            readingTradeDataFromFile(cbbFilePath.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            readingTradeDataFromFile(cbbFilePath.Text);
        }

        private void grvWeeklyReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex <= 0)
            {
                return;
            }
            DayOfWeek dayOfWeek = DayOfWeek.Sunday;
            switch (e.ColumnIndex)
            {
                case 1: dayOfWeek = DayOfWeek.Monday; break;
                case 2: dayOfWeek = DayOfWeek.Tuesday; break;
                case 3: dayOfWeek = DayOfWeek.Wednesday; break;
                case 4: dayOfWeek = DayOfWeek.Thursday; break;
                case 5: dayOfWeek = DayOfWeek.Friday; break;
            }
            grvDailyDetail.Rows.Clear();
            double tpSum = 0.0;
            int tradeCount = 0;
            int tpCount = 0;
            int beCount = 0;
            int slCount = 0;
            string beginDate = "";
            string endDate = "";
            for (DayOfWeek d = DayOfWeek.Monday; d <= DayOfWeek.Friday; d++)
            {
                if (dayOfWeek != DayOfWeek.Sunday && dayOfWeek != d)
                {
                    continue;
                }
                foreach (TradeData td in mReportDataList[e.RowIndex].DailyDetail[d])
                {
                    if (beginDate == "") beginDate = td.OpenTime.ToString("dd/MM/yyyy");
                    else
                    {
                        string thisDay = td.OpenTime.ToString("dd/MM/yyyy");
                        if (endDate != thisDay) endDate = thisDay;
                    }
                    grvDailyDetail.Rows.Add(
                        grvDailyDetail.Rows.Count + 1,
                        td.ProfitLoss
                        );
                    tradeCount++;
                    if (td.ProfitLoss > mMinProfit)
                    {
                        tpCount++;
                        tpSum += td.ProfitLoss;
                    }
                    else if (td.ProfitLoss < 0)
                    {
                        slCount++;
                    }
                    else // BE case
                    {
                        beCount++;
                    }
                }
            }

            // Fill detail info
            if (beginDate == endDate)
            {
                grDailyDetail.Text = "Chi tiết ngày: " + beginDate;
            }
            else
            {
                grDailyDetail.Text = "Chi tiết tuần: " + beginDate + "-" + endDate;
            }
            txtDetailTongLenh.Text = tradeCount.ToString("Tổng Lệnh: ##");
            txtDetailTpBeSl.Text = "TP/BE/SL: " + tpCount.ToString() + "/" + beCount.ToString() + "/" + slCount.ToString();
            txtDetailWinRate.Text = ((double)tpCount / (slCount + tpCount)).ToString("WinRate: ##.#%");
            txtDetailAvgRR.Text = (tpSum / tpCount / mMinProfit).ToString("AvgRR: 0 R");
            if (tpCount == 0)
            {
                txtDetailWinRate.Text = "WinRate: 0.0%";
                txtDetailAvgRR.Text = "AvgRR: 0 R";
            }
        }
    }
}
