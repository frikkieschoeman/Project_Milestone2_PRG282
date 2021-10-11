﻿//Group 12
// Dylan Conradie 576864
// Franco Jacobs 576697
// Jacobus Schoeman 576855
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Milestone2_PRG282.BusinessLayer;

namespace Project_Milestone2_PRG282
{
    public partial class LogIn : Form
    {
        public static Form Creator;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to exit?" , "Exit" , MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                this.Close();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogInPassword.Clear();
            txtLogInUserName.Clear();
            txtCreatePassword.Clear();
            txtCreateUsername.Clear();
        }

        private void btnSign_in_Click(object sender, EventArgs e)
        {

            MainForm.Creator = this;
            MainForm Main = new MainForm();
            
            //this.Hide();
            //Main.ShowDialog(); //THESE CODE ARE JUST FOR TEST PURPOSES
            //this.Dispose();

            string username = txtLogInUserName.Text;
            string password = txtLogInPassword.Text;

            FileMethods fm = new FileMethods();
            string result = fm.ValidateLoginInputs(username, password);
            if (result == "G")
            {
                if (fm.CheckCredentials(username,password))
                {
                    this.Hide();
                    Main.ShowDialog();
                    //this.Dispose();Lol this broke something

                }
                else
                {
                    MessageBox.Show("Incorrect credentials");
                }
            }
            else
            {
                MessageBox.Show(result);
            }

          
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtCreateUsername.Text;
            string password = txtCreatePassword.Text;
            string added;
            MainForm Main = new MainForm();


            FileMethods fm = new FileMethods();
            string result = fm.ValidateNewLogin(username, password);
            if (result == "G")
            {
                if ((added = fm.Add_User(new User(username, password)))== "Failed to create")
                {
                    MessageBox.Show(added);
                }
                else
                {
                    MessageBox.Show(added);
                    this.Hide();
                    Main.ShowDialog();
                    this.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            //This button is not part of the final version
            //It is for ease of use for Lecturers and developers of the project
            txtLogInUserName.Text = "Devs";
            txtLogInPassword.Text = "PasswordForDevs@123";
            btnSign_in.PerformClick();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
