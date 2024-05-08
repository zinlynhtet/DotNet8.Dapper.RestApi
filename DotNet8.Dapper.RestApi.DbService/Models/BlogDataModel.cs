namespace DotNet8.Dapper.RestApi.DbService.Models;

[Table("Tbl_Blog")]
public class BlogDataModel
{
    [Key] public int BlogId { get; set; }
    public string? BlogTitle { get; set; }
    public string? BlogAuthor { get; set; }
    public string? BlogContent { get; set; }
}