using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
namespace SCM_System.DAL
{
    public class ProductsService:BaseService<Products>
    {
        public ProductsService() : base(new db_SCM())
        {

        }
    }
}
