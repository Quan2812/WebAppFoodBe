namespace FOLYFOOD.Dto
{
    public class MailWelcomeToAdmissionDTO
    {
        public string? lTSGroupName { get; set; } 
        public string? lTSGroupCoreTechnology { get; set; }
        public string? lTSGroupCEO { get; set; }
        public string? lTSEduFormerName { get; set; }
        public string? lTSEduPhilosophy { get; set; }
        public string? lTSEduAddress { get; set; }
        public string? lTSEduYearsOfExperience { get; set; }
        public string? lTSEduTrainingProgram { get; set; }
        public string? studentName { get; set; }
        public string? studentCourse { get; set; }
        public string? studentEmail { get; set; }

        public string? studentLearningForm { get; set; }
        public DateTime? studentAdmissionDate { get; set; }
        public DateTime? studentExpectedEndDate { get; set; }
        public string? AdminName { get; set; }
        public string? AdminPhone { get; set; }
        public string? AdminAddress { get; set; }
        public List<IFormFile>? Attachments { get; set; }
    }
   
    public class Student
    {
        public string? Name { get; set; } = "Phạm Tài Linh";
        public string? Course { get; set; } = " Backend của LTS EDU";
        public string? Email { get; set; } = " Backend của LTS EDU";

        public string? LearningForm = "online";
        public DateTime? AdmissionDate { get; set; } = new DateTime();
        public DateTime? ExpectedEndDate { get; set; } = new DateTime();
    }
    public class Admin
    {
        public string? Name { get; set; } = "AnhCTP";
        public string? Phone { get; set; } = "0333747897";
        public string? Address { get; set; } = " Số 30, ngõ 304 Hồ Tùng Mậu, Phú Diễn, Từ Liêm, Hà Nội";
    }


}
