﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btbMostrar_Clicked(object sender, EventArgs e)
        {
            lblRes.Text = "Bienvenido/a al sistema " + txtNombre.Text + " " + txtApellido.Text + ".";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
