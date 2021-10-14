
namespace PointsAndComments_For_lasmart.ru.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; } //Текст комментария
        public string TextBackgroundColor { get; set; } //Цвет подложки комментария

        public int PointID { get; set; }
        public Point Point { get; set; }
    }
}
