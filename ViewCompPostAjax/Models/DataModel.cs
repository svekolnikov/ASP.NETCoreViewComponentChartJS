using System.Collections.Generic;

namespace ViewCompPostAjax.Models
{
    public class DataModel
    {
        public int DataId { get; set; }
        public string Name { get; set; }
        public List<RecordModel> Records { get; set; }
    }
}
