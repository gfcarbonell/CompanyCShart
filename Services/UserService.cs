using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private IUserRepository _IUserRepository;

        public UserService(IUserRepository _IUserRepository)
        {
            this._IUserRepository = _IUserRepository;
        }

        public ICollection<User> Get()
        {
            return this._IUserRepository.Get();
        }

        public User GetById(int Id)
        {
            return this._IUserRepository.GetById(Id);
        }

        public User Save(User t)
        {
            return this._IUserRepository.Save(t);
        }

        public User Update(User t)
        {
            return this._IUserRepository.Update(t);
        }

        public bool Delete(int Id)
        {
            return this._IUserRepository.Delete(Id);
        }

        public bool Exist(int Id)
        {
            return this._IUserRepository.Exist(Id);
        }
    }
}
