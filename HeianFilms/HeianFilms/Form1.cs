﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeianFilms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Lg = new Login();
            Lg.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Cadastro Cdr = new Cadastro();
            Cdr.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
