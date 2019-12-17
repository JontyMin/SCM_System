using SCM_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.IDAL
{
    public interface IBaseService<T> : IDisposable where T : BaseEntity
    {
        Task<int> CreateAsync(T model);
        Task<int> EditAsync(T model);
        Task<int> RemoveAsync(T model);
        Task<List<T>> GetAllAsync();
    }
}
