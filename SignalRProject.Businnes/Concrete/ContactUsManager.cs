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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs entity)
        {
            _contactUsDal.Add(entity);
        }

        public void TDelete(ContactUs entity)
        {
            _contactUsDal.Delete(entity);
        }

        public ContactUs TGetById(int id)
        {
           return _contactUsDal.GetById(id);
        }

        public List<ContactUs> TGetListAll()
        {
            return _contactUsDal.GetListAll();
        }

        public void TUpdate(ContactUs entity)
        {
            _contactUsDal.Update(entity);
        }
    }
}
