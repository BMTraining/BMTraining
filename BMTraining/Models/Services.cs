using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMTraining.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ServiceNames { get; set; }
    }
}