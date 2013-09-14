using System;

namespace MatrixDeterminant
{
	class Program
	{
		public static int Puzzle( int [] a){
			int length = a.Length;
			int size = (int) Math.Sqrt(a.Length);
			int pas = size + 1;
			int rlsum = 1;int lrsum = 1;

			for (int i =0; i<size; i++) {
				int product = 1;
				for (int j=0; j<size; j++) {
					int index = 0;
					if (i + j*pas < (j+1)*size)
						index = i + j*pas;
					else 
						index = i + (j-1)*pas+ 1 ;
					product *= a[index];
				}
				rlsum += product;
			}

			int[,] matrix =  new int [size,size];
			int mindex =0;
			foreach (var item in a) {
				matrix[mindex/size,mindex%size]=a[mindex];
				mindex++;
			}
			for (int i = size; i > 0; --i) {//columnm
				int product = 1;int x = i;
				for (int j=0; j <size; j++) {//Line
					int xN = getNextDecIndex (x, size);
					product *= matrix[j,xN];
					x=xN;
				}
				lrsum += product;
			}
			return rlsum-lrsum;
		} 


		static int getNextIndex(int previous, int size, bool increase){
			size--;//to match index
		previous=(increase)?previous+1:previous-1;
			if (!increase) {
				if (previous == -1)
					return size;
				if (previous < 0 )
					return size + previous + 1;//to compensate index
			}
			if (previous > size && increase)
				return 0;
			return (previous);
		}
		public static int getNextDecIndex(int previous, int size){
			return getNextIndex (previous, size, false);
		}
		 public static int getNextIncIndex(int previous, int size){
			return getNextIndex (previous, size, true);
		}
		public static void Main (string[] args)
		{
			
			Program c = new Program ();
			int[] a = {1,2,3,4,5,6,7,8,9  };
			//int[] a = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
			int res= Program.Puzzle(a);
			Console.WriteLine ("Hello World!, {0}",res);
			//Console.ReadKey ();

		}
	}
}
