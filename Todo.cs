public class Todo
{
    public int Id { get; set; }

    public required String Text { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsComplete { get; set; }
    
}