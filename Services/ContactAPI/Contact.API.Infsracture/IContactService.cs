using Contact.API.Models;

namespace Contact.API.Infsracture
{
    public interface IContactService
    {
        public ContactDto GetContactById(int id);
    }
}
