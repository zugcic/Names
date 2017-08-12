using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeChef {
	class Program {
		static void Main(string[] args) {

			int cases;

			Console.WriteLine("Num cases->");
			cases = Int32.Parse(Console.ReadLine());

			if (cases < 1 || cases > 3) {
				Console.WriteLine("Wrong num cases, select 1-3");
			}

			if (cases == 1) {
				string ime1;
				Console.WriteLine("Write name->");
				ime1 = Console.ReadLine();
				ime1 = ime1.ToLower();
				char c = ime1.ElementAt(0);
				Console.WriteLine(c.ToString().ToUpper() + ime1.Substring(1));

			} else if (cases == 2) {

				string ime1;
				string ime2;

				Console.WriteLine("Write first name->");
				ime1 = Console.ReadLine();
				ime1 = ime1.ToLower();

				Console.WriteLine("Write second name");
				ime2 = Console.ReadLine();
				ime2 = ime2.ToLower();

				Console.WriteLine(ime1.ElementAt(0).ToString().ToUpper() + "."
					+ ime2.ElementAt(0).ToString().ToUpper() + ime2.Substring(1));
			} else if (cases == 3) {

				string ime1;
				string ime2;
				string ime3;

				Console.WriteLine("Write first name->");
				ime1 = Console.ReadLine();
				ime1 = ime1.ToLower();

				Console.WriteLine("Write second name->");
				ime2 = Console.ReadLine();
				ime2 = ime2.ToLower();

				Console.WriteLine("Write third name->");
				ime3 = Console.ReadLine();
				ime3 = ime3.ToLower();

				Console.WriteLine(ime1.ElementAt(0).ToString().ToUpper() + "."
					+ ime2.ElementAt(0).ToString().ToUpper()+"."+ 
					ime3.ElementAt(0).ToString().ToUpper() + ime3.Substring(1));

			}
		}
	}
}
