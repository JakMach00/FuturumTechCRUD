namespace FTCRUD.Models
{
    public class UpdateCampaignViewModel
    {
        public int Id { get; set; }

        public string CampaignName { get; set; }

        public string Keywords { get; set; }

        public decimal BidAmount { get; set; }

        public decimal CampaignFund { get; set; }

        public bool Status { get; set; }

        public string Town { get; set; }

        public int Radius { get; set; }
    }
}
