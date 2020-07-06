using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.Model
{
    public class DataService
    {
        public string CustomerName { get; set; }
        public string Speciality { get; set; }

        public ObservableCollection<DataService> ListCustomers
        {
            get
            {
                return new ObservableCollection<DataService>()
                {
                new DataService() { CustomerName = "Assam Toumi", Speciality = ".net" },
                new DataService() { CustomerName = "AssamToumi", Speciality = ".nett" },
                new DataService() { CustomerName = "Assam Toumi", Speciality = ".net" },
                new DataService() { CustomerName = "Assam Toumi", Speciality = ".net" },
                new DataService() { CustomerName = "Assam Toumi", Speciality = ".net" }
                 };
            }

        }
    }
}

