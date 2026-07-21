namespace Console_App_3_LINQ.Models;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<string> Subjects { get; set; } = new();

    public int Marks { get; set; }
}