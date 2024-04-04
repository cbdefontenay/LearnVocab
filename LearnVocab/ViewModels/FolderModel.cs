namespace LearnVocab.ViewModels;

public partial record FolderModel(Vocab Vocab, INavigator Navigator)
{
    public string Title { get; } = "Folder Page";
    public INavigator Navigator = Navigator;
    
}
