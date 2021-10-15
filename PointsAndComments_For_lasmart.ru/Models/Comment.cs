
using System.Text.Json.Serialization;

namespace PointsAndComments_For_lasmart.ru.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; } //Текст комментария
        public string TextBackgroundColor { get; set; } //Цвет подложки комментария

        public int PointID { get; set; }
        [JsonIgnore]
        public Point Point { get; set; }
    }
}
