using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MasterDetail_CRUD_NETCore5MVC.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = "";
        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";
        [Required]
        [Range(25,55,ErrorMessage ="Currently, We have no positions vacant for your age")]
        [DisplayName("Age in Year")]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Qualification { get; set; } = "";
        [Required]
        [Range(1,25,ErrorMessage ="Currently, We have no Positions Vacant for Your Experience")]
        [DisplayName("Total Experience in Year")]
        public int TotalExperience { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();

        public string PhotoUrl { get; set; }
        [Required(ErrorMessage ="Please choose the Profile photo")]
        [Display(Name ="Profile Photo")]
        [NotMapped]

        public IFormFile ProfilePhoto { get; set; }
    }
}
