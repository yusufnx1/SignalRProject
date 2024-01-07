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
    public class EfNotificationRepository : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationRepository(SignalRContext context) : base(context)
        {
        }

        public int NotificatiobCountStatusFalse()
        {
            using var context = new SignalRContext();
            return context.Notifications.Where(x=>x.Status == false).Count();
        }
    }
}
