using System;

namespace LaMaCo.Comments.Api.Data;

public class Comment
{
    public int Id { get; set; }
    public string AuthorName { get; set; } = String.Empty;
    public string Text { get; set; } = String.Empty;
}
