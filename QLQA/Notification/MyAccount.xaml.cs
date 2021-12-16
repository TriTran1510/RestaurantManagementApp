﻿using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace QLQA.Notification
{
    /// <summary>
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : UserControl
    {
        #region Chuỗi kết nỗi
        private static string Connectionstring = "Data Source=DESKTOP-68RLUI9\\SQLEXPRESS;Initial Catalog=QuanAn;Integrated Security=True";
        #endregion
        public MyAccount()
        {
            InitializeComponent();
        }

        #region MD5
        public string ChangeToMD5(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";

            foreach (var item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        #endregion

        #region Update button
        private void UpdateAC_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection(Connectionstring);
            ketnoi.Open();

            int Aemployee_ID = SQL.lg.EMPLOYEEid;
            string Ausername = tbUsername.Text.ToString();
            string Aoldpass = ChangeToMD5(tbOldPassword.Password.ToString());
            string Apassword = ChangeToMD5(tbPassword.Password.ToString());
            string Aconfirm_pass = ChangeToMD5(tbConfirmPassword.Password.ToString());

            #region Check pass cũ và username cũ
            if (!SQL.CheckLogin(Ausername, Aoldpass))
            {
                QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Tài khoản hoặc mật khẩu cũ chưa đúng !");
                QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
                b.DataContext = dia;
                DialogHost.Show(b, "Myaccount");
                return;
            }
            #endregion

            #region Check pass mới
            
            if (Apassword != Aconfirm_pass)
            {
                QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Mật khẩu không giống nhau !");
                QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
                b.DataContext = dia;
                DialogHost.Show(b, "Myaccount");
                tbPassword.Focus();
            }
            #endregion

            //Viết SQL
            string updateAccount = "UPDATE ACCOUNT " +
                                    "SET USERNAME = N'" + Ausername + "', PASSWORD = N'" + Apassword + "' " +
                                    "WHERE EMPLOYEEid = '" + Aemployee_ID + "'";
            SqlCommand queryupdateAccount = new SqlCommand(updateAccount, ketnoi);

            try
            {
                queryupdateAccount.ExecuteNonQuery();
                QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Cập nhật tài khoản thành công!");
                QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
                b.DataContext = dia;
                DialogHost.Show(b, "Myaccount");

            }
            catch (Exception es)
            {
                QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Xảy ra lỗi khi cập nhật tài khoản!\nXin hãy kiểm tra lại.");
                QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
                b.DataContext = dia;
                DialogHost.Show(b, "Myaccount");
            }
        }

        #region Load Myaccount
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            tbUsername.Text = SQL.lg.USERNAME.ToString();
            if (SQL.lg.ROLEid == 0)
            {
                tbPosition.Text = "Người quản lí";
            }
            else
            {
                tbPosition.Text = "Nhân viên";
            }
        }
        #endregion
        #endregion

    }
}
