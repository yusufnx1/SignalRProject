using SignalRProject.Businnes.Abstrack;
using SignalRProject.Data.Abstrack;
using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Businnes.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void TAdd(OrderDetails entity)
        {
            _orderDetailDal.Add(entity);
        }

        public void TDelete(OrderDetails entity)
        {
            _orderDetailDal.Delete(entity);
        }

        public OrderDetails TGetById(int id)
        {
            return _orderDetailDal.GetById(id);
        }

        public List<OrderDetails> TGetListAll()
        {
           return _orderDetailDal.GetListAll();
        }

        public void TUpdate(OrderDetails entity)
        {
            _orderDetailDal.Update(entity); 
        }
    }
}
