using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestIdentity.Models
{
    // Il faudra changer toutes les référence à IdentityUser vers ApplicationUser
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }

        public virtual List<ApplicationUserMusic> FavoriteSongs { get; set; }
    }
}
