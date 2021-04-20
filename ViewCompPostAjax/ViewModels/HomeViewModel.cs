using System;
using System.Collections.Generic;
using ViewCompPostAjax.Models;

namespace ViewCompPostAjax.ViewModels
{
    public class HomeViewModel
    {
        public int? DataId { get; set; }
        public IEnumerable<RecordModel> SelectedRecords { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
