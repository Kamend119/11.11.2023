using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Компоновка
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var margin = new Thickness(10);

            TextBox lengthTextBoxes1 = new TextBox() { Width = 50, Height = 30 };
            TextBox lengthTextBoxes2 = new TextBox() { Width = 50, Height = 30 };
            TextBox lengthTextBoxes3 = new TextBox() { Width = 50, Height = 30 };

            TextBox speedTextBoxes1 = new TextBox() { Width = 50, Height = 30 };
            TextBox speedTextBoxes2 = new TextBox() { Width = 50, Height = 30 };
            TextBox speedTextBoxes3 = new TextBox() { Width = 50, Height = 30 };

            Label lengthLabel1 = new Label() { Content = "Введите длину 1 пути", Width = 150, Height = 30 };
            Label lengthLabel2 = new Label() { Content = "Введите длину 2 пути", Width = 150, Height = 30 };
            Label lengthLabel3 = new Label() { Content = "Введите длину 3 пути", Width = 150, Height = 30 };

            Label speedLabel1 = new Label() { Content = "Введите скорость 1 пути", Width = 150, Height = 30 };
            Label speedLabel2 = new Label() { Content = "Введите скорость 2 пути", Width = 150, Height = 30 };
            Label speedLabel3 = new Label() { Content = "Введите скорость 3 пути", Width = 150, Height = 30 };

            Button CalculateButton = new Button { Content = "Посчитать", Width = 100, Height = 30, };

            CalculateButton.Click += (sender, args) =>
            {
                // Получение значений из текстовых полей
                double distance1 = double.Parse(lengthTextBoxes1.Text);
                double speed1 = double.Parse(speedTextBoxes1.Text);

                double distance2 = double.Parse(lengthTextBoxes2.Text);
                double speed2 = double.Parse(speedTextBoxes2.Text);

                double distance3 = double.Parse(lengthTextBoxes3.Text);
                double speed3 = double.Parse(speedTextBoxes3.Text);


                // Вычисление средней скорости
                double totalTime = distance1 / speed1 + distance2 / speed2 + distance3 / speed3;
                double totalDistance = distance1 + distance2 + distance3;
                double averageSpeed = totalDistance / totalTime;
              
                MessageBox.Show($"Средняя скорость автомобиля: {averageSpeed:F2} км/ч");
            };

            lengthTextBoxes1.Margin = margin;
            lengthTextBoxes2.Margin = margin;
            lengthTextBoxes3.Margin = margin;

            speedTextBoxes1.Margin = margin;
            speedTextBoxes2.Margin = margin;
            speedTextBoxes3.Margin = margin;

            lengthLabel1.Margin = margin;
            lengthLabel2.Margin = margin;
            lengthLabel3.Margin = margin;

            speedLabel1.Margin = margin;
            speedLabel2.Margin = margin;
            speedLabel3.Margin = margin;

            CalculateButton.Margin = margin;


            stackPanelHorizontal1.Children.Add(lengthLabel1);
            stackPanelHorizontal1.Children.Add(lengthTextBoxes1);
            stackPanelHorizontal1.Children.Add(speedLabel1);
            stackPanelHorizontal1.Children.Add(speedTextBoxes1);

            stackPanelHorizontal2.Children.Add(lengthLabel2);
            stackPanelHorizontal2.Children.Add(lengthTextBoxes2);
            stackPanelHorizontal2.Children.Add(speedLabel2);
            stackPanelHorizontal2.Children.Add(speedTextBoxes2);


            stackPanelHorizontal3.Children.Add(lengthLabel3);
            stackPanelHorizontal3.Children.Add(lengthTextBoxes3);
            stackPanelHorizontal3.Children.Add(speedLabel3);
            stackPanelHorizontal3.Children.Add(speedTextBoxes3);

            stackPanelHorizontal4.Children.Add(CalculateButton);
        }
    }
}
