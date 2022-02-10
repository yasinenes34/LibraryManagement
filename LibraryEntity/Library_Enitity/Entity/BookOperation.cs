using LibraryEntity.Library_Enitity.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntity.Library_Enitity.Entity
{
  public  class BookOperation:BaseEntity1
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime Purchaseof_Books { get; set; }
        public DateTime BookReturn_Date { get; set; }
    }
}
