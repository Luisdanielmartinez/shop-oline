

namespace shop_oline.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class Item
    {
        public int categoryId { get; set; }
        public int ProducerId { get; set; }
        public string ItemUrl { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
    }
}