namespace Bridge
{
    public interface IResource
    {
        string Snippet { get; }
        string Title { get; }
        string Image { get; }
        string Url { get; }
    }
}