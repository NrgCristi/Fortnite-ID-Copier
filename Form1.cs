using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fortnite_ID_Copier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter The Weapon Name you want to copy the id in the console");
            Console.WriteLine("Enter The Weapon ID:");
            Console.ReadLine();
            Console.WriteLine("L Bozo HAHA");

        }
    }
}