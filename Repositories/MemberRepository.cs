using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberRepository : IMemberRepository

    {

        public void DeleteMember(Member p) => MemberDAO.DeleteMember(p);
        public void SaveMember(Member p) => MemberDAO.SaveMember(p);
        public void UpdateMember(Member p) => MemberDAO.UpdateMember(p);
        public List<Member> GetMembers() => MemberDAO.GetMembers();

        public Member GetMemberById(int id) => MemberDAO.FindMemberById(id);
    }
}
