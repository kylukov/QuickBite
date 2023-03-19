namespace QuickBiteProd;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

public partial class MainPage : ContentPage
{
    int count = 0;

    public class Recipe
    {
        public string rTitle { get; set; }
        public Dictionary<string, string> rIngridients { get; set; }
        public Dictionary<string, string> rDescription { get; set; }
    }
    public MainPage()
    {
        InitializeComponent();


    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        string jsonString = "Json/products.json";
        Recipe recipe = JsonConvert.DeserializeObject<Recipe>(jsonString);

        Console.WriteLine(recipe.rTitle); // Борщ
        foreach (KeyValuePair<string, string> ingr in recipe.rIngridients)
        {
            Console.WriteLine(ingr.Key + ": " + ingr.Value); // Говяжья грудинка: 750 г, Говяжья вырезка: 300 г, ...
        }
        foreach (KeyValuePair<string, string> step in recipe.rDescription)
        {
            Console.WriteLine(step.Key + " " + step.Value);
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}

