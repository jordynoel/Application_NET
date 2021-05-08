using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET_RazorPages.Models
{
    public class ResearchModel
    {
        [Display(Name ="Title of the research")]
        [Required(ErrorMessage = "The title is required"),MinLength(12,ErrorMessage ="The title should be atleast 12 characters")]
        public string Title { get; set; }
        [Display(Name ="Author of the research"),MinLength(5,ErrorMessage ="The authors name should be atleast 5 characters")]
        [Required(ErrorMessage ="Author is required"), DataType(DataType.Text)]
        public string Author { get; set; }
        [Display(Name = "Number of pages")]
        [Required(ErrorMessage = "The number of pages is required"), Range(10, 100, ErrorMessage = "A paper should be between 10-100 pages")]
        public int Pages { get; set; }
        [Display(Name = "Link to the research")]
        [Required(ErrorMessage ="An URL is required")]
        public string Url { get; set; }
    }
}
