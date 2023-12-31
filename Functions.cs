﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace quanlynhansu.Class
{
    class Functions
    {
        public static SqlConnection Con;


        public static void Connect()   // Tạo phương thức Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng

            //kết nối sql
            Con.ConnectionString = Properties.Settings.Default.QLNhanSuConnectionStringg;

            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }

        // Tạo phương thức Disconnect
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }



        // phương thức thực thi câu lệnh Select lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();                 //Khai báo đối tượng table thuộc lớp DataTable
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            dap.Fill(table);                                   //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }



        // phương thức thực thi câu lệnh Insert, Update, Delete (run sql)
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;                 //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con;           //Gán kết nối
            cmd.CommandText = sql;          //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();      //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();                  //Giải phóng bộ nhớ
            cmd = null;
        }



        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        //hàm date
        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 31) && (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 12) && (Convert.ToInt32(elements[2]) >= 1900))
                return true;
            else return false;
        }

        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
    }
}
