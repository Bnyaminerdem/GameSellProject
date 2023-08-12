using GameSellProject.Abstrack;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        private IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.CheckIfRealPerson(player))
            {               
                Console.WriteLine("Oyuncu Eklendi: " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Geçersiz oyuncu bilgisi.");
            }
        }

        public void Update(Player player)
        {         
            Console.WriteLine("Oyuncu Güncellendi: " + player.FirstName + " " + player.LastName);
        }

        public void Delete(Player player)
        {           
            Console.WriteLine("Oyuncu Silindi: " + player.FirstName + " " + player.LastName);
        }

        public bool CheckIfRealPerson(Player player)
        {           
            return true;
        }
    }
}
