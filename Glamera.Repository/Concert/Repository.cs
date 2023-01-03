using Microsoft.EntityFrameworkCore;
using Glamera.Domin.Context;
using Glamera.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Concert
{
    public class Repository<TEtity> : IRepository<TEtity> where TEtity : class
    {
        protected GlameraContext _GlameraContext { get; set; }
        public Repository(GlameraContext MARIHUBtaskContext)
        {
            this._GlameraContext = MARIHUBtaskContext;

        }
        public TEtity Add(TEtity entity)
        {
            _GlameraContext.Set<TEtity>().Add(entity);
            return _GlameraContext.SaveChanges() > 0 ? entity : null;
        }
        public async Task<TEtity> AddAsync(TEtity entity)
        {
            var result = await _GlameraContext.Set<TEtity>().AddAsync(entity);
            return await _GlameraContext.SaveChangesAsync() > 0 ? entity : null;
        }
        public TEtity GetBy(params object[] Id)
        {
            var MyObject = _GlameraContext.Set<TEtity>().Find(Id);
            return MyObject;
        }
        public async Task<TEtity> GetByAsync(params object[] Id)
        {
            //var MyObject = await _BloggerContext.Set<TEtity>().FindAsync(Id);
            return await _GlameraContext.Set<TEtity>().FindAsync(Id);
        }
        public List<TEtity> GetAllBind()
        {
            return GetAll().ToList();
        }
        public IEnumerable<TEtity> GetAll()
        {
            return this._GlameraContext.Set<TEtity>().AsNoTracking();
        }
        public async Task<IEnumerable<TEtity>> GetAllAsyn()
        {
            return await this._GlameraContext.Set<TEtity>().ToListAsync(); ;
        }
        public IQueryable<TEtity> GetAllQurAsync()
        {
            return this._GlameraContext.Set<TEtity>();
        }
        public TEtity RemoveById(params object[] Id)
        {
            var entity = GetBy(Id);
            _GlameraContext.Set<TEtity>().Remove(GetBy(Id));

            return _GlameraContext.SaveChanges() > 0 ? entity : null;
        }
        public TEtity Remove(TEtity entity)
        {
            _GlameraContext.Set<TEtity>().Remove(entity);

            return _GlameraContext.SaveChanges() > 0 ? entity : null;
        }
        public async Task<TEtity> RemoveByIdAsync(params object[] Id)
        {
            var entity = await _GlameraContext.Set<TEtity>().FindAsync(Id);
            _GlameraContext.Set<TEtity>().Remove(entity);
            return await _GlameraContext.SaveChangesAsync() > 0 ? entity : null;
        }
        public TEtity Update(TEtity entity)
        {
            _GlameraContext.Set<TEtity>().Update(entity);
            return _GlameraContext.SaveChanges() > 0 ? entity : null;
        }
        public async Task<TEtity> UpdateAsync(TEtity entity)
        {
            _GlameraContext.Set<TEtity>().Update(entity);
            return await _GlameraContext.SaveChangesAsync() > 0 ? entity : null;
        }
        public void Save()
        {
            _GlameraContext.SaveChanges();
        }       
    }
}

