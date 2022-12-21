using FTCRUD.Data;
using FTCRUD.Models;
using FTCRUD.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.EventSource;

namespace FTCRUD.Controllers
{
    public class CampaignsController : Controller
    {
        private readonly CRUDDbContext crudDbContext;

        public CampaignsController(CRUDDbContext mvCrudDbContext)
        {
            this.crudDbContext = mvCrudDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var campaigns = await crudDbContext.Campaigns.ToListAsync();

            return View(campaigns);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Add(AddCampaignViewModel addCampaignRequest)
        {
            var campaign = new Campaign()
            {
                CampaignName = addCampaignRequest.CampaignName,
                Keywords = addCampaignRequest.Keywords,
                BidAmount = addCampaignRequest.BidAmount,
                CampaignFund = addCampaignRequest.CampaignFund,
                Status = addCampaignRequest.Status,
                Town = addCampaignRequest.Town,
                Radius = addCampaignRequest.Radius
            };

            await crudDbContext.Campaigns.AddAsync(campaign);
            await crudDbContext.SaveChangesAsync();

            return RedirectToAction("Add");
        }

        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var campaign = await crudDbContext.Campaigns.FirstOrDefaultAsync(c => c.Id == id);

            if (campaign != null)
            {
                var viewModel = new UpdateCampaignViewModel()
                {
                    Id = campaign.Id,
                    CampaignName = campaign.CampaignName,
                    Keywords = campaign.Keywords,
                    BidAmount = campaign.BidAmount,
                    CampaignFund = campaign.CampaignFund,
                    Status = campaign.Status,
                    Town = campaign.Town,
                    Radius = campaign.Radius
                };

                return await Task.Run(() => View("View", viewModel));
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateCampaignViewModel model)
        {
            var campaign = await crudDbContext.Campaigns.FindAsync(model.Id);

            if (campaign != null)
            {
                campaign.CampaignName = model.CampaignName;
                campaign.Keywords = model.Keywords;
                campaign.BidAmount = model.BidAmount;
                campaign.CampaignFund = model.CampaignFund;
                campaign.Status = model.Status;
                campaign.Town = model.Town;
                campaign.Radius = model.Radius;

                crudDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateCampaignViewModel model)
        {
            var campaign = await crudDbContext.Campaigns.FindAsync(model.Id);

            if (campaign != null)
            {
                crudDbContext.Campaigns.Remove(campaign);
                await crudDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
