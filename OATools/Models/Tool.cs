namespace OATools.Models
{
    public class Tool
    {
        public int Id { get; set; }
        public Program Program { get; set; }
        public byte ProgramId { get; set; }
        public string ToolText { get; set; }
    }
}