namespace bookstore.models;

public class BaseModel
{
    public Boolean IsActive { get; set; } = true;
    public int CreatedByID { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public int? UpdatedByID { get; set; }
    public DateTime? UpdatedOn { get; set; }
    
}