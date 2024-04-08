namespace LearnVocab.ViewModels;

public partial record MainModel
{
    private readonly INavigator _navigator;
    public string _firstTabPage;
    public string _secondTabPage;
    public string _thirdTabPage;
    public string _fourthTabPage;

    public MainModel(
        INavigator navigator)
    {
        _navigator = navigator;
        _firstTabPage = "Home";
        _secondTabPage = "Folder";
        _thirdTabPage = "Vocab";
        _fourthTabPage = "Settings";
    }
}
