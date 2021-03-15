﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Two
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
            
        }

        public decimal Seed
        {
            get
            {
                return Seed_Up_Down.Value;
            }
            set
            {
                Seed_Up_Down.Value = value;
            }
           
        }



        //C++ but C# 
        //public decimal GetSeed()
        //{
        //    return Seed_Up_Down.Value;
        //}

        //public void SetSeed(decimal seed)
        //{
        //    Seed_Up_Down.Value = seed;
        //}

    }
}