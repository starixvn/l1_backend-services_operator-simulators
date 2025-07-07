namespace OW.ApiSimulator.Models.OW
{
    public class AwardCall : OWCall
    {
        public string PromotionId { get; set; }

        public int GameTypeId { get; set; }

        public decimal Amount { get; set; }
    }
}
