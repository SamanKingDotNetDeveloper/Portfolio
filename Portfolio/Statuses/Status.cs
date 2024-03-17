namespace Portfolio.Statuses
{
    public class Status
    {
        public string Massage { get; set; }
        public object Data { get; set; }
    }
    public enum StatusType
    {
        Success,
        NotFound,
        Exists
    }
}
