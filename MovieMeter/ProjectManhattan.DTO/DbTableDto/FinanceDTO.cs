namespace ProjectManhattan.DTO.DbTableDTO
{
    
    public class FinanceDTO
    {
        public int FinanceId { get; set; }
        public int MovieId { get; set; }
        public double? MovieProductionCost { get; set; }
        public int? MovieProductionDuration { get; set; }
    
    }
}
