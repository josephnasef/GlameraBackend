using AutoMapper;
using Glamera.Domin.Models;
using Glamera.DTO.DTOs;
using Glamera.Repository.Abstraction;
using Glamera.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBranchRepo _Repo;
        private readonly IMapper _mapper;
        public CategoryService(IBranchRepo BranchRepo, IMapper mapper)
        {
            _Repo = BranchRepo;
            _mapper = mapper;
        }

        public Task<bool> Create(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> ListForUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> Update(int Id, CategoryDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
