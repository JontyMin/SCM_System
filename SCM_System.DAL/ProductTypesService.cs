using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
namespace SCM_System.DAL
{
    public class ProductTypesService:BaseService<ProductTypes>
    {
        public ProductTypesService() : base(new db_SCM()) { }
    }
}
