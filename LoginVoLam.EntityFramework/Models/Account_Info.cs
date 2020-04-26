using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace LoginVoLam.EntityFramework.Models
{
    public partial class Account_Info
    {
        [Key]
        [StringLength(32)]
        public string cAccName { get; set; }

        [StringLength(32)]
        public string cSecPassWord { get; set; }

        [Required]
        [StringLength(32)]
        public string cPassWord { get; set; }

        public long? iClientID { get; set; }

        public DateTime? dLoginDate { get; set; }

        public DateTime? dLogoutDate { get; set; }

        public short nExtPoint { get; set; }

        public short nExtPoint1 { get; set; }

        public short nExtPoint2 { get; set; }

        public short nExtPoint3 { get; set; }

        public short nExtPoint4 { get; set; }

        public short nExtPoint5 { get; set; }

        public short nExtPoint6 { get; set; }

        public short nExtPoint7 { get; set; }

        public int? nUserIP { get; set; }

        public int? nUserIPPort { get; set; }

        public int? nFeeType { get; set; }

        public bool bParentalControl { get; set; }

        public bool bIsBanned { get; set; }

        public bool bIsUseOTP { get; set; }

        public byte iOTPSessionLifeTime { get; set; }

        public int iServiceFlag { get; set; }
    }
}
