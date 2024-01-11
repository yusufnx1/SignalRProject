using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Data.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public EfMessageRepository(SignalRContext context) : base(context)
        {
        }
    }
}
