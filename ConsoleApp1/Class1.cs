using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Class1{
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }

        public string CompleteName
        {
            get
            {
                return FirstName + " " + LastName;
            }

            set
            {
                CompleteName = FirstName + " " + LastName;
            }
        }
    }
}