﻿using System;
using System.Windows;

namespace Gadgets.Application.Services
{
    public class DialogService : IDialogService
    {
        public bool Confirm(string message)
        {
            var result = MessageBox.Show(message, "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            return result == MessageBoxResult.Yes ? true : false;
        }

        public void Exception(Exception ex)
        {
            string message = $@"An exception thrown: {ex.Message}

{ex.ToString()}";
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void Warning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}