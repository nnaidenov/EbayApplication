namespace EbayApplication.Web.Models.ProductModels
{
    using EbayApplication.Web.Models.AuctionModels;

    public class ProductDetailedViewModel
    {
        public AuctionDetailedViewModel Auction { get; set; }

        public ProductViewModel Product { get; set; }

        public ProductDetailedViewModel()
        {
        }

        public ProductDetailedViewModel(ProductViewModel product)
        {
            this.Product = product;
        }

        public ProductDetailedViewModel(ProductViewModel product, AuctionDetailedViewModel auction)
            :this(product)
        {
            this.Auction = auction;
        }
    }
}