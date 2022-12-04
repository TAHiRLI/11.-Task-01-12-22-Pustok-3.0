using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title1 { get; set; }
        [MaxLength(30)]
        public string Title2 { get; set; }
        [MaxLength(150)]
        public string Desc { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(30)]
        public string BtnText { get; set; }
        [MaxLength(100)]
        public string RedirectedUrl { get; set; }
        public int? Order { get; set; }  
    }
}
