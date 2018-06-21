using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ConsoleTest
{
	//Class represents Journal Entry page, extends auto-generated page wrapper.
	public class JournalEntry : GL301000_JournalEntry
	{
		//Makes summary form container accessible.
		public c_batchmodule_form Summary
		{
			get
			{
				return base.BatchModule_form;
			}
		}
		//Makes transaction details grid container accessible.
		public c_gltranmodulebatnbr_grid Details
		{
			get
			{
				return base.GLTranModuleBatNbr_grid;
			}
		}
	}
}
