namespace LearnVocab.Pages;

public sealed partial class HomePage : Page
{
    public HomePage()
    {
        this.DataContext<BindableHomeModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Content(new Grid()
                .Region(attached: true)
                .SafeArea(SafeArea.InsetMask.None)
                .RowDefinitions("Auto,*")
                .Children(
                    new NavigationBar()
                        .Content(() => vm.Title)
                        .MainCommand(
                            new AppBarButton()
                                .Icon(
                                    new BitmapIcon()
                                        .UriSource(
                                            new Uri("ms-appx:///LearnVocab/Assets/Icons/home.png")
                                        )
                                )
                        )
                )
            )
        );
    }
}
