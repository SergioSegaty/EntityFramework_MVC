using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}