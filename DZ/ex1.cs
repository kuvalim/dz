using System;

namespace blabla
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int size;
			Console.WriteLine("Введите количество эелементов в массиве:");
			size = int.Parse(Console.ReadLine());
			int[] b = new int[Math.Abs(size)];
			string bb;
			for (int i = 0; i <Math.Abs(size); i++)
			{
				Console.Write("Введите элемент номер {0} :", i+1);
				bb = Console.ReadLine();
				b[i] = Convert.ToInt16(aa);
			}
			Console.Write("Массив:");
			foreach (int j in b)
			{
				Console.Write("{0} ", j);
			}
		}
	}
}
