namespace Wordle;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDecrementClicked(object sender, EventArgs e)
    {
        if (int.TryParse(WordLengthEntry.Text, out int wordLength) && wordLength > 4)
        {
            WordLengthEntry.Text = (wordLength - 1).ToString();
        }
    }

    private void OnIncrementClicked(object sender, EventArgs e)
    {
        if (int.TryParse(WordLengthEntry.Text, out int wordLength) && wordLength < 7)
        {
            WordLengthEntry.Text = (wordLength + 1).ToString();
        }
    }
}