using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.IOC
{
    public class BaseEntity
    {
        /// <summary>
        /// Just the Primary Key of the Entity.
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}
