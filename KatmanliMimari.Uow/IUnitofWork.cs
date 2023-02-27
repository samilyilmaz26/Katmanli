using KatmaniMimari.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public interface IUnitofWork
    {
        IPersonelRep _personelRep { get; }
        void Commit();
    }
}
