﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        private bool Comp1;

        private bool start;

        private bool finich;

        private Random r;

        private int x_Rezultat_Val;

        private int o_Rezultat_Val;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            x_Rezultat_Val = o_Rezultat_Val = 0;
            r = new Random();
            finich = false;
            start = false;
            Comp1 = false;
            InitButtonsEvents();
        }
        private void InitButtonsEvents()
        {
           // foreach (Button but in gamePolePanel.Controls)
            //    but.Click += But_Click;
        }
        
        
    }
}
