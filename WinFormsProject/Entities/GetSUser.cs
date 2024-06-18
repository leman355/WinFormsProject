using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.Entities
{
    public class GetSUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string RoleName { get; set; }
        public float Balance { get; set; }
        public bool IsDeleted{ get; set; }
    }
}
