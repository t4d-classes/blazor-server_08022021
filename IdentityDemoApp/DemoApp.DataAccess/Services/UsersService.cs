using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AutoMapper;


using UserModel = DemoApp.Models.User;

namespace DemoApp.DataAccess.Services
{
  public class UsersService
  {

    private ApplicationDbContext _db;
    private IMapper _mapper;

    public UsersService(ApplicationDbContext db)
    {
      _db = db;

      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<IdentityUser, UserModel>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
          .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
          .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));
      });

      _mapper = config.CreateMapper();
    }

    public Task<List<UserModel>> AllAsync()
    {
      return _db.Users
        .Select(u => _mapper.Map<IdentityUser, UserModel>(u))
        .AsNoTracking()
        .ToListAsync();
    }


  }
}
