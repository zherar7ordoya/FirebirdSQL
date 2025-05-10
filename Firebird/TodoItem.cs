namespace Superserver;

public class TodoItem
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public bool EstaHecho { get; set; }
}