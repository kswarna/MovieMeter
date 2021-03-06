namespace ProjectManhattan.DTO.DbTableDTO
{
    public class UserPreferenceDTO
    {
        public int UserPreferenceId { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}