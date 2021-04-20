using System;
using System.ComponentModel.DataAnnotations;

namespace ViewCompPostAjax.Models
{
    public class RecordModel
    {
        public int Id { get; set; }
        public int ValueScatter { get; set; }
        public int ValueBar { get; set; }
        public int ValueLine { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        public int DataId { get; set; }
    }
}
