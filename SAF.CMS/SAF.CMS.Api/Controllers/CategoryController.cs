using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SAF.CMS.Api.Controllers
{
    /// <summary>
    /// 商品分类
    /// </summary>
    [Route("api/cms/[controller]")]
    [Produces("application/json")]
    public class CategoryController : Controller
    {
        /// <summary>
        /// 获取所有分类
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 根据分类ID获取分类信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("query/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
