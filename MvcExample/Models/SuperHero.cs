using System.Collections.Generic;

namespace MvcExample.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> Powers { get; set; }
    }
}
