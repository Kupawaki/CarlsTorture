using MauiApp1.Models;
using System.Collections;

namespace MauiApp1;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();

        var one = new Person();
        var two = new Person("Carl", 32, true, ["Herpes", "Super Herpes"]);
        var three = new Person("Kasandra", 956, false, ["Herpes", "Super Herpes"]);
        var four = new Person("The Beekeeper", -2, true, ["Herpes", "Super Herpes"]);


        ArrayList people = new ArrayList();
        people.Add(one);
        people.Add(two);
        people.Add(three);
        people.Add(four);

        collection.ItemsSource = people;

		//Debug.WriteLine($"Instance One's Properties: {one.Name}, {one.Age}, {one.Gender}, {one.SexuallyTransmittedDiseases}");
        //Debug.WriteLine($"Instance Two's Properties: {two.Name}, {two.Age}, {two.Gender}, {two.SexuallyTransmittedDiseases}");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}