using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AtelierBooking.Models.Enums
{
    internal enum Status
    {
        [Display(Name = "Zrusene")]
        Canceled = -2,

        [Display(Name = "Zamitnuté")]
        Denyed = -1,

        [Display(Name = "Nové")]
        New = 0,

        [Display(Name = "Schválené")]
        Approved = 1,

        [Display(Name = "Systémové")]
        System = 2,

        [Display(Name = "Předschválené")]
        Preapproved = 3
    }
}