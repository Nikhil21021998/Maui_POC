namespace KudosePOC.Models
{
    public class KudosItem
    {
        public string ReceiverName { get; set; }
        public string GiverName { get; set; }
        public DateOnly Date { get; set; }
        public string ImageURL { get; set; }
    }
}
