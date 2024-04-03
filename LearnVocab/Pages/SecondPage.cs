namespace LearnVocab.Pages;

public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        this.DataContext<BindableSecondModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.All)
                .Children(
                    new NavigationBar()
                        .Content(() => vm.Title)
                        .MainCommand(new AppBarButton()
                            .Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///LearnVocab/Assets/Icons/back.png")
                                )
                            )
                        ),
                    new TextBlock()
                        .Text(() => vm.Vocab.Name)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center),
                    new TextBlock()
                        .Text("2 PAGE")
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center),
                    new TextBlock()
                        .Text("To be added...")
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center)
                )
            )
        );
    }
}
