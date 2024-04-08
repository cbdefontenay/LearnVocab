namespace LearnVocab.ViewModels;

public partial record FolderModel
{
    private readonly INavigator _navigator;

    public FolderModel(INavigator navigator)
    {
        _navigator = navigator;
        Title = "Folder";
    }

    public string Title { get; set; }

    public IState<string> NewFolderName => State<string>.Value(this, () => "");

    public async Task CreateList()
    {
        await _navigator.NavigateViewModelAsync<PopUpModel>(this);
    }

    public async Task CreateFolder()
    {
        await NewFolderName.Update(f => f, CancellationToken.None);
    }
}
