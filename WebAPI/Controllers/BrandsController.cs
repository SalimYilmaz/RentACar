﻿using Business.Abstract;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //field olarak Brand'i tanımlayalım
        private readonly IBrandService _brandService; //Field

        public BrandsController()

        {
            //Her HTTP Request için yeni bir Controller nesnesi oluşturuyor.
            //IBrandDal brandDal = new InMemoryBrandDal();
            //_brandService = new BrandManager(brandDal);
            //IoC Container yapısını kurunca dependency injection ile olacak.


            _brandService = ServiceRegistration.BrandService;
        }

        //[HttpGet]
        //public ActionResult<string> GetList() /*IActionResult GetList()*/
        //{
        //    return Ok("BrandsController");
        //} 

        //[HttpGet]
        //public string GetList() //Veriyi direk bu şekilde dönebilirim
        //{
        //    return "BrandsController";
        //}


        [HttpGet]
        public ICollection<Brand> GetList()
        {
            IList<Brand> brandList = _brandService.GetList();
            return brandList; //JSON
        }

        //[HttpPost("/add")]  // POST http://localhost:5245///api/brands/add

        [HttpPost]  // POST http://localhost:5245/api/brands
        public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
        {
            AddBrandResponse response = _brandService.Add(request);
            //return response;
            return CreatedAtAction(nameof(GetList), response);

        }


    }
}