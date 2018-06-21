using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Wait;

namespace ConsoleTest
{
	public class ReleaseTransactionsGl : GL501000_BatchRelease
	{
		//Makes transactions grid container accessible.
		public c_batchlist_grid Details
		{
			get
			{
				return base.BatchList_grid;
			}
		}
	}
}
