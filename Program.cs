using System;
using System.Text;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StudentDAO dao = new StudentDAO();

            // 1. Thêm mới sinh viên
            dao.Add(new Student("SV01", "Nguyễn Văn A", 20, 3.45));
            dao.Add(new Student("SV02", "Trần Thị B", 21, 3.80));
            dao.Add(new Student("SV03", "Lê Văn A", 19, 2.90));

            Console.WriteLine("=== DANH SÁCH BAN ĐẦU ===");
            dao.getAlls().ForEach(s => Console.WriteLine(s));

            // 2. Chỉnh sửa
            dao.Edit(new Student("SV01", "Nguyễn Văn An", 21, 3.60));

            // 3. Xóa
            dao.Delete("SV02");

            Console.WriteLine("\n=== DANH SÁCH SAU KHI SỬA SV01 VÀ XÓA SV02 ===");
            dao.getAlls().ForEach(s => Console.WriteLine(s));

            // 4. Tìm kiếm theo ID
            Console.WriteLine("\n=== TÌM THEO ID (SV01) ===");
            var st = dao.getById("SV01");
            Console.WriteLine(st != null ? st.ToString() : "Không tìm thấy");

            // 5. Tìm kiếm theo tên
            Console.WriteLine("\n=== TÌM THEO TÊN ('Văn') ===");
            var results = dao.getByName("Văn");
            results.ForEach(s => Console.WriteLine(s));
        }
    }
}

