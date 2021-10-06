﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Milestone2_PRG282
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDisplayCRUD.Text = "Insert a new student.";
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        lblDisplayCRUD.Text = "Insert a new student.";
                        break;
                    }
                case 1:
                    {
                        lblDisplayCRUD.Text = "Update/Delete student.";
                        break;
                    }
                case 2:
                    {
                        lblDisplayCRUD.Text = "Add a new module.";
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete *SOMEONE* from the database?" , "WARNING" , MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

            }
        }

        private void lblDisplayCRUD_Click(object sender, EventArgs e)
        {

        }
    }
}