﻿using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWarcraft.Views
{
    /// <summary>
    /// Interaction logic for PlayerBaseView.xaml
    /// </summary>
    public partial class PlayerBaseView : UserControl, IView
    {
        public PlayerBaseView()
        {
            InitializeComponent();
        }
    }
}
