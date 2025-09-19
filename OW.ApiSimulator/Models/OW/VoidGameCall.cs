namespace OW.ApiSimulator.Models.OW
{
    public class VoidGameCall : OWCall
    {
        public long GameRoundId { get; set; }

        public int GameTypeId { get; set; }

        public string Reason { get; set; }
    }
}