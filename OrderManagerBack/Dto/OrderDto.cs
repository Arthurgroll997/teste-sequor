﻿namespace OrderManagerBack.Dto
{
    public class OrderDto
    {
        public string Order { get; set; }
        public decimal Quantity { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public decimal CycleTime { get; set; }
        public List<MaterialDto> Materials { get; set; }
    }
}
