using FOLYFOOD.Dto;
using FOLYFOOD.Dto.NewFolder;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Mail;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Hellers.validate;
using FOLYFOOD.IService.IContact;

namespace FOLYFOOD.Services.Contact
{

    public class ContactService : IContactService
    {
        public readonly Context DBContext;

        public ContactService()
        {
            DBContext = new Context();
        }
        public RetunObject<Entitys.Contact> addContact(ContactDto data)
        {
            try
            {
                if (string.IsNullOrEmpty(data.UserName) || string.IsNullOrEmpty(data.Phone) || string.IsNullOrEmpty(data.Subject) || string.IsNullOrEmpty(data.Email))
                {
                    throw new Exception("dữ liệu truyền lên không hợp lệ");
                }
                if(DBContext.Contacts.Any(x=>x.Email == data.Email))
                {
                    throw new Exception("bạn đã gửi một lần trước đó rồi mong bạn thông cảm cho chúng tôi nha");
                }
                if(!ValidateValue.IsValidEmail(data.Email))
                {
                    throw new Exception("email bạn nhập lên không hợp lệ");
                }
                if (!ValidateValue.IsValidPhoneNumber(data.Phone))
                {
                    throw new Exception("email bạn nhập lên không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Entitys.Contact>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404,
                };
            }
            var contactCreate = new Entitys.Contact();
            contactCreate.Address = "";
            contactCreate.Phone = data.Phone;
            contactCreate.Subject = data.Subject;
            contactCreate.Email = data.Email;
            contactCreate.UserName = data.UserName;
            contactCreate.answered = false;
            DBContext.Contacts.Add(contactCreate);
            DBContext.SaveChanges();
            return new RetunObject<Entitys.Contact>()
            {
                data = contactCreate,
                mess = "đã gửi dữ liệu thành công",
                statusCode = 204,
            };
        }

        public RetunObject<IQueryable<Entitys.Contact>> getDataContact()
        {
            return  new RetunObject<IQueryable<Entitys.Contact>>()
            {
                data = DBContext.Contacts.OrderBy(x=>x.answered).ThenByDescending(x=>x.CreatedAt).AsQueryable(),
                mess = "đã gửi dữ liệu thành công",
                statusCode = 204,
            };
        }

        public RetunObject<Entitys.Contact> GetOneContact(int id)
        {
            var contactCreate = DBContext.Contacts.SingleOrDefault(x => x.ContactId == id);
            try
            {
                if (contactCreate == null)
                {
                    throw new Exception("liên hệ không tồn tại trong danh sách");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Entitys.Contact>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404,
                };
            }
            return new RetunObject<Entitys.Contact>()
            {
                data = contactCreate,
                mess = "đã lấy được liên hệ",
                statusCode = 200,
            };
        }

        public RetunObject<Entitys.Contact> replyToContact(string email, string MessageContent)
        {
            var contactCreate = DBContext.Contacts.SingleOrDefault(x => x.Email == email);
            try
            {
                if (contactCreate == null)
                {
                    throw new Exception("email không tồn tại trong danh sách");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Entitys.Contact>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404,
                };
            }
            contactCreate.answered = true;
           string textRes =  SendMail.send(email, Template2.temlapteHtmlMail(MessageContent), "foly food");
            if(textRes != "Email đã được gửi thành công.")
            {
                return new RetunObject<Entitys.Contact>()
                {
                    data = null,
                    mess = "thông tin liên hệ lại không thành công có thể là sai email",
                    statusCode = 404,
                };
            }
            DBContext.Contacts.Update(contactCreate);
            DBContext.SaveChanges();
            return new RetunObject<Entitys.Contact>()
            {
                data = contactCreate,
                mess = "đã gửi dữ liệu thành công",
                statusCode = 204,
            };
        }
    }
}
