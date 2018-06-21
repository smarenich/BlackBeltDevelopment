using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.SO;
using PX.Objects.AR;
using PX.Objects.CR;

namespace ReusableBusinessObjects
{
	public class SalesOrderCommision : CommisionGraph<SOOrderEntry, SOOrder>
	{
		protected override DocumentMapping GetDocumentMapping()
		{
			return new DocumentMapping(typeof(SOOrder)) { Description = typeof(SOOrder.orderDesc) };
		}
		protected override SalesPersonMapping GetSalesPersonMapping()
		{
			return new SalesPersonMapping(typeof(SOSalesPerTran)) { Commision = typeof(SOSalesPerTran.curyCommnAmt) };
		}
	}

	public class ARInvoiceCommision : CommisionGraph<ARInvoiceEntry, ARInvoice>
	{
		protected override DocumentMapping GetDocumentMapping()
		{
			return new DocumentMapping(typeof(ARInvoice)) { Description = typeof(ARInvoice.docDesc) };
		}
		protected override SalesPersonMapping GetSalesPersonMapping()
		{
			return new SalesPersonMapping(typeof(ARSalesPerTran)) { Commision = typeof(ARSalesPerTran.curyCommnAmt) };
		}
	}
}
