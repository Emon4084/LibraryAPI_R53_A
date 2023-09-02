using AutoMapper;
using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using LibraryAPI_R53_A.Core.Repositories;
using LibraryAPI_R53_A.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI_R53_A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategory _category;
        private readonly IMapper _mapper;
        public CategoriesController(ICategory category, IMapper map)
        {
            _category = category;
            _mapper = map;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategorys()
        {
            var category = await _category.GetAll();
            return Ok(category);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _category.Get(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Category model)
        {
            await _category.Post(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(CategoryDto categoryDt)
        {
            var updated = _mapper.Map<Category>(categoryDt);

            await _category.Put(updated);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            await _category.Delete(id);
            return Ok(new { message = "Deleted successfully" });
        }
    }
}

