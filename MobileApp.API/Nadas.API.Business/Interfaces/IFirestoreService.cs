using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Business.Interfaces
{
    public interface IFirestoreService
    {
        Task<string> GetUserInfo(int id);
    }
}
