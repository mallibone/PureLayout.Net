using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace PureLayoutSample.ViewModels
{
    public class TipCalculatorViewModel : ViewModelBase
    {
        public TipCalculatorViewModel()
        {
            TipHistory = new ObservableCollection<string>();
            CalculateTipCommand = new RelayCommand(CalculateTip);
            ClearTipHistoryCommand = new RelayCommand(() => TipHistory.Clear());
        }

        #region properties

        public ObservableCollection<string> TipHistory { get; }

        public string CurrentPrice { get; set; }
        public string CurrentTipPercentage { get; set; }
        public ICommand CalculateTipCommand { get; set; }
        public ICommand ClearTipHistoryCommand { get; set; }

        #endregion

        private void CalculateTip()
        {
            var currentValue = Convert.ToDecimal(CurrentPrice);
            var currentTipPercentage = Convert.ToDecimal(CurrentTipPercentage);

            var currentTip = currentValue * (currentTipPercentage / 100M);

            TipHistory.Add(currentTip.ToString("F2"));
        }
    }
}
