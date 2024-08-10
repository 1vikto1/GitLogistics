using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Logistics.Model
{
    public class ModelUsers : INotifyPropertyChanged
    {

        private string name;
        private string number;
        private int company;

        public string Name
        {
            get 
            {
                MessageBox.Show("вава");
                return name; 
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
