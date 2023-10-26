using Ex_baze_date.Model.Base;

namespace Ex_baze_date.Model
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }
        //public Student() { }
    }
}
