﻿using System;
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

namespace MissionControl {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

        }

        private void LedPositionSlider_HigherValueChanged(object sender, RoutedEventArgs e) {

        }

        private void LedPositionSlider_LowerValueChanged(object sender, RoutedEventArgs e) {

        }
    }
}
