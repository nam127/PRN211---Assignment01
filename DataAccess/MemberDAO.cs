using BusinessObject;
using DataAccess.Repository;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member
            {
                Id="ME01",
                Name="Nam Bùi",
                Email="buithanhnam9109@gmail.com",
                Password="12345",
                City="Vung Tau",
                Country="Vietnam"
            },
            new Member
            {
                Id="ME02",
                Name="Bùi Thanh Nam",
                Email="buithanhnam032@gmail.com",
                Password="12345",
                City="Quang Ngai",
                Country="Vietnam"
            }
        };
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        public MemberDAO()
        {
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Member> FindAll()
        {
            List<Member> list = MemberList.OrderByDescending(x => x.Name).ToList();
            return list;
        }
        public Member FindById(string id)
        {
            Member member = MemberList.SingleOrDefault(x => x.Id == id);
            return member;
        }

        private bool isEmailUnique(string email)
        {
            return !MemberList.Any(x => x.Email == email);
        }

        private bool isEmailValid(string email)
        {
            EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();
            return emailAddressAttribute.IsValid(email);
        }

        private bool isIdEmpty(string id)
        {
            return string.IsNullOrEmpty(id);
        }

        private bool isCountryEmpty(string country)
        {
            return string.IsNullOrEmpty(country);
        }

        private bool isCityEmpty(string city)
        {
            return string.IsNullOrEmpty(city);
        }



        public IEnumerable<Member> FindByName(string name)
        {
            return MemberList.FindAll(m =>m.Name.Equals(name));
        }

        public IEnumerable<Member> FindByCountryAndCity(string country, string city)
        {
            return MemberList.FindAll(m => m.Country.Equals(country) && m.City.Equals(city));
        }

        public void Create(Member member)
        {
            Member m = FindById(member.Id);
            if(m != null)
            {
                throw new Exception("Id already exist");
            }
            else
            {
                if(!isEmailUnique(member.Email) || !isEmailValid(member.Email))
                {
                    throw new Exception("Invalid Email");
                }
                if(isCountryEmpty(member.Country))
                {
                    throw new Exception("Country cannot be empty");
                }
                if(isCityEmpty(member.City))
                {
                    throw new Exception("City cannot be empty");
                }
                if(isIdEmpty(member.Id))
                {
                    throw new Exception("Id cannot be empty");
                }
                MemberList.Add(member);
            }
            
        }

        public void Update(Member member)
        {
            Member m = FindById(member.Id);
            if(m != null)
            {
                var index = MemberList.IndexOf(m);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member not existed");
            }
        }
        public void Delete(string id)
        {
            Member m = FindById(id);
            if(m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("There's no Member with this Id in the list");
            }
        }

    }
}