using Ashtyn_Pannell_Amazon;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace Ashtyn_Pannell_Amazon
{
    public class Product
    {
        private string _productName = "";
        private readonly DateTime _createdAt;
        public required string _sellerSKUValue;

    public static int ProductCount = 0;

        [SetsRequiredMembers]
        public Product()
        {
            _createdAt = DateTime.Now;
            ProductDescription = "";
            _sellerSKUValue = "";
            ProductCount++;
        }

        [SetsRequiredMembers]
        public Product(string productID, string productName)
        {
            _createdAt = DateTime.Now;
            ProductID = productID;
            ProductName = productName;
            ProductDescription = "";
            _sellerSKUValue = "";
            ProductCount++;
        }

        [SetsRequiredMembers]
        public Product(string productID, string productName, string productDescription, string productCategory, string productPrice, string sellerSKU)
        {
            _createdAt = DateTime.Now;
            ProductID = productID;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            ProductPrice = productPrice;
            _sellerSKUValue = sellerSKU;
            ProductCount++;
        }

        public string ProductID { get; init; } = "";

        public string ProductName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_productName))
                {
                    return "Unknown Product";
                }

                return _productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _productName = "Unknown Product";
                }
                else
                {
                    _productName = value.Trim();
                }
            }
        }

        public required string ProductDescription { get; set; } = "";

        public string ProductCategory { get; set; } = "";

        public string ProductPrice { get; set; } = "";

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string SellerSKU
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_sellerSKUValue))
                {
                    return "SKU not assigned";
                }

                return _sellerSKUValue;
            }
        }
    }

}
