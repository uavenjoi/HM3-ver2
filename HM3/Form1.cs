﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM3
{
    public partial class Form1 : Form
    {
        static String1 StringEditor1 = new String1();
        //Лучше чтобы коллекция сначала была пустой, а значения добавлять уже при нажатии на кнопку
        List<String1.Filter> strfiletr = new List<String1.Filter> { StringEditor1.UpperRegister, StringEditor1.Revers, StringEditor1.SpaceAdd };
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = InputTextBox.Text;
            if (checkUpper.Checked)//можно сократить вот так
            if (checkUpper.Checked == true)
            {
                //дублирование кода. Сначала нужно добавить в strfiletr значения и вызвать ровно 1 раз GetFiltered
                OutputTextBox.Text = StringEditor1.GetFiltered(OutputTextBox.Text, strfiletr[0]);
            }
            if (checkRevers.Checked == true)
            {
                OutputTextBox.Text = StringEditor1.GetFiltered(OutputTextBox.Text, strfiletr[1]);
            }
            if (checkSpace.Checked == true)
            {
                OutputTextBox.Text = StringEditor1.GetFiltered(OutputTextBox.Text, strfiletr[2]);
            }
        }
    }
}
