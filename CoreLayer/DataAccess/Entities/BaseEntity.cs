namespace CoreLayer.DataAccess.Entities
{
    public interface BaseEntity
    {
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
