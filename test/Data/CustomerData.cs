using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class CustomerData : EntityData<Customer>
    {
        /// <summary>
        /// 참 은 가지고있다 불은 중복 되지 않았다.
        /// </summary>
        public bool CheckId(string id)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID == id
                            select x;

                Customer customer = new Customer();
                customer = query.FirstOrDefault();

                if (customer == null)
                {
                    return false;
                }

                return true;

            }
        }
        public List<Customer> Get()
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                return context.Set<Customer>().ToList();
            }
        }
        public List<Customer> SearchIdList(string id)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID.Equals(id)
                            select x;

                return query.ToList();
            }
        }
       public Customer SearchId(string id)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID == id
                            select x;
                Customer customer = new Customer();
                customer = query.FirstOrDefault();

                return customer;
            }
        }

    }
}
