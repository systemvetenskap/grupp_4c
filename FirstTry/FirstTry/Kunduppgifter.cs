﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTry
{
    partial class Kunduppgifter : Form
    {
        Tempkop tk = new Tempkop();

        public Kunduppgifter(Tempkop tk2)
        {

            InitializeComponent();
            tk = tk2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert into kund, spara kund id till tempköp 

            this.Hide();
            Platskarta pk = new Platskarta(tk);
            pk.ShowDialog();
            this.Close();
        }
    }
}
