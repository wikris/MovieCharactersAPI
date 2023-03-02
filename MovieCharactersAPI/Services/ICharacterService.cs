﻿using MovieCharactersAPI.Models;

namespace MovieCharactersAPI.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<Character> AddCharacter(Character movie);
        Task DeleteCharacter(int id);
        Task<Character> UpdateCharacter(Character movie);
    }
}