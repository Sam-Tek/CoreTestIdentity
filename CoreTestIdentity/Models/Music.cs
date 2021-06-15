using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestIdentity.Models
{
    public class Music
    {
        public int MusicId { get; set; }
        public string Name { get; set; }

        public virtual List<ApplicationUserMusic> UsersWhoLiked { get; set; }
    }
}
