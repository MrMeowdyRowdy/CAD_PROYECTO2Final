using Newtonsoft.Json;
using System.Net;
using CAD_PROYECTO2.APIs;
using CAD_PROYECTO2.Models;

namespace CAD_PROYECTO2.Anonimo;

public partial class AMainPage : ContentPage
{
	

	public AMainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Anonimo.ASobreNosotros));
    }



    private async void Servicios_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Anonimo.AServicios));
    }

    private async void Add_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.LoginPage));
    }

    private void Registro_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Views.RegisterPage));
    }

    private async void Frase_and_Image(object sender, EventArgs e)
    {
        WebRequest request = WebRequest.Create("https://quotes.rest/qod?category=inspire");
        request.Headers.Add("X-TheySaidSo-Api-Secret", "YOUR API KEY HERE");
        WebResponse response = request.GetResponse();
        var client = new HttpClient();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            responseFromServer = responseFromServer.Trim();
            var resultado = JsonConvert.DeserializeObject<Root>(responseFromServer);             // Display the content.
            Frase.Text = resultado.contents.quotes[0].quote + "\n" + resultado.contents.quotes[0].author + "\b" + resultado.contents.quotes[0].date;
        }

        WebRequest request1 = WebRequest.Create("https://api.nasa.gov/planetary/apod?api_key=InIjmwfPPCOCXb6Fz8YegV6ote0YEu74yo2jTFg4");
        request1.Headers.Add("Accept", "application/json");
        WebResponse response1 = request1.GetResponse();
        var client1 = new HttpClient();
        using (Stream dataStream = response1.GetResponseStream())
        {
            StreamReader reader1 = new StreamReader(dataStream);
            string responseFromServer1 = reader1.ReadToEnd();
            responseFromServer1 = responseFromServer1.Trim();
            var resultado1 = JsonConvert.DeserializeObject<GetNasa>(responseFromServer1);
            imageNasa.Source = resultado1.url;
        }
    }
}

