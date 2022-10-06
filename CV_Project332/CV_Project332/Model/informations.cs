using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project332.Model
{
    public class informations
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }

        [Required]
        public string Nationality { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string gender { get; set; }

        public string Ipath { get; set; }

        [DisplayName("C languege")]
        public Boolean s1{ get; set; }
        [DisplayName("Python")]
        public Boolean s2 { get; set; }
        [DisplayName("Laravel")]
        public Boolean s3 { get; set; }

        [DisplayName("Asp .net")]
        public Boolean s4 { get; set; }

        public int grade { get; set; }
        

      

      

      

        


    }
}
