namespace SignalRProject.Web.Dto.ContactUsDto
{
    public class GetContactUsDto
    {
        public int ContactUsId { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? FooterDesricpiton { get; set; }
    }
}