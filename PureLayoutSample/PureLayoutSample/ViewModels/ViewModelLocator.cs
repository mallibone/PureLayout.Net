using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PureLayoutSample.ViewModels
{
    public class ViewModelLocator
    {
        private static readonly Lazy<ViewModelLocator> _instance = new Lazy<ViewModelLocator>(() => new ViewModelLocator(), LazyThreadSafetyMode.PublicationOnly);
        public static ViewModelLocator Instance = _instance.Value;

        private ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<TipCalculatorViewModel>();
        }

        public TipCalculatorViewModel TipCalculatorViewModel => SimpleIoc.Default.GetInstance<TipCalculatorViewModel>();
    }
}
