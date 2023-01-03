using AutoMapper;
using Glamera.Domin.Models;
using Glamera.DTO.DTOs;
using Glamera.Repository.Abstraction;
using Glamera.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Services
{
    public class ItemBranchService : IitemBranchService
    {
        private readonly IitemBranchRepo _Repo;
        private readonly IMapper _mapper;
        public ItemBranchService(IitemBranchRepo BranchRepo, IMapper mapper)
        {
            _Repo = BranchRepo;
            _mapper = mapper;
        }

        public Task<bool> Create(ItemBranchDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<ItemBranchDTO> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<GroubedList> List()
        {
            var list = _Repo.GetAllEgarLoading();
            IEnumerable<IGrouping<string, ItemBranch>> GroubedByList = list.AsEnumerable().GroupBy(x => x.item.category.Name);
            List<GroubedList> dd = GroubedByList.Select(s => new GroubedList { Key = s.Key, value = s.GroupBy(q => q.branch.Name) }).ToList();
            //var mappedUser = _mapper.Map<List<ItemBranchDTO>>(dd);
            return dd;
        }

        public Task<List<ItemBranchDTO>> ListForUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<ItemBranchDTO> Update(int Id, ItemBranchDTO entity)
        {
            throw new NotImplementedException();
        }


    }
  public  class GroubedList
    {
        public string Key { get; set; }
        public IEnumerable<IGrouping<string,ItemBranch>> value { get; set; }
    }
}
