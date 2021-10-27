using AutoMapper;
using dotnet_RPG.DTOS.Character;
using dotnet_RPG.Models;

namespace dotnet_RPG
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();

        }
        
    }
}