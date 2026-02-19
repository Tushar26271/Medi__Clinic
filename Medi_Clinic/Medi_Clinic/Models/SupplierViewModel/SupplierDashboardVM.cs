using Medi_Clinic.Models;

namespace Medi_Clinic.ViewModels
{
    public class SupplierDashboardVM
    {
        public string SupplierName { get; set; }
        public int TotalAssignedPO { get; set; }
        public List<PurchaseOrderHeader> RecentPO { get; set; }
    }
}
