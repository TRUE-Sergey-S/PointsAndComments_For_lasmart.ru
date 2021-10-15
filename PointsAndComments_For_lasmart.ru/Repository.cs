using Microsoft.EntityFrameworkCore;
using PointsAndComments_For_lasmart.ru.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsAndComments_For_lasmart.ru.Views
{
    public class Repository:IRepository
    {
        private ApplicationContext db;
        public Repository(ApplicationContext context) {
            db = context;
        }

        public async Task<bool> DeletePointByID(int id)
        {
            var point = await db.Points.FirstOrDefaultAsync(i=>i.ID == id);
            if (point != null)
            {
                db.Points.Remove(point);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Point>> GetAllPoints() {

            var Points = await db.Points.ToListAsync();
            foreach (var item in Points)
            {
                item.Comments = await GetComments(item.ID);
            }
            return Points;
        }
        private async Task<List<Comment>> GetComments(int PointID){
            return await db.Comments.Where(i => i.PointID == PointID).ToListAsync();
        }
    }
}
