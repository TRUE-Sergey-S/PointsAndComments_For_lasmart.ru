using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAndComments_For_lasmart.ru.Models
{
    public interface IRepository
    {
        Task<List<Point>> GetAllPoints();
        Task<bool> DeletePointByID(int id);
    }
}
