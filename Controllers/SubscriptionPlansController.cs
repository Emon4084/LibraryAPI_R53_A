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
    public class SubscriptionPlansController : ControllerBase
    {
        private ISubscriptionPlan _SubscriptionPlan;
        private readonly IMapper _mapper;
        public SubscriptionPlansController(ISubscriptionPlan SubscriptionPlan, IMapper map)
        {
            _SubscriptionPlan = SubscriptionPlan;
            _mapper = map;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubscriptionPlans()
        {
            var SubscriptionPlan = await _SubscriptionPlan.GetAll();
            return Ok(SubscriptionPlan);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var SubscriptionPlan = await _SubscriptionPlan.Get(id);
            return Ok(SubscriptionPlan);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SubscriptionPlan model)
        {
            await _SubscriptionPlan.Post(model);
            return Ok(model);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Edit(SubscriptionPlanDto SubscriptionPlanDt)
        {
            var updated = _mapper.Map<SubscriptionPlan>(SubscriptionPlanDt);

            await _SubscriptionPlan.Put(updated);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            await _SubscriptionPlan.Delete(id);
            return Ok(new { message = "Deleted successfully" });

        }

    }
}
