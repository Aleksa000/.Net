namespace USP.Models;

public class ResponsePaginationModel
{
    public List<ProductModel> Products { get; set; }
    public List<CommentModel> Comments { get; set; }
    public List<WorkModel> Works { get; set; }
    public long TotalCounts { get; set; }
    public int? StartIndex { get; set; }
    public long NumberOfPages { get; set; }
    public bool NextPage { get; set; }
    public bool PreviousPage { get; set; }
}