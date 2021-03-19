using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ServiceOrder
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        public Service Service { get; set; }
    }
}
