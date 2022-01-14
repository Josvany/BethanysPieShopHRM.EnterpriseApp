using BethanysPieShopHRM.Shared;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Services
{
    public interface IExpenseApprovalSevice
    {
        Task<ExpenseStatus> GetExpenseStatus(Expense expense);
    }
}