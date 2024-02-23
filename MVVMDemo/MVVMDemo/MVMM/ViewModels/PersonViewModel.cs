using MVVMDemo.MVMM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVMM.ViewModels
{
    public class PersonViewModel
        
    {
        public Person Person { get; set; }
        public PersonViewModel() {

            var Person = new Person

            {
                Name = "John",
                Age = 60,
                Married = true,
                BirthDate = new DateTime(1990, 08,06),
                Weight = 60,
            };
        }
    }
}
