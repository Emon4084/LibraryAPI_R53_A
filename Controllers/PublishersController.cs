using AutoMapper;
using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Repositories;
using LibraryAPI_R53_A.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI_R53_A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private IPublisher _publisher;
        private readonly IMapper _mapper;
        public PublishersController(IPublisher publisher, IMapper map)
        {
            _publisher = publisher;
            _mapper = map;
        }

        [HttpGet]
        public async Task<IActionResult> GetPublishers()
        {
            var publisher = await _publisher.GetAll();
            return Ok(publisher);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var publisher = await _publisher.Get(id);
            return Ok(publisher);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Publisher model)
        {
            await _publisher.Post(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(PublisherDto publisherDt)
        {
            var updated = _mapper.Map<Publisher>(publisherDt);

            await _publisher.Put(updated);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            
            await _publisher.Delete(id);
            return Ok(new { message = "Deleted successfully" });
        }

    }
}
