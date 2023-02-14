using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMemberRepository
    {

        void SaveMember(Member p);

        Member GetMemberById(int id);

        void DeleteMember(Member p);

        void UpdateMember(Member p);

        List<Member> GetMembers();
    }
}
