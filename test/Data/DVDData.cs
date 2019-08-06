using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class DVDData : EntityData<DVD>
    {
        public bool CheckDVDNum(int dvdNum)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.DVDs
                            where x.DvdID == dvdNum
                            select x;

                DVD dvd = new DVD();
                dvd = query.FirstOrDefault();

                if(dvd==null)
                {
                    return false;
                }
                return true;
            }
        }

        public List<DVD> Get(int dvdNum)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.DVDs
                            where x.DvdID == dvdNum
                            select x;
                return query.ToList();
            }
        }

        public DVD SearchDVDNum(int dvdNum)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.DVDs
                            where x.DvdID == dvdNum
                            select x;

                DVD dvd = new DVD();
                dvd = query.FirstOrDefault();

                return dvd;
            }
        }

        public List<DVD> SearchStateFalse()
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.DVDs
                            where x.RentStatus == false
                            select x;

                return query.ToList();
            }
        }
    }
}
