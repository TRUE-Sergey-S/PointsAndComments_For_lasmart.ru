using System.Collections.Generic;

namespace PointsAndComments_For_lasmart.ru.Models
{
    public class Point
    {
        public int ID { get; set; }
        public int PositionX { get; set; } //Положение по x
        public int PositionY { get; set; } //Положение по y
        public int Radius { get; set; } //Радиус
        public string Color { get; set; } //Цвет
        public List<Comment> Comments { get; set; } //Список комментариев

    }
}
