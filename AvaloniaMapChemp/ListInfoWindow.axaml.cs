using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Newtonsoft.Json;

namespace AvaloniaMapChemp;

public partial class ListInfoWindow : Window
{
    public ListInfoWindow()
    {
        InitializeComponent();
        Info();
    }

    /// <summary>
    /// получение информации из апи и вывод информации в лист
    /// </summary>
    private async Task Info()
    {
        using (var client = new HttpClient())
        {
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:5298/api/GetTriger/GetInfoTriger");
            string content = await responseMessage.Content.ReadAsStringAsync();
            List<Triger> context = JsonConvert.DeserializeObject<List<Triger>>(content)!.ToList();
            ListBoxInfo.ItemsSource = context.Select(x => new
            {
                LastSecurityPointTimeText = x.Lastsecuritypointtime,
                LastSecurityPointDirectionText = x.Lastsecuritypointdirection,
                PersonRoleText = x.Personrole,
                LastSecurityPointNumberText = x.Lastsecuritypointnumber,
                PersonCodeText = x.Personcode,
                IdText = x.Id
            }).ToList();
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


/// <summary>
/// Модель получаемой информации из апи
/// </summary>
public class Triger
{
    public int Id { get; set; }

    public int? Personcode { get; set; }

    public string? Personrole { get; set; }

    public string? Lastsecuritypointnumber { get; set; }

    public string? Lastsecuritypointdirection { get; set; }

    public DateTime? Lastsecuritypointtime { get; set; }
}