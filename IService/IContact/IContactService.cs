using Azure.Messaging;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.NewFolder;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;

namespace FOLYFOOD.IService.IContact
{
    public interface IContactService
    {
        public RetunObject<Contact> addContact(ContactDto data);
        public RetunObject<Contact> GetOneContact(int id);
        public RetunObject<IQueryable<Contact>> getDataContact();
        public RetunObject<Contact> replyToContact(string email, string MessageContent);
    }
}
