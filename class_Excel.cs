using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;// thư viện để giao tiếp với cơ sở dữ liệu 
using System.Drawing;// thư viện liên quan đến đồ họa và vẽ giao diện đồ họa 
using Excel = Microsoft.Office.Interop.Excel;//thêm thư viện excel 
using Microsoft.Office.Interop.Excel;

namespace Mix_System
{
    // Xuất Excel
    public class class_Excel_Export
    {
        // Hàm thực hiện xuất Excel
        public void Execute(DateTimePicker dtpk_DateStart,
                            DateTimePicker dtpk_TimeStart,
                            DateTimePicker dtpk_DateEnd,
                            DateTimePicker dtpk_TimeEnd,
                            DateTimePicker dtpk_ShiftDate,
                            RadioButton rdb_SortbyTime,
                            ComboBox cb_ShiftSelect
            )

        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi missing thư viện EXCEL");
                    return;
                }

                xlApp.Visible = false;
                object misValue = System.Reflection.Missing.Value;//
                Workbook wb = xlApp.Workbooks.Add(misValue);// tạo workbook 
                Worksheet ws = (Worksheet)wb.Worksheets[1];// tạo worksheet 

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }

                int row = 1; // Khai báo hàng bắt đầu của Sheet
                //=======================THIẾT KẾ PHẦN HEADER=====================
                // Hình ảnh logo
                var imgRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[1, 1];//tạo img hàng 1 cột 1
                Microsoft.Office.Interop.Excel.Range oRange = imgRange;//
                string imgPath = "C:\\Users\\ACER\\Pictures\\Screenshots\\logo.jpg";//đương dẫn tới file ảnh 
                //kích thước của logo 
                const float Height = 50;
                const float Width = 50;
                float Left = (float)((double)oRange.Left);
                float Top = (float)((double)oRange.Top);
                var mso = Microsoft.Office.Core.MsoTriState.msoFalse;
                var msoCTrue = Microsoft.Office.Core.MsoTriState.msoCTrue;
                ws.Shapes.AddPicture(imgPath, mso, msoCTrue, Left, Top, Height, Width);
                // Tên & thông tin công ty
                Range company_Name = ws.get_Range("B1","J1");
                Range Adress = ws.get_Range("B2");
                Range Contact = ws.get_Range("B3");
                //Value2 trả về giá trị ô dưới dạng opject không thực hiện việc chuyển đổi kiểu dữ liệu động
                var alignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                company_Name.Value2 = "CÔNG TY TNHH KỸ THUẬT CÔNG NGHỆ TRẦN VĂN HẬU";
                company_Name.Merge();
                Adress.Value2 = "SPKT, TP Hồ Chí Minh, Việt Nam";
                Contact.Value2 = "Hotline: +84 0989025***";
                company_Name.Font.Size = 18;
                company_Name.Font.Name = "Times New Roman";
                company_Name.Font.Bold = true;
                company_Name.Cells.HorizontalAlignment = alignment;
                // Xuất ngày/giờ in báo cáo
                Range printtime = ws.get_Range("A4");
                string actime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string printtimest = "Ngày tháng: " + actime;
                printtime.Value2 = printtimest;
                //Xuất dòng Tiêu đề
                Range tittle = ws.get_Range("A5", "J5");
                tittle.Value2 = "BÁO CÁO SẢN XUẤT";
                tittle.Merge();
                tittle.Font.Size = 14;
                tittle.Font.Name = "Times New Roman";
                tittle.Cells.HorizontalAlignment = alignment;
                //Tạo ô Số Thứ Tự (STT)
                Range STT = ws.get_Range("A6");
                STT.Value2 = "STT";
                STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                STT.ColumnWidth = 10;
                //Tạo ô Thời gian
                Range sTime = ws.get_Range("B6");
                sTime.Value2 = "Thời gian";
                sTime.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sTime.ColumnWidth = 20;
                //Tạo ô Ca sản xuất
                Range Shift = ws.get_Range("C6");
                Shift.Value2 = "Ca SX";
                Shift.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                Shift.ColumnWidth = 15;
                //Tạo ô giá trị tag số nguyên
                Range tag_Order_ID = ws.get_Range("D6");
                tag_Order_ID.Value2 = "Mã Đơn";
                tag_Order_ID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Order_ID.ColumnWidth = 20;
                //Tạo ô giá trị tag số thực
                Range tag_Setting_Weight1 = ws.get_Range("E6");
                tag_Setting_Weight1.Value2 = "Cài Đặt NL1[kg]";
                tag_Setting_Weight1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Setting_Weight1.ColumnWidth = 20;
                //Tạo ô ghi chú
                Range tag_Actual_Weight1 = ws.get_Range("F6");
                tag_Actual_Weight1.Value2 = "Thực Tế NL1[kg]";
                tag_Actual_Weight1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Actual_Weight1.ColumnWidth = 20;
                Range tag_Setting_Weight2 = ws.get_Range("G6");
                tag_Setting_Weight2.Value2 = "Cài Đặt NL2[kg]";
                tag_Setting_Weight2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Setting_Weight2.ColumnWidth = 20;
                //Tạo ô ghi chú
                Range tag_Actual_Weight2 = ws.get_Range("H6");
                tag_Actual_Weight2.Value2 = "Thực Tế NL2[kg]";
                tag_Actual_Weight2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Actual_Weight2.ColumnWidth = 20;
                Range tag_Actual_Time_Tron = ws.get_Range("I6");
                tag_Actual_Time_Tron.Value2 = "Thời Gian Trộn[s]";
                tag_Actual_Time_Tron.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Actual_Time_Tron.ColumnWidth = 20;
                Range tag_note = ws.get_Range("J6");
                tag_note.Value2 = "Ghi Chú";
                tag_note.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_note.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range tittle_style = ws.get_Range("A5", "J6");
                var backcolor = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                var fomtcolor = ColorTranslator.ToOle(System.Drawing.Color.Black);
                tittle_style.Interior.Color = backcolor;
                tittle_style.Font.Color = fomtcolor;
                tittle_style.Font.Bold = true;
                //=======================XUẤT CƠ SỞ DỮ LIỆU=====================
                // Lựa chọn tìm kiếm
                // Theo khoảng thời gian
                string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
                string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
                string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
                string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");

                string Srange1 = Date_Start + " " + Time_Start;
                string Erange1 = Date_End + " " + Time_End;
                // Theo ca sản xuất
                string ShiftDate = dtpk_ShiftDate.Value.ToString("yyyy-MM-dd");
                string tomorrow = dtpk_ShiftDate.Value.AddDays(1).ToString("yyyy-MM-dd");
                string rpShift_Search_Start = ShiftDate + " 00:00:00";
                string rpShift_Search_End = ShiftDate + " 23:59:59";
                string rptomorrow = tomorrow + " 23:59:59";

                string Srange2 = "";
                string Erange2 = "";

                if (cb_ShiftSelect.Text != "C") // Nếu là ca C
                {
                    Srange2 = rpShift_Search_Start;
                    Erange2 = rpShift_Search_End;
                }
                else
                {
                    Srange2 = rpShift_Search_Start;
                    Erange2 = rptomorrow;
                }

                // Khởi tạo datalist array

                report_ExcelDataContext database = new report_ExcelDataContext();
                var datalist = from tb in database.Mix_System_Datas
                               select new
                               {
                                   col1 = tb.Datetime.ToString(),
                                   col2 = tb.Shift,
                                   col3 = tb.Order_ID,
                                   col4 = tb.Setting_Weight1,
                                   col5 = tb.Actual_Weight1,
                                   col6 = tb.Setting_Weight2,
                                   col7 = tb.Actual_Weight2,
                                   col8 = tb.Actual_Time_Tron

                               };
                // Nếu tìm kiếm theo thời gian

                if (rdb_SortbyTime.Checked == true)
                {
                    datalist = from tb in database.Mix_System_Datas
                               where
                               tb.Datetime >= DateTime.Parse(Srange1) &&
                               tb.Datetime < DateTime.Parse(Erange1)
                               select new
                               {
                                   col1 = tb.Datetime.ToString(),
                                   col2 = tb.Shift,
                                   col3 = tb.Order_ID,
                                   col4 = tb.Setting_Weight1,
                                   col5 = tb.Actual_Weight1,
                                   col6 = tb.Setting_Weight2,
                                   col7 = tb.Actual_Weight2,
                                   col8 = tb.Actual_Time_Tron
                               };
                }

                // Nếu tìm kiếm theo ca
                else
                {
                    datalist = from tb in database.Mix_System_Datas
                               where tb.Shift == cb_ShiftSelect.Text
                               && tb.Datetime >= DateTime.Parse(Srange2)
                               && tb.Datetime < DateTime.Parse(Erange2)
                               select new
                               {
                                   col1 = tb.Datetime.ToString(),
                                   col2 = tb.Shift,
                                   col3 = tb.Order_ID,
                                   col4 = tb.Setting_Weight1,
                                   col5 = tb.Actual_Weight1,
                                   col6 = tb.Setting_Weight2,
                                   col7 = tb.Actual_Weight2,
                                   col8 = tb.Actual_Time_Tron
                               };
                }
                int stt = 0;
                row = 6; //Bắt đầu xuất từ dòng số 7
                foreach (var element in datalist)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, element.col1, element.col2, element.col3, element.col4, element.col5, element.col6, element.col7, element.col8 };
                    Range rowData = ws.get_Range("A" + row, "I" + row);
                    rowData.Font.Size = 11;
                    rowData.Font.Name = "Times New Roman";
                    rowData.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    rowData.Value2 = arr;
                }
                //=======================TẠO TRƯỜNG CHỮ KÝ=====================
                //Tạo ô chữ ký
                int signrow = row + 2;
                int signnote = signrow + 1;

                // Người ký 1
                string signpos1 = "B" + signrow;
                string signnotepos1 = "B" + signnote;

                Range sign1 = ws.get_Range(signpos1);
                sign1.Value2 = "Giám đốc";
                sign1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign1.Font.Bold = true;

                Range signnote1 = ws.get_Range(signnotepos1);
                signnote1.Value2 = "(Ký ghi rõ họ tên)";
                signnote1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;// hàm canh giữa đối tượng cột

                // Người ký 2
                string signpos2 = "F" + signrow;
                string signnotepos2 = "F" + signnote;

                Range sign2 = ws.get_Range(signpos2);
                sign2.Value2 = "Trưởng ca";
                sign2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign2.Font.Bold = true;

                Range signnote2 = ws.get_Range(signnotepos2);
                signnote2.Value2 = "(Ký ghi rõ họ tên)";
                signnote2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Người ký 3
                string signpos3 = "J" + signrow;
                string signnotepos3 = "J" + signnote;

                Range sign3 = ws.get_Range(signpos3);
                sign3.Value2 = "Người in biểu";
                sign3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign3.Font.Bold = true;

                Range signnote3 = ws.get_Range(signnotepos3);
                signnote3.Value2 = "(Ký ghi rõ họ tên)";
                signnote3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // ================CÁC PHẦN THIẾT KẾ KHÁC===================
                class_Excel.BorderAround(ws.get_Range("A5", "J" + row));
                // Step 1: Lưu file excel xuống Ổ cứng
                string datetimenow = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                string saveExcelFile = @"d:\Excel_Report_" + datetimenow + ".xlsx";
                wb.SaveAs(saveExcelFile);
                //Step 2: Đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //Step 3: Thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                class_Excel.releaseObject(ws);
                class_Excel.releaseObject(wb);
                class_Excel.releaseObject(xlApp);
                //Step 4: Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    // ================== CÁC HÀM MẶC ĐỊNH ====================
    public static class class_Excel
    {
        //Hàm kẻ khung cho Excel (mặc định)
        public static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel (Mặc định)
        public static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            {
                GC.Collect(); 
            }
        }
    }
}