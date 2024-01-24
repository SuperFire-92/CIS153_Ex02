using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_01_23_2024_ButtonsAndLabels
{
    public partial class Form1 : Form
    {
        //Most of the time, we have private variables and public functions
        //private - can only be accessed in the class that it belongs to
        //public  - can be accessed in any class in the project

        #region Variables

        private int num;

        #endregion

        #region Actions

        public Form1()
        {
            InitializeComponent();

            num = int.Parse(lbl_num.Text);

            if (isEven(num))
            {
                changeLabelBlue();
            }
            else
            {
                changeLabelRed();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("add");
            num++;
            if (num >= 100)
            {
                num = 0;
            }
            if (isEven(num))
            {
                changeLabelBlue();
            }
            else
            {
                changeLabelRed();
            }
            lbl_num.Text = num.ToString();
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("subtract");
            num--;
            if (num < 0)
            {
                num = 99;
            }
            if (isEven(num))
            {
                changeLabelBlue();
            }
            else
            {
                changeLabelRed();
            }
            lbl_num.Text = num + "";
        }

        #endregion

        #region Functions

        //I would NEVER code like this, good grief this is messy
        public bool isEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changeLabelBlue()
        {
            lbl_num.ForeColor = Color.Blue;
        }

        public void changeLabelRed()
        {
            lbl_num.ForeColor = Color.Red;
        }

        #endregion
    }
}
