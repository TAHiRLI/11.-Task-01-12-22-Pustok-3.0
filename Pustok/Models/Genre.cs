using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Pustok.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSelected { get; set; }
        public List<Book> Books { get; set; }
    }
}
