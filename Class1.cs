using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Management_System
{
    public class Class1
    {

        public string connect()
        {
            return (@"Data Source=DESKTOP-ANP8JUS\SQLEXPRESS;Initial Catalog=HRManagement;Integrated Security=True;Pooling=False");
        }
    }
}