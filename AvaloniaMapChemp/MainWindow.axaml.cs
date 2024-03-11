using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Threading;

namespace AvaloniaMapChemp;

public partial class MainWindow : Window
{
    private IImmutableSolidColorBrush _color;
    private DispatcherTimer timer = new DispatcherTimer();
    public MainWindow()
    {
        InitializeComponent();
        //Таймер, срабатывает каждые 3 секунды
        timer.Interval = TimeSpan.FromSeconds(3);
        timer.Tick += RandomTick;
        timer.Start();
    }
    /// <summary>
    /// Рандомный выбор перемещения людей
    /// </summary>
    private void RandomTick(object? sender, EventArgs e)
    {
        //
        RandomZnach();
        Ellipse1.Fill = _color;
        RandomZnach();
        Ellipse2.Fill = _color;
        RandomZnach();
        Ellipse3.Fill = _color;
        RandomZnach();
        Ellipse4.Fill = _color;
        RandomZnach();
        Ellipse5.Fill = _color;
        RandomZnach();
        Ellipse6.Fill = _color;
        
    }
    /// <summary>
    /// Рандомайзер цветов
    /// </summary>
    private void RandomZnach()
    {
        Random random = new Random();
        int rand = random.Next(1, 100);
        if (rand > 50)
        {
            _color = Brushes.Blue;
        }
        else if (rand > 21 && rand < 51)
        {
            _color = Brushes.Green;
        }
        else
        {
            _color = Brushes.Transparent;
        }
        
    }

    /// <summary>
    /// Кнопка выхода в меню
    /// </summary>
    private void BeackButton(object? sender, RoutedEventArgs e)
    {
        MenuWindow menuWindow = new MenuWindow();
        menuWindow.Show();
        Close();
    }
}