using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Helium.Tools
{
    public abstract class EntityBaseClass<TKey>
    {
        protected EntityBaseClass()
        {
            AddDate = DateTime.Now;
        }

        [Key]
        public TKey ID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AddDate { get; set; }
    }
}
