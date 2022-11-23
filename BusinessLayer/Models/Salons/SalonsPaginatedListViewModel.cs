using CoreLayer.MvcUI.Pagination;

namespace BusinessLayer.Models.Salons
{
    public class SalonsPaginatedListViewModel
    {
        public PaginatedList<SalonViewModel> Salons { get; set; }
    }
}
