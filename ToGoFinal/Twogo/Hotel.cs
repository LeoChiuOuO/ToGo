//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToGo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            this.HotelServiceAndFacilities = new HashSet<HotelServiceAndFacility>();
            this.Orders = new HashSet<Order>();
            this.RoomInformations = new HashSet<RoomInformation>();
        }
    
        public int HotelID { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public string HotelNameEN { get; set; }
        public string HotelNameCN { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string AddressCH { get; set; }
        public string AddressEN { get; set; }
        public Nullable<int> StarRated { get; set; }
        public string TaxIDNumber { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public string Description { get; set; }
        public string GoogleMapUri { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual HotelImage HotelImage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelServiceAndFacility> HotelServiceAndFacilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomInformation> RoomInformations { get; set; }
    }
}