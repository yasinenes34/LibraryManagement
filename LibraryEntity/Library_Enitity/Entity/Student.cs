using LibraryEntity.Library_Enitity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntity.Library_Enitity.Entity
{
   public class Student:BaseEntity1
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Department { get; set; }
        [DefaultValue("0")]
        public int Scot { get; set; }
        public virtual ICollection<BookOperation> BookOperations { get; set; }

    }
}
