namespace LearnVocab.ViewModels;

public partial record FolderModel(INavigator Navigator, Vocab NewVocab)
{
    public string Title { get; set; } = "Folder";
    public  string Label { get; set; } = "Create List";

    public IState<string> NewFolderName => State<string>.Value(this, () => string.Empty);

    public async Task CreateList()
    {
        await Navigator.NavigateViewModelAsync<PopUpModel>(this, qualifier: Qualifiers.ClearBackStack);
    }

    public async Task CreateFolder()
    {
        await NewFolderName.Update(f => f, CancellationToken.None);
    }
}
