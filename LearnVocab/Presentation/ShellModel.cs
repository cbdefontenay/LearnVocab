namespace LearnVocab.Presentation;

public partial class ShellModel
{
    private readonly INavigator _navigator;

    public ShellModel(
        INavigator navigator)
    {
        _navigator = navigator;
        _ = Start();
    }

    public async Task GoToMainPage()
    {
        await _navigator.NavigateViewAsync<MainPage>(this);
    }

    public async Task GoToSecondPage()
    {
        await _navigator.NavigateViewAsync<SecondPage>(this);
    }

    public async Task GoToVocabPage()
    {
        await _navigator.NavigateViewAsync<VocabPage>(this);
    }

    public async Task Start()
    {
        await _navigator.NavigateViewModelAsync<MainModel>(this);
    }
}
