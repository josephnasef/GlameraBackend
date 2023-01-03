using AutoMapper;
using Glamera.DTO.DTOs;
using Glamera.Repository.Abstraction;
using Glamera.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Services
{
    public class ItemService : IitemService
    {
        private readonly IitemRepo _Repo;
        private readonly IMapper _mapper;
        public ItemService(IitemRepo BranchRepo, IMapper mapper)
        {
            _Repo = BranchRepo;
            _mapper = mapper;
        }

        public Task<bool> Create(ItemDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<ItemDTO> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemDTO>> ListForUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<ItemDTO> Update(int Id, ItemDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
