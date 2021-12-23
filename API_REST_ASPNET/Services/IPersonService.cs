using API_REST_ASPNET.Model;
using System.Collections.Generic;

namespace API_REST_ASPNET.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person>FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
