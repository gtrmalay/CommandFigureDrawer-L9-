using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8
{
    class ShapeContainer
    {
        static string FigName;
        public static List<Figure> figureList;
        public static bool IsSuccess { get; set; } = false;
        

        static ShapeContainer()
        {
            figureList = new List<Figure>();
        }

        public static void AddFigure(Figure figure, ComboBox combobox1)
        {
            figureList.Add(figure);
            combobox1.Items.Add(figure);
        }

        public static void AddFigureL9(Figure figure, string name)
        {
            MessageBox.Show("Метод AddFigure");
            figureList.Add(figure);
            figure.figureName = name;
            IsSuccess = true;
            foreach (Figure c in figureList)
            {
                MessageBox.Show($"Имя фигуры: {figure.figureName}");
                // Здесь можно вывести другую информацию о фигуре, если она доступна
            }
            IsSuccess = false;

        }



        static public void RemoveByName(string name)
        {
            MessageBox.Show("Дошло до метода RemoveByName ");
            
            for (int i = 0; i < figureList.Count; i++)
            {
                // Если имя фигуры совпадает с искомым именем
                if (figureList[i].figureName == name)
                {
                    MessageBox.Show("RemoveByName условие выполнено!");
                    // Удаляем фигуру из списка
                    figureList.RemoveAt(i);
                    Graphics g = Graphics.FromImage(Init.bitmap);
                    g.Clear(Color.White);
                    Init.pictureBox.Image = Init.bitmap;
                    // Прерываем цикл, так как фигура уже удалена
                    IsSuccess = true;
                    break;
                }
            }
            // После удаления фигуры нужно перерисовать все оставшиеся фигуры
            DrawAllShapes();

        }

        public static void DrawAllShapes()
        {
            
            Bitmap clearBitmap = new Bitmap(Init.pictureBox.ClientSize.Width, Init.pictureBox.ClientSize.Height);
            Graphics clearGraphics = Graphics.FromImage(clearBitmap);

            foreach (Figure figure in figureList)
            {
                figure.Draw(); 
            }

           
            
        }






    }
}
