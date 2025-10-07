using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture_DDD_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private readonly IMemberService memberService;

        public MemberController(IMemberService memberService)
        {
            this.memberService = memberService;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public ActionResult<IList<Member>> Get()
        {
            return Ok(this.memberService.GetAllMembers());
        }
    }
}
