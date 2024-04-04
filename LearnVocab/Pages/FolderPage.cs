namespace LearnVocab.Pages;

public sealed partial class FolderPage : Page
{
    public FolderPage()
    {
        this.DataContext<BindableFolderModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Background(Theme.Brushes.Background.Default)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.None)
                .RowDefinitions("Auto")
                .Children(
                    new NavigationBar()
                        .Content(() => vm.Title)
                        .MainCommand(new AppBarButton()
                            .Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///LearnVocab/Assets/Icons/back.png")
                                )
                            )
                        ),
                    new AutoLayout()
                        .Children(
                            new Card()
                                .Margin(margin: new Thickness(0, 200, 0, 0))
                                .HorizontalAlignment(HorizontalAlignment.Center)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .Grid(0)
                                .HeaderContent(() => vm.Vocab.Name)
                                .Style(StaticResource.Get<Style>("OutlinedCardStyle")),
                            new Button()
                                .HorizontalAlignment(HorizontalAlignment.Left)
                                .VerticalAlignment(VerticalAlignment.Bottom)
                                .Grid(2)
                                .CanDrag(true)
                                .Style(StaticResource.Get<Style>("FabStyle"))
                                .ControlExtensions(
                                    icon: new BitmapIcon().UriSource(
                                        new Uri("ms-appx:///LearnVocab/Assets/Icons/add.png")
                                    )
                                )
                        )
                )
            )
        );
    }
}
