

namespace shop_oline.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface ItemReporsitory
    {
        IEnumerable<Item> GetAll();
        Item GetById(int Id);
        void Insert(Item item);
        void Update(Item item);
        void Delete(int itemId);

        void Save();
    }
}