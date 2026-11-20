using Domain.Entities;

namespace Application.Services
{
    //This interface is use for Bussiness Rule / USE CASE
    public interface IMemberService
    {
        List<Member> GetAllMembers();
    }
}
