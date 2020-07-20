﻿using FullScratch.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FullScratch.Models.Command
{
    public class OpenFileCmd : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("OpenFileCmd");
            MessageBox.Show(CustomTabViewModel.Tabs[0].Contents);
            MessageBox.Show(CustomTabViewModel.Tabs[1].Contents);

        }
    }
}
