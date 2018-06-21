using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.TestExecution;
using Core.Login;

namespace ConsoleTest
{
	//Use check-class as a parent for your every test.
	public class MyTestGL : Check
	{
		//Add your test-specific logic in the method below for every test.
		public override void Execute()
		{
			PxLogin.LogIn("admin", "123");

			//Test case 1
			JournalEntry journalEntry = new JournalEntry();
			journalEntry.OpenScreen();

			//Test case 2
			journalEntry.Insert();
			journalEntry.Summary.BranchID.Select("HQ");
			journalEntry.Summary.LedgerID.Select("ACTUAL");
			journalEntry.Summary.Description.Type("Test journal entry 1");

			journalEntry.Details.New();
			journalEntry.Details.Row.AccountID.Select("10700");
			journalEntry.Details.Row.AccountID.GetError().VerifyContains("Denominated GL Account currency is different from transaction currency.");
			journalEntry.Details.Row.AccountID.Type("10100");
			journalEntry.Details.Row.AccountID_Account_description.GetValue().VerifyEquals("Wrong Description");
			journalEntry.Details.Row.AccountID_Account_description.GetValue().VerifyEquals("Petty Cash");
			journalEntry.Details.Row.ProjectID.Select("X");
			journalEntry.Details.Row.CuryDebitAmt.Type(100);

			journalEntry.Details.New();
			journalEntry.Details.Row.AccountID.Select("62400");
			journalEntry.Details.Row.CuryCreditAmt.Type(0);

			journalEntry.Details.SelectRow(2);
			journalEntry.Details.Row.CuryCreditAmt.Type(100);
			journalEntry.Save();

			//Test case 3
			journalEntry.Release();
			journalEntry.Summary.AutoReverseCopy.GetValue().VerifyEquals(false);

			//Test case 4
			journalEntry.ReverseBatch();
			journalEntry.Summary.AutoReverseCopy.GetValue().VerifyEquals(true);
			journalEntry.Summary.Description.Type("Test journal entry 2");
			journalEntry.Save();

			//Test case 5
			ReleaseTransactionsGl releaseTransactionsGl = new ReleaseTransactionsGl();
			releaseTransactionsGl.OpenScreen();
			releaseTransactionsGl.Details.Row.Selected.SetTrue();
			releaseTransactionsGl.Process();
		}
	}

	public class MyTestGLBob : Check
	{
		public override void Execute()
		{
			PxLogin.LogIn("admin", "123");

			var toolsForm = new ToolManagement();
			toolsForm.OpenScreen();

			toolsForm.Insert();
			toolsForm.Summary.Toolcd.Type("ABC");
			toolsForm.Summary.Description.Type("My new tool");
			toolsForm.Summary.SerialNumber.Type("XYZ"); //System should complain that serial number doesn't start with BOB-.

			toolsForm.Save();

			toolsForm.Summary.SerialNumber.Type("BOB-1234");
			toolsForm.Save();
		}
	}
}
