﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace apk_user
{
    public partial class zabukowaneuser : UserControl
    {
        public zabukowaneuser()
        {
            InitializeComponent();
            string command = "SELECT userid FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string userid = reader["userid"].ToString();
                Console.WriteLine(userid);

            }

        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public static string username;
        public static string user_password;
        public void userdid(string a, string b)
        {
            username = a.ToString();
            user_password = b.ToString();
        }

        private void zabukowaneuser_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}