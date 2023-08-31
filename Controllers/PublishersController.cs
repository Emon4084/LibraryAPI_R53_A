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

        [HttpPut]
        public async Task<IActionResult> Edit(PublisherDto publisherD)
        {
            var updated = _mapper.Map<Publisher>(publisherD);

            await _publisher.Put(updated);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PublisherDto>> Delete(int id)
        {
            var publisherD = await _publisher.Get(id);
            if (publisherD == null)
            {
                return NotFound();
            }
            _publisher.Delete(publisherD);
            return Ok(publisherD);
        }

    }
}
