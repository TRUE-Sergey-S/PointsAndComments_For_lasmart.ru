using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PointsAndComments_For_lasmart.ru.Models;

namespace PointsAndComments_For_lasmart.ru
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>()))
            {
                // Проверка есть ли добавленные точки.
                if (context.Points.Any())
                {
                    return;
                }
                context.Points.AddRange(
                new Point
                {
                    ID = 1,
                    PositionX = 100,
                    PositionY = 15,
                    Radius = 10,
                    Color = "Grey"
                },
                new Point
                {
                    ID = 2,
                    PositionX = 300,
                    PositionY = 50,
                    Radius = 40,
                    Color = "Red"
                });

                context.Comments.AddRange(
                new Comment
                {
                    ID = 1,
                    Text = "Comment 1",
                    TextBackgroundColor = null,
                    PointID = 1
                },
                new Comment
                {
                    ID = 2,
                    Text = "Comment 2",
                    TextBackgroundColor = "Yellow",
                    PointID = 1
                },
                new Comment
                {
                    ID = 3,
                    Text = "Comment 3",
                    TextBackgroundColor = null,
                    PointID = 2
                },
                new Comment
                {
                    ID = 4,
                    Text = "Comment 4",
                    TextBackgroundColor = "Grey",
                    PointID = 2
                },
                new Comment
                {
                    ID = 5,
                    Text = "Comment 5",
                    TextBackgroundColor = null,
                    PointID = 2
                },
                new Comment
                {
                    ID = 6,
                    Text = "Comment 6 looooooooooooooooong comment",
                    TextBackgroundColor = "Yellow",
                    PointID = 2
                },
                new Comment
                {
                    ID = 7,
                    Text = "Comment 7",
                    TextBackgroundColor = "Grey",
                    PointID = 2
                },
                new Comment
                {
                    ID = 8,
                    Text = "Comment 8",
                    TextBackgroundColor = null,
                    PointID = 2
                }
                );
                context.SaveChanges();
            }
        }
    }
}
