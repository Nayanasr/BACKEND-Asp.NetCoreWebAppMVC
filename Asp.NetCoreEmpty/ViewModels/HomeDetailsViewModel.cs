using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreEmpty.Modal;

namespace Asp.NetCoreEmpty.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employee employee { get; set; }
        public string Title { get;  set; }

        //public IEnumerable<Employee> employeeList { get; set; }
    }
}
