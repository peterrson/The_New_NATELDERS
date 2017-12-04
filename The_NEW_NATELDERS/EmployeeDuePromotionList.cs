﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_NEW_NATELDERS
{
    public partial class EmployeeDuePromotionList : Form
    {
       public DataTable dt = new DataTable();
        public EmployeeDuePromotionList()
        {
            InitializeComponent();
        }

        private void EmployeeDuePromotionList_Load(object sender, EventArgs e)
        {
            
            EmployeeGrid.DataSource = dt;
        }

        private void EmployeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeGrid.CurrentRow.Index != -1)
            {
                this.Hide();
                Promote ss = new Promote();
                ss.Surname = EmployeeGrid.CurrentRow.Cells[0].Value.ToString();
                ss.OtherNames = EmployeeGrid.CurrentRow.Cells[1].Value.ToString();
                ss.RCCNO = EmployeeGrid.CurrentRow.Cells[2].Value.ToString();
                ss.YearLastPromoted = EmployeeGrid.CurrentRow.Cells[3].Value.ToString();
                ss.Designation = EmployeeGrid.CurrentRow.Cells[4].Value.ToString();
                ss.ShowDialog();
            }
        }
    }
}