using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PagingParameters
    {
		const int maxPageSize = 5;
		public int PageNumber { get; set; } = 1;

		private int _pageSize = 3;
		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set
			{
				_pageSize = (value > maxPageSize) ? maxPageSize : value;
			}
		}

		public DateTime Date { get; set; }
		public string TypeOfTour { get; set; }
		public string TypeOfTransport { get; set; }
		public double Price { get; set; }
	}
}
