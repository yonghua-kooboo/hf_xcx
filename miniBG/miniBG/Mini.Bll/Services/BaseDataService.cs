using Mini.Data;
using Mini.Interfaces;
using Mini.Interfaces.Interfaces;
using Mini.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini.Bll
{
    public class BaseDataService : IBaseDataService
    {
        private readonly IDataProvider<BaseData> dataProvider;

        public BaseDataService(IDataProvider<BaseData> dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public async Task AddAsync(BaseDataDto baseData)
        {
            await dataProvider.AddAsync(new BaseData
            {
                ID = baseData.ID,
                CreateTime = baseData.CreateTime,
                Icon = baseData.Icon,
                IsDefault = baseData.IsDefault,
                Key = baseData.Key,
                Type = baseData.Type,
                UpdateTime = baseData.UpdateTime,
                Value = baseData.Value

            });
        }

        public async Task RemoveAsync(Guid id)
        {
            var model = dataProvider.GetByID(id);
            if (model == null)
            {
                throw new Exception("Item not exists!");
            }

            await dataProvider.RemoveAsync(model);
        }

        public async Task UpdateAsync(BaseDataDto baseData)
        {
            var model = dataProvider.GetByID(baseData.ID);
            if (model == null)
            {
                throw new Exception("Item not exists!");
            }

            model.Icon = baseData.Icon;
            model.IsDefault = baseData.IsDefault;
            model.Key = baseData.Key;
            model.Type = baseData.Type;
            model.UpdateTime = DateTime.Now;
            model.Value = baseData.Value;

            await dataProvider.UpdateAsync(model);
        }

        public List<BaseDataDto> GetAlls()
        {
            var query = dataProvider.GetAlls().ToList();

            return query
                .Select(item => new BaseDataDto
                {
                    ID = item.ID,
                    CreateTime = item.CreateTime,
                    Icon = item.Icon,
                    IsDefault = item.IsDefault,
                    Key = item.Key,
                    Type = item.Type,
                    UpdateTime = item.UpdateTime,
                    Value = item.Value
                }).ToList();
        }

        public BaseDataDto GetByID(Guid id)
        {
            var model = dataProvider.GetByID(id);
            if (model == null)
            {
                throw new Exception("Item not exists!");
            }

            return new BaseDataDto
            {
                ID = model.ID,
                CreateTime = model.CreateTime,
                Icon = model.Icon,
                IsDefault = model.IsDefault,
                Key = model.Key,
                Type = model.Type,
                UpdateTime = model.UpdateTime,
                Value = model.Value
            };
        }
    }
}
