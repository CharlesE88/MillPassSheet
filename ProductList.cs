using System;


namespace MillPassApplication
{
	public class ProductList
	{

		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public int ProductCategoryID { get; set; }


		private List<ProductList> products;


		public List<ProductList> Products()
		{
			get { return products; }
			set { products = value; }
		}
	}
}
