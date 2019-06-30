using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Mini.Bll;
using Mini.Interfaces;
using Mini.Interfaces.Interfaces;
using Mini.Interfaces.Models;
using miniBG.Models;

namespace miniBG.Controllers
{
    public class BaseDataController : FileUploadController
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
            return View();
        }

        public ActionResult Get()
        {
            var list = new List<BaseDataVM>();
            try
            {
                var baseData = baseDataService.GetAlls();
                list = baseData.Select(item => new BaseDataVM
                {
                    ID = item.ID,
                    CreateTime = item.CreateTime,
                    IsDefault = Convert.ToBoolean(item.IsDefault),
                    Key = item.Key,
                    Type = item.Type,
                    UpdateTime = item.UpdateTime,
                    Value = item.Value

                }).ToList();
            }
            catch (DbException ex)
            {
                TempData["error"] = ex.Message;
            }
            var result = new { rows = list };

            return Json(result);
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
                        ID = Guid.NewGuid(),
                        CreateTime = DateTime.Now,
                        Icon = baseData.Icon,
                        IsDefault = Convert.ToString(baseData.IsDefault),
                        Key = baseData.Key,
                        Type = baseData.Type,
                        UpdateTime = DateTime.Now,
                        Value = baseData.Value
                    });

                    return RedirectToAction("Index", "BaseData");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }

            return View(baseData);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            try
            {
                var model = baseDataService.GetByID(id);

                return View(new BaseDataVM
                {
                    ID = model.ID,
                    CreateTime = DateTime.Now,
                    Icon = model.Icon,
                    IsDefault = Convert.ToBoolean(model.IsDefault),
                    Key = model.Key,
                    Type = model.Type,
                    UpdateTime = DateTime.Now,
                    Value = model.Value,
                    IconData = ImgToBase64String(model.Icon)
                });
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }

            return RedirectToAction("Index", "BaseData");
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
                        IsDefault = Convert.ToString(baseData.IsDefault),
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
                TempData["error"] = ex.Message;
            }

            return View(baseData);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
               await baseDataService.RemoveAsync(Guid.Parse(id));
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }

            return RedirectToAction("Index", "BaseData");
        }
    }
}