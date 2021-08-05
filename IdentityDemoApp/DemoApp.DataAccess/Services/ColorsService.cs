using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AutoMapper;

using ColorModel = DemoApp.Models.Color;
using ColorDataModel = DemoApp.DataAccess.Models.Color;

using UserModel = DemoApp.Models.User;
using System;

namespace DemoApp.DataAccess.Services
{
  public class ColorsService
  {

    private ApplicationDbContext _db;
    private IMapper _mapper;

    public ColorsService(ApplicationDbContext db)
    {
      _db = db;

      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<ColorDataModel, ColorModel>();
        cfg.CreateMap<IdentityUser, UserModel>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
          .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
          .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));
        cfg.CreateMap<ColorModel, ColorDataModel>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
          .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
          .ForMember(dest => dest.User, opt => opt.Ignore())
          .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
          .ForMember(dest => dest.Hexcode, opt => opt.MapFrom(src => src.Hexcode));
      });

      _mapper = config.CreateMapper();
    }

    public Task<List<ColorModel>> AllAsync(string userId = null)
    {
      IQueryable<ColorDataModel> colors = _db.Colors;

      if (userId != null)
      {
        colors = colors.Where(c => c.UserId == userId);
      }

      return colors
        .Include(c => c.User)
        .Select(c => _mapper.Map<ColorDataModel, ColorModel>(c))
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<ColorModel> AppendAsync(ColorModel color)
    {
      var colorDataModel = _mapper.Map<ColorModel, ColorDataModel>(color);

      await _db.AddAsync(colorDataModel);
      await _db.SaveChangesAsync();
      _db.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(colorDataModel);
    }

    public async Task<ColorModel> ReplaceAsync(ColorModel color)
    {
      var oldColorDataModel = await _db.Colors
         .AsNoTracking()
         .FirstOrDefaultAsync(c => c.Id == color.Id);

      if (oldColorDataModel is null)
      {
        throw new NullReferenceException("Unable to find car.");
      }

      var colorDataModel = _mapper.Map<ColorModel, ColorDataModel>(color);

      _db.Update(colorDataModel);
      await _db.SaveChangesAsync();
      _db.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(oldColorDataModel);
    }

    public async Task<ColorModel> RemoveAsync(long colorId)
    {
      var colorDataModel = await _db.Colors.FindAsync(colorId);

      _db.Colors.Remove(colorDataModel);
      await _db.SaveChangesAsync();
      _db.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(colorDataModel);
    }

  }
}
