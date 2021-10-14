using PointsAndComments_For_lasmart.ru.Models;
using System;
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
        public List<Point> GetAllPoints() {

            var Points = db.Points.ToList();
            foreach (var item in Points)
            {
                item.Comments = GetComments(item.ID);
            }
            return Points;
        }
        private List<Comment> GetComments(int PointID){
            return db.Comments.Where(i => i.PointID == PointID).ToList();
        }
    }
}
