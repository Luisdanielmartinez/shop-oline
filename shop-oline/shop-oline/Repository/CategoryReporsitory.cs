

namespace shop_oline.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Models;
    public interface CategoryReporsitory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int Id);
        void Insert(Category category);
        void Save();
    }
}