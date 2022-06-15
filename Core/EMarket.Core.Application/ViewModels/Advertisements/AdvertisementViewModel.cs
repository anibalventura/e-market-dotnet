﻿namespace EMarket.Core.Application.ViewModels.Advertisements
{
	public class AdvertisementViewModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}