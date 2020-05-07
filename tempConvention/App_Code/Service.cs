using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    int IService.F2c(int c)
    {

        c = (((c - 32) * 5) / 9);
        return (c);
    }

     int IService.C2f(int c)
    {
        
        c = (((c * 9) / 5) + 32);
        return (c);
    }
   
}
