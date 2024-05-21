using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException : Exception
    {
        // Constructor của lớp exception, có thể truyền thông điệp cho exception
        public CustomException() : base("Ten phai khac rong")
        {
        }

        // Bạn cũng có thể thêm các properties và methods tùy chỉnh cho lớp exception của bạn nếu cần thiết

    }
    public class AgeException: Exception
    {
        public int age { get; set; }
        public AgeException(int _age):base("Tuổi không phù hợp") {
            age = _age;
        }
        public void Detail()
        {
            Console.WriteLine($"Tuoi {age} không nằm trong khoảng [18-100]");
        }
    }
}
