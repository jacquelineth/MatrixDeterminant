using System;
using NUnit.Framework;

namespace MatrixDeterminant
{
	[TestFixture()]
	public class ProgramTest
	{
		[Test()]
		public void getNextIncIndex ()
		{
			int[] a = {1,2,0};
			int[] b = {2,0,1,2,1};
			for (int i = 0; i < a.Length; i++) {
				int result=Program.getNextIncIndex(a[i],3) ;
				Assert.AreEqual (b[i],result,"input "+a[i]+" result:"+result);
			}

		}
		[Test()]
		public void getNextDecIndex ()
		{
			int[] a = {1,2,0 };
			int[] b = {0,1,2,1,1};
			for (int i = 0; i < a.Length; i++) {
				int result=Program.getNextDecIndex(a[i],3) ;

				Assert.AreEqual (b[i], result,"input "+a[i]+" result:"+result);
			}

		}
		[Test()]
		public void Puzzle2x2(){
			int[] a = { 1, 2, 3, 4 };
			int result = Program.Puzzle (a);
			Assert.AreEqual (0,result);
		}
		[Test()]
		public void Puzzle3x3(){
			int[] a = { 1,2,3,4,5,6,7,8,9   };
			int result = Program.Puzzle (a);
			int correct= a[0]*a[4]*a[8]+a[1]*a[5]*a[6]+a[2]*a[3]*a[7] -(a[2]*a[4]*a[6]+a[1]*a[3]*a[8]+a[0]*a[7]*a[5]);
			Assert.AreEqual (correct,result);
		}
	}
}

