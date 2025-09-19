namespace OW.ApiSimulator.Models.OW
{
    public class HitJackpotCall : OWCall
    {
        public long GameRoundId { get; set; }

        public int GameTypeId { get; set; }

        public decimal WinningAmount { get; set; }
    }
}