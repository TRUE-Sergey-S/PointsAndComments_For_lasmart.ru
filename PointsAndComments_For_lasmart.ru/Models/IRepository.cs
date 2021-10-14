using System.Collections.Generic;

namespace PointsAndComments_For_lasmart.ru.Models
{
    public interface IRepository
    {
        List<Point> GetAllPoints();
    }
}
