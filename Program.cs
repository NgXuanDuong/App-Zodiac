using System;

namespace ApplicationZodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Zodiac");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string choice = "";
            do
            {
                //Khi người dùng chọn YES
                int month = 0;
                int day = 0;
                while (true)
                {
                    Console.Write("Nhập ngày sinh: ");
                    day = Convert.ToInt32(Console.ReadLine() + "\n");
                    Console.Write("Nhập tháng sinh : ");
                    month = Convert.ToInt32(Console.ReadLine() + "\n");
                    if (month == 2 && day >= 1 && day <= 28)
                    {
                        break;
                    }
                    //Tháng có 30 ngày
                    if ((month == 4 || month == 6 || month == 9 || month == 11) && day >= 1 && day <= 30)
                    {
                        break;
                    }
                    //Tháng có 31 ngày
                    if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8
                        || month == 10 || month == 12) && day >= 1 && day <= 31)

                    {
                        break;
                    }
                    Console.WriteLine("Nhập ngày, tháng không hợp lệ.Vui lòng nhập lại.");
                }
                //Kiểm tra và xuất cung hoàng đạo tương ứng
                string result = "";
                switch (month)
                {
                    case 1:
                        if (day >= 20)
                        {
                            result = "Bảo Bình";
                        }
                        else
                        {
                            result = "Ma Kết";
                        }
                        break;
                    case 2:
                        if (day >= 19)
                        {
                            result = "Song Ngư";
                        }
                        else
                        {
                            result = "Bảo Bình";
                        }
                        break;
                    case 3:
                        if (day >= 21)
                        {
                            result = "Bạch Dương";
                        }
                        else
                        {
                            result = "Kim Ngưu";
                        }
                        break;
                    case 4:
                        if (day < 20)
                        {
                            result = "Bạch Dương";
                        }
                        else
                        {
                            result = "Kim Ngưu";
                        }
                        break;
                    case 5:
                        if (day >= 21)
                        {
                            result = "Song Tử";
                        }
                        else
                        {
                            result = "Kim Ngưu";
                        }
                        break;
                    case 6:
                        if (day >= 21)
                        {
                            result = "Cự Giải";
                        }
                        else
                        {
                            result = "Song Tử";
                        }
                        break;
                    case 7:
                        if (day >= 23)
                        {
                            result = "Sư Tử";
                        }
                        else
                        {
                            result = "Cự Giải";
                        }
                        break;
                    case 8:
                        if (day < 23)
                        {
                            result = "Sư Tử";
                        }
                        else
                        {
                            result = "Xử Nữ";
                        }
                        break;
                    case 9:
                        if (day >= 23)
                        {
                            result = "Thiên Bình";
                        }
                        else
                        {
                            result = "Xử Nữ";
                        }
                        break;
                    case 10:
                        if (day < 23)
                        {
                            result = "Thiên Bình";
                        }
                        else
                        {
                            result = "Thiên Yết";
                        }
                        break;
                    case 11:
                        if (day >= 22)
                        {
                            result = "Nhân Mã";
                        }
                        else
                        {
                            result = "Thiên Yết";
                        }
                        break;
                    case 12:
                        if (day < 22)
                        {
                            result = "Nhân Mã";
                        }
                        else
                        {
                            result = "Ma Kết";
                        }
                        break;

                }
                //Xuất kết quả :
                Console.WriteLine("Bạn thuộc cung : {0}", result);
                Console.WriteLine("==============================");
                Console.WriteLine("Nhập YES để tiếp tục. Nhập NO để thoát");
                choice = Console.ReadLine();
                if (choice.ToLower() == "no")
                {
                    System.Environment.Exit(0);
                }
            } while (true);
            Console.Write("Nguyễn Xuân Dương");

            Console.ReadKey();
        }
    }
}
