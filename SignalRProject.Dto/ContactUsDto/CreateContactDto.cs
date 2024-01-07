using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Dto.ContactUsDto
{
    public class CreateContactDto
    {
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? FooterDesricpiton { get; set; }
        public string? OpenDays { get; set; }
        public string? OpenDaysDescription { get; set; }
        public string? OpenHours { get; set; }
    }
}
