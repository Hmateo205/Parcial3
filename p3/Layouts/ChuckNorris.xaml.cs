using Newtonsoft.Json;
using p3.Models;
using p3.Services;
using System.Diagnostics;

namespace p3.Layouts;

public partial class ChuckNorris : ContentPage
{
    public List<ChuckInfo> list_pokemon;
    public ChuckNorris()
    {

        InitializeComponent();
        LoadData();


    }

    public async void LoadData()
    {
        Chuck Chuck_apis = new Chuck();
        list__Chuck = await Chuck_apis.DevuelveListadoPokemones();
        Debug.WriteLine("ola");
        Debug.WriteLine(JsonConvert.SerializeObject(list_pokemon));

        ChuckNorris. = list_Chuck;
    }
    public void MuestraResumenPokemon(object sender, SelectedItemChangedEventArgs e)
    {
        PokemonInfo poke_info = (PokemonInfo)e.SelectedItem;
        Navigation.PushAsync(new ResumenPokemon(poke_info.url));
    }


}
