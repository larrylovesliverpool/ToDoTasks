using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TryItOut.CommonInterfaces;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class RegisteredUserRepository : IRegisteredUserRepository
    {
        public RegisteredUserRepository()
        {
        }

        public bool authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Create(List<RegisteredUser> entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RegisteredUser entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int identity )
        {
            throw new NotImplementedException();
        }

        public string LastLoggedIn_Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public void LastLoggedIn_Update(int identifier)
        {
            /* ****************************************************************** */
            /* Find user, update last login together and reset number of attempts */
            /* ****************************************************************** */

            try
            {
                var users = Read().ToList();

                if (users.Exists(x => x.Identifier == identifier))
                {
                    var user = users.Single(x => x.Identifier == identifier);
                    user.LastLoggedIn = DateTime.Now.ToShortDateString();
                    user.NumberOfAttemps = 0;
                    Save(users);
                }
            }
            catch
            {
                throw new NotSupportedException();
            }
           
        }

        public string NumberOfAtempts_Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public string NumberOfAtempts_Read(string username)
        {
            throw new NotImplementedException();
        }

        public void NumberOfAtempts_Update(int identifier)
        {
            var users = Read().ToList();
            var user = users.Find(x => x.Identifier == identifier);

            if(user != null)
            {
                user.NumberOfAttemps++;
                Save(users);
            }
        }

        public void NumberOfAtempts_Update(int identifier, int numberOfAttempts)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Read(int identifier)
        {
            RegisteredUser user = new RegisteredUser();
            var users = Read().ToList();

            /* returns null if no matches,
             * therefore a state pattern ? */
            user = users.Find(x => x.Identifier == identifier);

            return user;
        }

        public RegisteredUser Read(string username)
        {
            RegisteredUser user = new RegisteredUser();
            var users = Read().ToList();

            /* returns null if no matches,
             * therefore a state pattern ? */
            user = users.Find(x => x.Username == username);

            return user;
        }

        public IList<RegisteredUser> Read()
        {
            IList<RegisteredUser> users = new List<RegisteredUser>();

            try
            {               
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/RegisteredUsers.xml");

                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(users.GetType());
                System.IO.StreamReader file = new System.IO.StreamReader(filePath);

                users = (List<RegisteredUser>)reader.Deserialize(file);

                file.Close();
            }
            catch ( Exception ex )
            {
                throw new Exception();
            }

            return users;
        }

        public bool Save(RegisteredUser entity) {

            return false;
        }

        public bool Save(List<RegisteredUser> entity)
        {
            try
            {
                var writer = new System.Xml.Serialization.XmlSerializer(entity.GetType());

                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/RegisteredUsers.xml");

                var wfile = new System.IO.StreamWriter(filePath);
                writer.Serialize(wfile, entity);
                wfile.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
