namespace FOLYFOOD.Dto
{
    public class MailPointRequest
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }     
        public List<Subject> subjects { get; set; }
        public DateTime DayAdmission { get; set; }
        public DateTime DayEndEstimatedEndDate { get; set; }
        public string TotalRating { get; set; }
    }
    public class AdmissionRequest
    {

    }
    public class Subject
    {
        public string Name { get; set; }
        public double Point { get; set; }
    }
}
