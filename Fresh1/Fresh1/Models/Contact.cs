using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fresh1.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
