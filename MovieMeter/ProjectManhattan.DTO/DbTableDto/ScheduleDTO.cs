namespace ProjectManhattan.DTO.DbTableDTO
{
    public class ScheduleDTO
    {
        public int ScheduleId { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }
        public System.DateTime ScheduleTime { get; set; }
        public string ScheduleScreenName { get; set; }
    }
}
