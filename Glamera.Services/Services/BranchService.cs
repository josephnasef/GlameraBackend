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
    public class BranchService : IBranchService
    {
        private readonly IBranchRepo _BranchRepo;
        private readonly IMapper _mapper;
        public BranchService(IBranchRepo BranchRepo, IMapper mapper)
        {
            _BranchRepo = BranchRepo;
            _mapper = mapper;
        }

        public Task<bool> Create(BranchDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<BranchDTO> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<BranchDTO> List()
        {
            throw new NotImplementedException();
        }

        public Task<BranchDTO> Update(int Id, BranchDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
