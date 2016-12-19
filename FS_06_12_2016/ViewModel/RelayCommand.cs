﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FS_06_12_2016.ViewModel
{
   public class RelayCommand : ICommand
    {
        private readonly Action execute;

        public RelayCommand(Action execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.execute();
        }

        public event EventHandler CanExecuteChanged;

    }

}
