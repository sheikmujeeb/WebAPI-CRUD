using System;

namespace CRUD_WebAPIclasslibrary
{
    public class Entity
    {    
            public int BusID { get; set; }
            public string BusName { get; set; }
            public long DriverMobilenumber { get; set; }
            public string StartPoint { get; set; }
            public string Destination { get; set; }
            public int Fare { get; set; }
            public int NoofPassenger { get; set; }

        
    }
}
