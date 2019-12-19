using SCM_System.IDAL;
using SCM_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;

namespace SCM_System.DAL
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// 配置连接字符串
        /// </summary>
        public readonly db_SCM _db;


        public BaseService(db_SCM db)
        {
            _db = db;
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model">模型类</param>
        /// <returns>int</returns>
        public async Task<int> CreateAsync(T model)
        {
            _db.Set<T>().Add(model);
            return await _db.SaveChangesAsync();
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model">模型类</param>
        /// <returns>int</returns>
        public async Task<int> EditAsync(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
            return await _db.SaveChangesAsync();
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }



        public async Task<int> RemoveAsync(T model)
        {
            _db.Entry(model).State = EntityState.Deleted;
            return await _db.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~BaseService()
        // {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }


        #endregion


        #region Page
        /// <summary>
        /// 实现分页
        /// </summary>
        /// <typeparam name="T">对模型类的哪个类型需要分页</typeparam>
        /// <param name="mainkey">主键</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小(默认为3)</param>
        /// <returns></returns>
        public MyPage<T> AchieveMyPage<T>(string mainkey,int index = 1, int size = 3) where T:class
        {
            return _db.customPage<T>(mainkey, index, size);
        }

        #endregion



    }
}
