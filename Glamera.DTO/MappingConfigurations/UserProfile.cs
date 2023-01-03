using AutoMapper;
using Glamera.Domin.Models;
using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.DTO.MappingConfigurations
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Item, ItemDTO>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Branch, BranchDTO>().ReverseMap();
            CreateMap<ItemBranch, ItemBranchDTO>().ReverseMap();
            CreateMap<Bill, BillDTO>().ReverseMap();
        }

    }
}
