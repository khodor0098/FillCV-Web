using System.ComponentModel.DataAnnotations;

namespace CV_Project332.Model
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TwoC { get; set; }
        [Required]
        public string threeC { get; set; }

    }
}
