using System;
using NUnit.Framework;

namespace MatrixDeterminant
{
	[TestFixture()]
	public class MatrixDeterminantTest
	{
		[Test()]
		public void getNextIncIndex ()
		{
			int[] a = {1,2,0};
			int[] b = {2,0,1,2,1};
			for (int i = 0; i < a.Length; i++) {
				int result=MatrixDeterminant.MainClass.getNextIncIndex(a[i],3) ;
				Assert.AreEqual (b[i],result,"input "+a[i]+" result:"+result);
			}

		}
		[Test()]
		public void getNextDecIndex ()
		{
			int[] a = {1,2,0 };
			int[] b = {0,1,2,1,1};
			for (int i = 0; i < a.Length; i++) {
				int result=MatrixDeterminant.MainClass.getNextDecIndex(a[i],3) ;

				Assert.AreEqual (b[i], result,"input "+a[i]+" result:"+result);
			}

		}

	}
}

