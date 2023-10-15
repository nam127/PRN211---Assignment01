using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void Create(Member member) => MemberDAO.Instance.Create(member);

        public void Delete(string id) => MemberDAO.Instance.Delete(id);

        public IEnumerable<Member> FindAll() => MemberDAO.Instance.FindAll();

        public IEnumerable<Member> FindByCountryAndCity(string country, string city) => MemberDAO.Instance.FindByCountryAndCity(country, city);

        public Member FindById(string id) => MemberDAO.Instance.FindById(id);

        public IEnumerable<Member> FindByName(string name) => MemberDAO.Instance.FindByName(name);

        public void Update(Member member) => MemberDAO.Instance.Update(member);
    }
}
