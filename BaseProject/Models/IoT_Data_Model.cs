﻿using BaseProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models
{
    public class IoT_Data_Model
    {
        [Key]
        public int Id { get; set; }
        //public int IoTModelId { get; set; }
        //public IoT_Model IoTModel { get; set; }
        public int ProductId { get; set; }
        public Product_Model Product { get; set; }
        public int Count { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
