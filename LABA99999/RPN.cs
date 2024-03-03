using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA8
{
    static class RPN
    {
        static bool IsDraw = false;
        public static string name { get; set; }
        public static string picture { get; set; }

        public static string nameout = "";

        public static string expressionstring = "";
        public static bool CalculateRPN(string expression)
        {
            expressionstring = expression;
            Stack<int> operandsStack = new Stack<int>();

            string number = "";
            

            foreach (char arrElement in expression)
            {
                //MessageBox.Show($"Текущий символ: {arrElement}, number: {number}, nameout: {nameout}");
                if (char.IsDigit(arrElement))
                {
                    number += arrElement; // Добавляем символ к числу
                }
                else if (IsOperator(arrElement.ToString()))
                {
                    if (!ApplyOperation(operandsStack, arrElement.ToString()))
                    {
                        return false;
                    }
                }
                else if (arrElement.ToString() == "+" && number != "")
                {
                   operandsStack.Push(int.Parse(number));
                   number = "";
                }
                else
                {
                    if (arrElement != '+')
                        nameout += arrElement;
                }
            }
            MessageBox.Show("Вы нарисовали: " + nameout);
            nameout = "";
            return true;
        }

        private static bool IsOperator(string c)
        {
            return c == "S" || c == "M" || c == "D";
        }

        public static bool ApplyOperation(Stack<int> operands, string c)
        {
            
                
            if (c == "S" && operands.Count == 3)
            {
                Square square = new Square(nameout, operands.Pop(), operands.Pop(), operands.Pop(), 0);
                MessageBox.Show("Все пока норм!");
                
                square.Draw();
                square.AddContainerL9(nameout);

            }
            else if (c == "D") 
            {
                
                MessageBox.Show("Оператор D!");
                string figureName = nameout;
                // Вызываем метод удаления фигуры из контейнера
                ShapeContainer.RemoveByName(figureName);
                IsDraw = false; 
                return true;
            } 
            else
            {
                return false;
            }
            return true;

        }


    }
}
