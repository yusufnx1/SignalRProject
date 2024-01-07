using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Data.Abstrack
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        int NotificatiobCountStatusFalse();
    }
}
