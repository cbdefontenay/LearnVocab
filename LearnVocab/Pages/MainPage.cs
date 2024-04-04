using ToolkitTheme = Uno.Toolkit.UI.Markup.Theme;

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
                .RowDefinitions("*,Auto")
                .Children(
                    new Grid()
                        .Region(attached: true, navigator: "Visibility"),
                    new TabBar()
                        .Grid(row: 1)
                        .Region(attached: true)
                        .Style(ToolkitTheme.TabBar.Styles.Bottom)
                        .Items(
                            new TabBarItem().Content("Home")
                                .Region(name: "Home"),
                            new TabBarItem().Content("Folder")
                                .Region(name: "Folder"),
                            new TabBarItem().Content("Vocab")
                                .Region(name: "Vocab")
                        )
                )
            )
        );
    }
}
