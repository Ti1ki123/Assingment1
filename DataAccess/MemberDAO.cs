using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        public static List<Member> GetMembers()
        {

            var listMembers = new List<Member>();

            try
            {
                using (var context = new MyDbContext())
                {
                    listMembers = context.Members.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listMembers;
        }

        public static Member FindMemberById(int memId)


        {

            Member p = new Member();

            try

            {
                using (var context = new MyDbContext())
                {

                    p = context.Members.SingleOrDefault(x => x.MemberId == memId);

                }

            }

            catch (Exception e)

            {
                throw new Exception(e.Message);

            }

            return p;
        }

        public static void SaveMember(Member p)
        {

            try
            {
                using (var context = new MyDbContext())
                {
                    context.Members.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateMember(Member p)

        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Entry<Member>(p).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteMember(Member p)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var p1 = context.Members.SingleOrDefault(
                    c => c.MemberId == p.MemberId);
                    context.Members.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
