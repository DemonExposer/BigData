using System;
using System.IO;
using System.Threading.Tasks;

namespace BigData {
	public class Program {
		public async static Task Main(string[] args) {
			StreamWriter file = new StreamWriter("bigData.txt", true);
			Random random = new Random();
			while (true)
				await file.WriteAsync((char) random.Next(256));
		}
	}
}
