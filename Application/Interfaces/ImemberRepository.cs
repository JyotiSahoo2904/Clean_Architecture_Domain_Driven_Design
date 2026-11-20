using Domain.Entities;

namespace Application.Interfaces
{
    public interface IMemberRepository
    {
        List<Member> GetAllMembers();
    }
}
