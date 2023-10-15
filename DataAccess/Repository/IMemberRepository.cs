﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> FindAll();
        Member FindById(string id);
        IEnumerable<Member> FindByName(string name);
        IEnumerable<Member> FindByCountryAndCity(string country, string city);
        void Create(Member member);
        void Update(Member member);
        void Delete(string id);
    }
}
