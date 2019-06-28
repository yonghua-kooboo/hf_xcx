using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Mini.Bll;
using Mini.Interfaces;
using Mini.Interfaces.Models;
using miniBG.Models;

namespace miniBG.Controllers
{
    public class BaseDataController : BaseController
    {
        private readonly IBaseDataService baseDataService;

        public BaseDataController(
            IBaseDataService baseDataService,
            IHostingEnvironment hostingEnvironment
            ) : base(hostingEnvironment)
        {
            this.baseDataService = baseDataService;
        }

        public IActionResult Index()
        {
            var list = new List<BaseDataVM>();
            try
            {
                var baseData = baseDataService.GetAlls();
                list = baseData.Select(item => new BaseDataVM
                {
                    ID = item.ID,
                    CreateTime = item.CreateTime,
                    IsDefault = item.IsDefault,
                    Key = item.Key,
                    Type = item.Type,
                    UpdateTime = item.UpdateTime,
                    Value = item.Value

                }).ToList();
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
            }

            return View(list);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new BaseDataVM());
        }

        [HttpPost]
        public async Task<IActionResult> Add(BaseDataVM baseData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Request.Form.Files != null && Request.Form.Files.Count > 0)
                    {
                        baseData.Icon = await Upload(Request.Form.Files[0]);
                    }

                    await baseDataService.AddAsync(new BaseDataDto
                    {
                        ID = baseData.ID,
                        CreateTime = DateTime.Now,
                        Icon = baseData.Icon,
                        IsDefault = baseData.IsDefault,
                        Key = baseData.Key,
                        Type = baseData.Type,
                        UpdateTime = DateTime.Now,
                        Value = baseData.Value
                    });

                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
            }

            return View(baseData);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            try
            {
                var model = baseDataService.GetByID(id);

                return View(model);
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
            }

            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BaseDataVM baseData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Request.Form.Files != null && Request.Form.Files.Count > 0)
                    {
                        baseData.Icon = await Upload(Request.Form.Files[0]);
                    }

                    await baseDataService.UpdateAsync(new BaseDataDto
                    {
                        ID = baseData.ID,
                        CreateTime = DateTime.Now,
                        Icon = baseData.Icon,
                        IsDefault = baseData.IsDefault,
                        Key = baseData.Key,
                        Type = baseData.Type,
                        UpdateTime = DateTime.Now,
                        Value = baseData.Value
                    });

                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
            }

            return View(baseData);
        }
    }
}