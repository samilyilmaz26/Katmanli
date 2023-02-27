using KatmaniMimari.Dal;
using KatmaniMimari.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public class UnitofWork : IUnitofWork
    {
        MyContext _db;
        
        public IPersonelRep _personelRep { get; private set; }  
        public void Commit()
        {
            _db.SaveChanges();
        }
        public UnitofWork(MyContext db, IPersonelRep personelRep)
        {
            _db = db;
            _personelRep = personelRep; 
        }
    }
}
