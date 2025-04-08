using FOLYFOOD.Dto;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.Hellers.Mail
{
    public class CourseNotificationEmailTheme
    {
        public static string ThemeSendMail(MailPointRequest mailPointRequest)
        {
            string emailContent = @"
<!DOCTYPE html>
<html>
<head>
  <meta charset=""utf-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <title>LTS EDU - THÔNG BÁO ĐIỂM HỌC PHẦN</title>
  <style>a
    /* Đoạn mã CSS của giao diện email */
    .body {
      font-family: Arial, sans-serif;
      background-color: #f4f4f4;
      background-image: url(""https://wallpaperaccess.com/full/1097489.jpg"");
      margin: 0;
      padding: 0;
    }
    .container {
      max-width: 600px;
      margin: 0 auto;
      padding: 30px;
      background-color: #ffffff;
    }
    h1 {
      text-align: center;
      color: #333333;
    }
    table {
      width: 100%;
      border-collapse: collapse;
      margin-bottom: 20px;
    }
    th, td {
      padding: 10px;
      text-align: left;
    }
    th {
      background-color: #f2f2f2;
      font-weight: bold;
      text-transform: uppercase;
      font-size: 14px;
    }
    td {
      border-bottom: 1px solid #dddddd;
    }
    .footer {
      margin-top: 20px;
      color: #888888;
      text-align: center;
    }
  </style>
</head>
<body class=""body"">
  <div class=""container"">
    <h1>LTS EDU - THÔNG BÁO ĐIỂM HỌC PHẦN</h1>
    <p><strong>Học viên:</strong> " + mailPointRequest.StudentName + @"</p>
    <p><strong>Số điện thoại:</strong> " + mailPointRequest.Phone + @"</p>
    <p><strong>Khóa học:</strong> " + mailPointRequest.CourseName + @"</p>
    <p><strong>Ngày nhập học:</strong> " + mailPointRequest.DayAdmission.ToShortDateString() + @"</p>
    <p><strong>Ngày dự kiến kết thúc:</strong> " + mailPointRequest.DayEndEstimatedEndDate.ToShortDateString() + @"</p>
    <table>
      <tr>
        <th style=""width: 60%"">Môn học</th>
        <th style=""width: 40%"">Điểm</th>
      </tr>";

            // Danh sách môn học và điểm
            foreach (var course in mailPointRequest.subjects)
            {
                emailContent += @"
      <tr>
        <td><strong>" + course.Name + @"</strong></td>
        <td>" + course.Point + " " + @"đ</td>
      </tr>";
            }

            emailContent += $@"
    </table>
    <h5>{mailPointRequest.TotalRating}</h4>
    <div class=""footer"">
      <p>Trân trọng,</p>
      <p>LTS EDU</p>
    </div>
  </div>
</body>
</html>
";

            return emailContent;
        }
    }
}
