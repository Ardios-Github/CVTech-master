using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Entities
{
    class Logs
    {
        public int Id { get; set; }
        public int ModifId { get; set; }

        [ForeignKey("ModifId"), Required]
        virtual public Profile Modif { get; set; }

        public int ProfileModifId { get; set; }

        [ForeignKey("ProfileModifId"), Required]
        virtual public Profile ProfileModif { get; set; }

        public DateTime ModifDate { get; set; }
        public string UpdateMsg { get; set; }
    }
}
