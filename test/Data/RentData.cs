using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class RentData : EntityData<Rent>
    {
       
        public List<Rent> SearchDate(DateTime value)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.Rents
                            where x.RentDate.Day == value.Day && x.RentDate.Month == value.Month
                            select new
                            {
                                Rent = x,
                                CusName = x.Customer.Name,
                                Title =  x.DVD.Title,
                                Genre = x.DVD.Genre
                            };


                foreach (var item in query)
                {
                    item.Rent.CusName = item.CusName;
                    item.Rent.Title = item.Title;
                    item.Rent.Genre = item.Genre;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.Rent);    
            }
        }
    }
}
