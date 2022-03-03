using System;
using System.Linq;
using WaterProject.Models.ViewModels;

namespace WaterProject.Models
{
    public interface IDonationRepository
    {
        IQueryable<Donation> Donations { get; }

        void SaveDonation(Donation donation);
    }
}
