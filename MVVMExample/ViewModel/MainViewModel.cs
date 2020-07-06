using GalaSoft.MvvmLight.Command;
using MVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace MVVMExample.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private DataService model;
        private ICommand command;
        private string customerName;
        private string speciality;

        private ObservableCollection<DataService> customers;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; OnPropertyChanged("CustomerName"); }
        }
        private string Speciality
        {
            get { return speciality; }
            set { speciality = value; OnPropertyChanged("Speciality"); }
        }
        public ObservableCollection<DataService> Customers
        {
            get { return customers; }
            private set
            {
                customers = value;
                OnPropertyChanged("Customers");
            }
        }
        public MainViewModel()
        {
            model = new DataService();
        }

        public ICommand ShowCommand
        {
            get
            {
                if (command == null)
                {
                    return command;

                }
                return command;
            }
        }

        public bool CanDoCommand()
        {
            return model != null ? true : false;
        }
        public void DoCommand()
        {
            Customers = model.ListCustomers;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}