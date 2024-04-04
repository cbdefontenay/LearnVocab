namespace LearnVocab.Pages;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<BindableMainModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Content(new Grid()
                .Region(attached: true)
                .SafeArea(SafeArea.InsetMask.None)
                .RowDefinitions("Auto,*")
                .Children(
                    new NavigationBar()
                        .Content(() => vm.Title)
                        .MainCommand(new AppBarButton()
                            .Icon(new BitmapIcon().UriSource(
                                    new Uri("ms-appx:///LearnVocab/Assets/Icons/home.png")
                                )
                            )
                        ),
                    new StackPanel()
                        .Grid(row: 0)
                        .Margin(margin: new Thickness(0, 100))
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center)
                        .Spacing(16)
                        .Children(
                            new TextBox()
                                .Text(x => x.Bind(() => vm.Name).Mode(BindingMode.TwoWay)
                                )
                                .PlaceholderText("Enter your Folder name:"),
                            new Button()
                                .Content("Go to Folder Page")
                                .AutomationProperties(automationId: "SecondPageButton")
                                .Command(() => vm.GoToSecond)
                        ),
                    new TabBar()
                        .Grid(row: 1)
                        .Region(attached: true)
                        .Style(StaticResource.Get<Style>("BottomTabBarStyle"))
                        .Items(
                            new TabBarItem().Content("Home")
                                .Region().Name("Main")
                                .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle")),
                            new TabBarItem().Content("Folder")
                                .Region().Name("Folder")
                                .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle")),
                            new TabBarItem().Content("Vocab")
                                .Region().Name("Vocab")
                                .Style(StaticResource.Get<Style>("MaterialBottomTabBarItemStyle")
                                )
                        )
                )
            )
        );
    }
}
