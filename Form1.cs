﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace db1
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {

        }

        string sql = "insert into kb values('"+ textname.text+"','"+txtroll.text+"' ,'"+txtcombo.text+"')";
        SqlDataAdapter da = new SqlDataAdapter(sql , Class1.cs);
        DataTable dt =new DataTable();
        int a =DataTable.fill(dt);
        if(a>=0)
    {
        MessageBox.show("Record inserted ","Database",MessageBoxButtons.OK,MessageBoxIcon.Information

        private void bunClear_Click(object sender, EventArgs e)
        {
          Clear();
        } 
    }
    else
{
    MessageBox.show("There was Error ! ","Database",MessageBoxButtons.OK,MessageBoxIcon.Error );

}
    private void clear()
{
    txtRoll.text=" ";
    txtName.text=" ";
    cmbcouse = " ";
    textName.Focuse;

}


    }

