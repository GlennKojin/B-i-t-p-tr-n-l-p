using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    public class StudentDAO
    {
        // Danh sách nội bộ mô phỏng nguồn dữ liệu
        private readonly List<Student> _students;

        public StudentDAO()
        {
            _students = new List<Student>();
        }

        // Thêm mới sinh viên (kiểm tra trùng mã ID)
        public bool Add(Student student)
        {
            if (student == null || string.IsNullOrWhiteSpace(student.Id))
                return false;

            if (_students.Any(s => s.Id.Equals(student.Id, StringComparison.OrdinalIgnoreCase)))
                return false; // ID đã tồn tại

            _students.Add(student);
            return true;
        }

        // Cập nhật thông tin sinh viên dựa trên Id
        public bool Edit(Student student)
        {
            if (student == null) 
                return false;

            var existing = getById(student.Id);
            if (existing == null) 
                return false;

            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Gpa = student.Gpa;
            return true;
        }

        // Xóa sinh viên khỏi danh sách theo Id
        public bool Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) 
                return false;

            var student = getById(id);
            if (student == null) 
                return false;

            return _students.Remove(student);
        }

        // Lấy toàn bộ danh sách sinh viên
        public List<Student> getAlls()
        {
            return new List<Student>(_students);
        }

        // Tìm kiếm chính xác 1 sinh viên theo Id
        public Student getById(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) 
                return null;

            return _students.FirstOrDefault(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // Tìm kiếm sinh viên theo tên (chứa từ khóa, không phân biệt hoa thường)
        public List<Student> getByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new List<Student>();

            return _students
                .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}

