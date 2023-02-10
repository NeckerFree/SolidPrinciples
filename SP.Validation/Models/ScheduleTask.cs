namespace SP.Validation.Models
{
    internal class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }=string.Empty;
       public DateTime ExecutedOn { get; set; }
    }
}
