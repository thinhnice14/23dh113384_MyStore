using System;
using System.Collections.Generic;
using System.Linq;
using PagedList.Mvc;
using System.Web;

namespace _23dh113384_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        //tiêu chí để search the tên,mô tả sp
        // hoặc loại sản phẩm 
        public string SearchTerm { get; set; }  
        
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        
        public string SorrtOrder {  get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;

        public PagedList.IPagedList<Product> Products { get; set; }
    }
}