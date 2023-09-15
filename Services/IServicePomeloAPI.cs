using System;
using PomeloFintech.Models.Users;
using PomeloFintech.Models.Cards;

namespace PomeloFintech.Services
{
    public interface IServicePomeloAPI
    {
        Task<UserData> CreateUser(CreateUserDTO user);
        Task<List<UserData>> GetUsers();
        Task<UserData> GetUser(string id);
        Task<CreatedCard> CreateCard(Card newCard);
        Task<List<CreatedCard>> GetCards();
    }
}
