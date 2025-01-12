using System.Reflection;
using System.Text.Json;

namespace Wordle;

public partial class GamePage : ContentPage
{
    private List<string> words;
    
    public GamePage()
    {
        InitializeComponent();
        WordSizeLabel.Text = $"Word Size: none";
    }
}