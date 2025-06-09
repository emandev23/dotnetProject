using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace BookShoppingCartMvcUI.Repositories;

[Authorize(Roles = nameof(Roles.Admin))]
public class ReportRepository : IReportRepository
{
    private readonly ApplicationDbContext _context;
    public ReportRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TopNSoldBookModel>> GetTopNSellingBooksByDate(DateTime startDate, DateTime endDate)
    {
        var startDateParam = new MySqlParameter("@startDate", startDate);
        var endDateParam = new MySqlParameter("@endDate", endDate);
        var topFiveSoldBooks = await _context.Database.SqlQueryRaw<TopNSoldBookModel>("CALL Usp_GetTopNSellingBooksByDate(@startDate,@endDate)", startDateParam, endDateParam).ToListAsync();
        return topFiveSoldBooks;
    }

}

public interface IReportRepository
{
    Task<IEnumerable<TopNSoldBookModel>> GetTopNSellingBooksByDate(DateTime startDate, DateTime endDate);
}