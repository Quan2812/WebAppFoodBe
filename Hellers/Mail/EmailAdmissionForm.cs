using FOLYFOOD.Dto;

namespace FOLYFOOD.Hellers.Mail
{
    public class EmailAdmissionForm
    {

        public static string GenerateWelcomeEmail(MailWelcomeToAdmissionDTO mailPointRequest)
        {
            DateTime admissionDate = mailPointRequest.studentAdmissionDate ?? DateTime.Now;
            DateTime endDate = mailPointRequest.studentExpectedEndDate ?? DateTime.Now;
            // Để tính số tháng học, chúng ta sẽ lấy phần nguyên của kết quả chia
            // từ ngày kết thúc và ngày nhập học
            int numberOfMonths = ((endDate.Year - admissionDate.Year) * 12) + endDate.Month - admissionDate.Month;

            // Nếu ngày kết thúc sau ngày nhập học nhưng cùng tháng, thì cộng thêm 1 tháng
            if (numberOfMonths == 0)
            {
                numberOfMonths++;
            }

            string emailTemplate = $@"<!DOCTYPE html>
<html>
  <head>
    <meta charset=""UTF-8"" />
    <title>Chào mừng bạn đến với LTS EDU</title>
    <style>
      body {{
        font-family: ""Times New Roman"", Times, serif;
        line-height: 1.6;
        width: 100%;
        background-color: #f0f0f0; /* Màu nền cho body */
      }}

      .container {{
        max-width: 700px;
        margin: 0 auto;
        padding: 20px;
        font-weight: 600;
        border: 10px double #13336042;
        background-color: #006c6d09;
        border-radius: 8px;
        font-size: medium;
        color: #321811e8;
      }}

      .header {{
        text-align: center;
        margin-bottom: 10px;
        color: #321811;
        font-weight: bold;
      }}

      .intro {{
        margin-bottom: 10px;
      }}

      .course-details {{
        margin-bottom: 10px;
      }}

      .contact-info {{
        margin-top: 10px;
        border-top: 1px solid #ccc;
        padding-top: 20px;
      }}
      img {{
        width: 200px;
        height: auto;
        opacity: 0.9;
        max-height: 48px;
      }}
    </style>
  </head>
  <body>
    <table class=""container"" width=""100%"" cellpadding=""10"">
      <tr>
        <td align=""center"" width=""50%"">
          <!-- Hình ảnh nằm dọc -->
          <img
            src=""https://res.cloudinary.com/doedovklj/image/upload/v1690183552/xyz-abc_638258055505537759image.png""
            alt=""Background Image""
            width=""200px"" />
        </td>
        <td align=""center"" width=""50%"">
          <!-- Hình ảnh nằm dọc -->
          <img
            src=""https://res.cloudinary.com/doedovklj/image/upload/v1690185104/xyz-abc_638258071033904829image.png""
            alt=""Background Image""
            width=""200px"" />
        </td>
      </tr>
      <tr>
        <td colspan=""2"" class=""header"">
          <h1>Chào mừng bạn đến với LTS EDU</h1>
        </td>
      </tr>
      <tr>
        <td colspan=""2"" class=""intro"">
          <p>
            LTS EDU trực thuộc tập đoàn công nghệ LTS Group – Tiền thân là HVIT
            CLAN được thành lập từ năm 2004, đứng đầu bởi anh Nguyễn Đồng Khánh
            – CTO LTS Group kiêm CEO của LTS EDU.
          </p>
          <p>
            Ra đời với phương châm “Ươm mầm tri thức, dẫn đường công nghệ”, đào
            tạo nguồn nhân lực IT chất lượng cao, cung ứng cho thị trường công
            nghệ thông tin nói chung và tập đoàn LTS GROUP nói riêng.
          </p>
          <p>
            LTS EDU đã và đang là một trong những đơn vị tiềm năng trong công
            cuộc đào tạo lập trình viên chuyên nghiệp với hơn 16 năm kinh
            nghiệm, chương trình đào tạo dành cho mọi đối tượng, học cái doanh
            nghiệp cần - làm cái khách hàng muốn.
          </p>
        </td>
      </tr>
      <tr>
        <td colspan=""2"">
          <h3>
            Chào mừng bạn
            <a style=""color: rgb(145, 33, 33)"">{mailPointRequest.studentName}</a> đăng ký khóa
            học {mailPointRequest.studentCourse} của Công ty cổ phần học viện Lotus - LTS EDU
          </h3>
        </td>
      </tr>
      <tr>
        <td colspan=""2"" class=""course-details"">
          <h2>Thông tin khóa học</h2>
          <ul>
            <li>Thời gian học: {numberOfMonths} tháng</li>
            <li>Ngày nhập học: {admissionDate:dd/MM/yyyy}</li>
            <li>Ngày dự kiến kết thúc: {endDate:dd/MM/yyyy}</li>
            <li>Hình thức học: {mailPointRequest.studentLearningForm}</li>
            <li>Địa chỉ: {mailPointRequest.lTSEduAddress}</li>
          </ul>
        </td>
      </tr>
      <tr>
        <td colspan=""2"" class=""contact-info"">
          <p>
            Mọi thắc mắc Học viên liên hệ với Admin của học viện qua số điện
            thoại: {mailPointRequest.AdminPhone} để được hỗ trợ sớm nhất.
          </p>
          <p>
            Dưới đây là biên bản cam kết và nội quy của Học Viện. Học viên vui
            lòng đọc kỹ các quy định của Học Viện và thực hiện nghiêm túc các
            quy định dưới.
          </p>
          <p>
            <b>Lưu ý: Các trường hợp vi phạm sẽ xử lý đúng theo quy
            định của Học Viện.</b>
            </p>
          <p>Trân trọng!</p>
        </td>
      </tr>
    </table>
  </body>
</html>
";
            return emailTemplate;
        }
    }
}
