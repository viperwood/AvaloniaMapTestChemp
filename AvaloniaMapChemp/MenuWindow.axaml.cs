using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaMapChemp;

public partial class MenuWindow : Window
{
    public MenuWindow()
    {
        InitializeComponent();
    }
    /// <summary>
    /// кнопка перехода на страницу отслеживания людей по карте
    /// </summary>
    private void Map1Click(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
    /// <summary>
    /// кнопка перехода на страницу отслеживания регистрации движения пациентов по стационару и занятость коечного фонда
    /// </summary>
    private void Map2Click(object? sender, RoutedEventArgs e)
    {
        RegisterMoveWindow registerMoveWindow = new RegisterMoveWindow();
        registerMoveWindow.Show();
        Close();
    }
    /// <summary>
    /// кнопка перехода на страницу списока людей прошедших в закрытые помещения
    /// </summary>
    private void ListClick(object? sender, RoutedEventArgs e)
    {
        ListInfoWindow listInfoWindow = new ListInfoWindow();
        listInfoWindow.Show();
        Close();
    }
}