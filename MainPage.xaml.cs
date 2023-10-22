using testapp.Data;

namespace testapp;

public partial class MainPage : ContentPage
{
    public readonly DatabaseContext dbContext;
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

        var users = dbContext.SecurityAuthentications
                              .ToList();

        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

