using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestIdentity.Models
{
    public class ApplicationUserMusic
    {
        public int ApplicationUserMusicId { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int MusicId { get; set; }
        public virtual Music Music { get; set; }
    }
}
