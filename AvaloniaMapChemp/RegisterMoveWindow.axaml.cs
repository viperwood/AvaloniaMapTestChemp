using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaMapChemp;

public partial class RegisterMoveWindow : Window
{
    public RegisterMoveWindow()
    {
        InitializeComponent();
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