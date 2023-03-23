using CoreLayer.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Entities
{
    public class Role : IdentityRole, BaseEntity
    {
        //public Role() : this(null)
        //{

        //}

        public Role(string? name = null)
            : base(name)
        {
            Id = Guid.NewGuid().ToString();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
