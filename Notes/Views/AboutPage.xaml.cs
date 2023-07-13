namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
        //BindingContext = new Models.About();
	}

    /*private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        //Models.About about;
        //if (BindingContext.GetType().Equals(typeof(Models.About)))
        //{
        //    about = (Models.About)BindingContext;
        //    await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        //}

        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }*/
}