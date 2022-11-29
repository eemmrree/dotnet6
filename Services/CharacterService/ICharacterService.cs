using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet6.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
    }
}