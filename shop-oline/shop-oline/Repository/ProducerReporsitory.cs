

namespace shop_oline.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface ProducerReporsitory
    {
        IEnumerable<Producer> GetAll();
        void Insert(Producer producer);
        Producer GetById(int ProducerId);
    }
}