using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayit Oldu!");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi!");
        }
    }
}
