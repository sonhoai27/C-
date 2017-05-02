using System;

namespace tenNam
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*int Year;
			string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
			string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "ty", "Ngo", "Mui" };
			Console.WriteLine ("Nhap vao mot nam: ");
			Year = Int32.Parse (Console.ReadLine ());

			Console.WriteLine ("Nam {0} co ten la: {1} {2}", Year, can[Year % 10], chi[Year % 12]);
			*/
			int gioiHangMang = 0;

			Console.WriteLine ("Nhap vao gioi hang mang: ");

			gioiHangMang = Int32.Parse (Console.ReadLine ());

			int[] namSinh = new int[gioiHangMang];

			for (int i = 0; i < namSinh.Length; i++) {
				namSinh[i] = Int32.Parse(Console.ReadLine ());
			}

			Console.WriteLine ("Mang Vua Nhap La: ");
			for (int i = 0; i < namSinh.Length; i++) {
				Console.Write (namSinh[i] + " ");
			}

		}
	}
}
