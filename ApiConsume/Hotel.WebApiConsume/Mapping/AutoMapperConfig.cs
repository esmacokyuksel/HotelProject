using AutoMapper;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer;

namespace Hotel.WebApiConsume.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto>();   
            
            CreateMap<UpdateRoomDto, Room>().ReverseMap();   
        }
    }
}
