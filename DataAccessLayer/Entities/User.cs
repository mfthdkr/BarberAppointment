using CoreLayer.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Entities;

public class User : IdentityUser, BaseEntity
{
    public User()
    {
        Id = Guid.NewGuid().ToString();
        Roles = new HashSet<IdentityUserRole<string>>();
        Appointments = new HashSet<Appointment>();
        Barbers = new HashSet<Barber>();
    }

    public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; }

    public virtual ICollection<Barber> Barbers { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }
}

