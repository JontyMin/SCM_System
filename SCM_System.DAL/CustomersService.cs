using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
namespace SCM_System.DAL
{
    public class CustomersService : BaseService<Customers>
    {
        public CustomersService():base(new db_SCM()) { 
        
        }
    }
}
