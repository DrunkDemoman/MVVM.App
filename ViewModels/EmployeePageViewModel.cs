using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public partial class EmployeePageViewModel:ObservableObject
    {
        [ObservableProperty]
        public string _empName;
    }
}
