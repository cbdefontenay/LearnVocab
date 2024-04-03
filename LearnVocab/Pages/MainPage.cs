namespace LearnVocab.Pages;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<BindableMainModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.Bottom)
                .RowDefinitions("Auto,*")
                .Children(
                    new NavigationBar()
                        .Content(() => vm.Title)
                        .MainCommandMode(MainCommandMode.Action)
                        .MainCommand(new AppBarButton()
                            .Icon(new BitmapIcon().UriSource(
                                    new Uri("ms-appx:///LearnVocab/Assets/Icons/hamburger.png")
                                )
                            )
                        ),
                    new StackPanel()
                        .Grid(row: 0)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center)
                        .Spacing(16)
                        .Children(
                            new TextBox()
                                .Text(x => x.Bind(() => vm.Name).Mode(BindingMode.TwoWay))
                                .PlaceholderText("Enter your names:"),
                            new Button()
                                .Content("Go to Second Page")
                                .AutomationProperties(automationId: "SecondPageButton")
                                .Command(() => vm.GoToSecond)
                        )
                )
            )
        );
    }
}
