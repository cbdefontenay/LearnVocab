namespace LearnVocab.ViewModels;

public partial record HomeModel
{
    private readonly INavigator _navigator;

    public HomeModel(
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Home";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToMainPage()
    {
        await _navigator.NavigateViewAsync<HomePage>(this);
    }

    public async Task GoToSecond()
    {
        var name = await Name;
        await _navigator.NavigateViewModelAsync<FolderModel>(this, data: new Vocab(name!));
    }
}
