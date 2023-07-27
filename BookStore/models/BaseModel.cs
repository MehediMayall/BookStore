namespace bookstore.models;

public class BaseModel
{

    public int Id { get; set; }
    public Boolean IsActive { get; set; }

    public int CreatedByID { get; set; }
    public DateTime CreatedOn { get; set; } 
    public int UpdatedByID { get; set; }
    public DateTime UpdatedOn { get; set; }
    
}