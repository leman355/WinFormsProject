using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.Entities
{
    public class AddToCart
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public float Count { get; set; }
    }
}
