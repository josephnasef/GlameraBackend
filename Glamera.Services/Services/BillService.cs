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
    public class BillService : IBillService
    {
        private readonly IBillRepo _BillRepo;
        private readonly IMapper _mapper;
        public BillService(IBillRepo BillRepo, IMapper mapper)
        {
            _BillRepo = BillRepo;
            _mapper = mapper;
        }

        public Task<bool> Create(BillDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<BillDTO> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BillDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task<BillDTO> Update(int Id, BillDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
