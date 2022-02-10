using LibraryEntity.Library_Enitity.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntity.Library_Enitity.Entity
{
   public class Book:BaseEntity1
    {
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public DateTime Release_Date  { get; set; }
        public int Copies { get; set; }
        public int Page_Count { get; set; }

        public string Category { get; set; }
        public virtual ICollection<BookOperation> BookOperations { get; set; }
    }
}
