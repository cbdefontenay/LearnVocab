namespace LearnVocab.Presentation;

public sealed partial class Shell : UserControl, IContentControlProvider
{
    private readonly INavigator _navigator = null!;

    public Shell()
    {
        this.Content(
            new Grid()
                .Children(
                    new ExtendedSplashScreen()
                        .Assign(out var splash)
                    // new TabBar()
                    //     .Grid(row: 1)
                    //     .Style(StaticResource.Get<Style>("BottomTabBarStyle"))
                    //     .Items(
                    //         new TabBarItem().Content("Home")
                    //             .Command(ConfigureProperty)
                    //             .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle")),
                    //         new TabBarItem().Content("Second")
                    //             .Command(GoToSecondPage)
                    //             .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle")),
                    //         new TabBarItem().Content("Vocab")
                    //             .Command(GoToVocabPage)
                    //             .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle"))
                    //     )
                )
                .Background(Theme.Brushes.Background.Default)
        );
        ContentControl = splash;
    }

    private Task GoToVocabPage() => _navigator.NavigateViewAsync<FolderPage>(this);

    private async Task GoToSecondPage()
    {
        await _navigator.NavigateViewAsync<FolderPage>(this);
    }

    private async Task ConfigureProperty()
    {
        await _navigator.NavigateViewAsync<MainPage>(this);
    }

    public ContentControl ContentControl { get; }
}
