using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.CM;
using PX.Objects.CS;
using PX.Objects.TX;
using PX.Objects.AR;
using PX.Objects.IN;

namespace ReusableBusinessObjects
{
	public class Document : PXMappedCacheExtension
	{
		#region Description
		public abstract class description : IBqlField
		{
		}
		protected String _Description;
		public virtual String Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}
		#endregion
	}
	public partial class SalesPerson : PXMappedCacheExtension
	{
		#region SalespersonID
		public abstract class salespersonID : PX.Data.IBqlField
		{
		}
		protected Int32? _SalespersonID;
		public virtual Int32? SalespersonID
		{
			get
			{
				return this._SalespersonID;
			}
			set
			{
				this._SalespersonID = value;
			}
		}
		#endregion
		#region Commision
		public abstract class commision : PX.Data.IBqlField
		{
		}
		protected Decimal? _Commision;
		public virtual Decimal? Commision
		{
			get
			{
				return this._Commision;
			}
			set
			{
				this._Commision = value;
			}
		}
		#endregion
	}

	public abstract class CommisionGraph<TGraph, TPrimary> : PXGraphExtension<TGraph>
			where TGraph : PXGraph
			where TPrimary : class, IBqlTable, new()
	{
		protected class DocumentMapping : IBqlMapping
		{
			protected Type _extension = typeof(Document);
			public Type Extension => _extension;

			protected Type _table;
			public Type Table => _table;

			public DocumentMapping(Type table)
			{
				_table = table;
			}

			public Type Description = typeof(Document.description);
		}

		protected class SalesPersonMapping : IBqlMapping
		{
			public Type Extension => typeof(SalesPerson);
			protected Type _table;
			public Type Table => _table;

			public SalesPersonMapping(Type table)
			{
				_table = table;
			}

			public Type SalespersonID = typeof(SalesPerson.salespersonID);
			public Type Commision = typeof(SalesPerson.commision);
		}


		protected abstract DocumentMapping GetDocumentMapping();
		protected abstract SalesPersonMapping GetSalesPersonMapping();


		public PXSelectExtension<Document> Documents;
		public PXSelectExtension<SalesPerson> Details;

		protected virtual void _(Events.RowUpdated<Document> e)
		{
			Document doc = e.Row;

			decimal? total = 0m;
			foreach(SalesPerson sp in Details.Select())
			{
				total += sp.Commision;
			}

			e.Cache.SetValueExt<Document.description>(e.Row, "Total commision calculated = " + total.ToString());
		}
	}
}