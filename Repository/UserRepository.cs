using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository:IUserRepository
    {

        public ICollection<User> Get()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Company"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SP_USERS", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    var reader = command.ExecuteReader();

                    List<User> users = new List<User>();
                    while (reader.Read())
                    {
                        User item = new User()
                        {
                            UserId = int.Parse(reader["UserId"].ToString()),
                            Username = reader["Username"].ToString(),
                        };

                        users.Add(item);
                    }
                    return users;
                };    
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public User Save(User t)
        {
            throw new NotImplementedException();
        }

        public User Update(User t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
