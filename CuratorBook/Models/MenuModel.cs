using CuratorBookCore.Data.Tables;
using System.Collections.Generic;

namespace CuratorBook.Models
{
    public class MenuModel
    {
        public IList<Pages> Pages { get; set; } = new List<Pages>();
    }
}
