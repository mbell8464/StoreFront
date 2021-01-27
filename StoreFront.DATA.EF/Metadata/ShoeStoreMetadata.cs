using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF/*.Metadata*/
{
    #region Brand
    [MetadataType(typeof(BrandMetadata))]
    public partial class Brand { }

    public class BrandMetadata
    {
        [Required]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
    }
    #endregion

    #region Customer
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer { }

    public class CustomerMetadata
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
    }

    #endregion

    #region Department
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department { }

    public class DepartmentMetadata
    {
        [Required]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }
    #endregion

    #region Employee
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee { }

    public class EmployeeMetadata
    {
        [Required]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        [Display(Name = "Direct Report")]
        public Nullable<int> DirectReportID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
    }
    #endregion

    #region Order
    [MetadataType(typeof(OrderMetadata))]
    public partial class Order { }

    public class OrderMetadata
    {
        [Required]
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }

        [Display(Name = "Date Ordered")]
        public Nullable<System.DateTime> OrderDate { get; set; }

        [Display(Name = "Date Shipped")]
        public Nullable<System.DateTime> ShippedDate { get; set; }

        [Required]
        [Display(Name = "Shoe")]
        public int ShoeID { get; set; }

        [Display(Name = "Order Quantity")]
        public Nullable<int> OrderQuantity { get; set; }
    }
    #endregion

    #region Shoe
    [MetadataType(typeof(ShoeMetadata))]
    public partial class Shoe { }

    public class ShoeMetadata
    {
        [Display(Name = "Shoe Category")]
        public int ShoeCategoryID { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandID { get; set; }

        [Display(Name = "Units Sold")]
        public Nullable<int> UnitsSold { get; set; }

        [Display(Name = "Image")]
        public string ShoeImage { get; set; }

        [Required]
        [Display(Name = "Shoe Status")]
        public int StatusID { get; set; }

        [Display(Name = "Shoe Size")]
        public Nullable<int> Size { get; set; }

        [Display(Name = "Shoe Color")]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Type of Shoe")]
        public Nullable<int> ShoeTypeID { get; set; }
    }
    #endregion

    #region ShoeCategory
    [MetadataType(typeof(ShoeCategoryMetadata))]
    public partial class ShoeCategory { }

    public class ShoeCategoryMetadata
    {
        [Required]
        [Display(Name = "Shoe Gender")]
        public string ShoeCategoryName { get; set; }
    }
    #endregion

    #region ShoeStatus
    [MetadataType(typeof(ShoeStatusMetadata))]
    public partial class ShoeStatus { }

    public class ShoeStatusMetadata
    {
        [Required]
        [Display(Name = "Shoe Status")]
        public string StatusName { get; set; }
    }
    #endregion

    #region ShoeType
    [MetadataType(typeof(ShoeTypeMetadata))]
    public partial class ShoeType { }

    public class ShoeTypeMetadata
    {
        [Required]
        [Display(Name = "Type of Shoe")]
        public string ShoeTypeName { get; set; }
    }
    #endregion
}
