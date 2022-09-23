using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace QuotationApp.Classes
{
    public  class Cl_Data : INotifyPropertyChanged
    {
        #region Descriptions
        private string _Dealer;

        #endregion

        #region "Props"

        public string Dealer
        {
            get { return _Dealer; }
            set 
            { _Dealer = value;
                OnPropertyChanged("Dealer");
            }
        }
                

        #endregion

        #region Costs

      

        #endregion

        #region PropertyChangedEvents
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

