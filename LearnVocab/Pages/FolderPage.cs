namespace LearnVocab.Pages;

public sealed partial class FolderPage : Page
{
    public FolderPage()
    {
        this.DataContext<BindableFolderModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Background(Theme.Brushes.Secondary.Container.Default)
            .SafeArea(SafeArea.InsetMask.None)
            .Content(
                new AutoLayout()
                    .SafeArea(SafeArea.InsetMask.All)
                    .Orientation(Orientation.Vertical)
                    .Children(
                        new NavigationBar()
                            .Margin(new Thickness(0, 0, 0, 10))
                            .Content(() => vm.Title)
                            .MainCommand(new AppBarButton()
                                .Icon(new BitmapIcon()
                                    .UriSource(new Uri("ms-appx:///LearnVocab/Assets/Icons/home.svg")
                                    )
                                )
                            )
                            .SecondaryCommands(new AppBarButton().Label("Create Folder"),
                                new AppBarButton()
                                    .Label(() => vm.Label)
                                    .Command(() => vm.CreateList)
                            ),
                        new AutoLayout()
                            .Children(
                                new TextBlock()
                                    .Margin(margin: new Thickness(0, 100, 0, 0))
                                    .Text(() => vm.NewVocab.NewVocab)
                            )
                    )
            )
        );
    }
}
