using System;
using System.Collections.Generic;
using System.Linq;
using ViewCompPostAjax.Models;

namespace ViewCompPostAjax.Data
{
    public class Repository : IRepository
    {
        private readonly List<DataModel> _fakeContext;
        public Repository()
        {
            _fakeContext = new List<DataModel>();

            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                DataModel dataModel = new DataModel { DataId = i + 1, Name = $"Name{i + 1}" };
                dataModel.Records = new List<RecordModel>();
                for (int r = 1; r < 31; r++)
                {
                    dataModel.Records.Add(new RecordModel
                    {
                        ValueScatter = rnd.Next(1, 100),
                        ValueBar = rnd.Next(1, 100),
                        ValueLine = rnd.Next(1, 100),
                        DataId = dataModel.DataId,
                        DateCreated = new DateTime(2021, 4, r)
                    });
                }
                _fakeContext.Add(dataModel);
            }
        }

        public IQueryable<DataModel> Data => _fakeContext.AsQueryable();
    }
}
