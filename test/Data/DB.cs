using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class DB
    {
        public static CustomerData Customer { get; } = new CustomerData();
        public static DVDData DVD { get; } = new DVDData();
        public static RentData Rent { get; } = new RentData();
    }
}
