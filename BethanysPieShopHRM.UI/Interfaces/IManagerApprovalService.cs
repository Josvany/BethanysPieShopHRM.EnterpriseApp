using BethanysPieShopHRM.Shared;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Services
{
    public interface IManagerApprovalService
    {
        Task<ExpenseStatus> GetExpenseStatus(Expense expense);
    }
}