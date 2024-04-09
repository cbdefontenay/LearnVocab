namespace LearnVocab.ViewModels;

public partial record PopUpModel
{
    private readonly INavigator _navigator;

    public PopUpModel(INavigator navigator)
    {
        _navigator = navigator;
    }

    public IState<string> FolderName => State<string>.Value(this, () => "");

    public async Task CreateNewFolder()
    {
        var newFolder = await FolderName;
        await _navigator.NavigateViewModelAsync<FolderModel>(this, data: new Vocab(newFolder!));
    }


    public async Task GoBackToFolderPage()
    {
        await _navigator.NavigateBackAsync(this);
    }
}
