using KatmaniMimari.Core;
using KatmaniMimari.Dal;
using KatmaniMimari.Entity;
using KatmaniMimari.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmaniMimari.Repos.Concretes
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep
    {
        public PersonelRep(MyContext db) : base(db)
        {
            // Ek metotlar
        }
    }
}
