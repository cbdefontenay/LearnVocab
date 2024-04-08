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
                    // new StackPanel()
                    //     .Grid(row: 0)
                    //     .Margin(margin: new Thickness(0, 100))
                    //     .HorizontalAlignment(HorizontalAlignment.Center)
                    //     .VerticalAlignment(VerticalAlignment.Center)
                    //     .Spacing(16)
                    //     .Children(
                    //         new TextBox()
                    //             .Text(x => x.Bind(() => vm.Name).Mode(BindingMode.TwoWay)
                    //             )
                    //             .PlaceholderText("Enter your Folder name:"),
                    //         new Button()
                    //             .Content("Go to Folder Page")
                    //             .AutomationProperties(automationId: "SecondPageButton")
                    //             .Command(() => vm.GoToSecond)
                    //     )
                )
            )
        );
    }
}
