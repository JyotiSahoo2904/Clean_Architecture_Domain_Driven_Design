using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    //Implement Bussiness Rule / USE CASES
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public List<Member> GetAllMembers()
        {
            throw new NotImplementedException();
        }

        List<Member> IMemberService.GetAllMembers()
        {
            return this.memberRepository.GetAllMembers();
        }
    }
}
