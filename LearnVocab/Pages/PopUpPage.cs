namespace LearnVocab.Pages;

public sealed partial class PopUpPage : UserControl
{
    public PopUpPage()
    {
        this.DataContext<BindablePopUpModel>((page, vm) => page
            .StatusBar
            (
                s => s
                    .Foreground(StatusBarForegroundTheme.Auto)
                    .Background(Theme.Brushes.Surface.Default)
            )
            .Resources
            (
                r => r
                    .Add("Icon_Arrow_Back",
                        "F1 M 16 7 L 3.8299999237060547 7 L 9.420000076293945 1.4099998474121094 L 8 0 L 0 8 L 8 16 L 9.40999984741211 14.59000015258789 L 3.8299999237060547 9 L 16 9 L 16 7 Z"
                    )
            )
            .Content(
                new AutoLayout()
                    .Children(new NavigationBar()
                            .MainCommandMode(MainCommandMode.Back)
                            .Content("Create a new Folder")
                            .MainCommand(
                                new AppBarButton()
                                    .Icon(
                                        new PathIcon()
                                            .Data(StaticResource.Get<Geometry>("Icon_Arrow_Back"))
                                            .Foreground(Theme.Brushes.OnSurface.Default)
                                    )
                            ),
                        new TextBlock()
                            .Margin(margin: new Thickness(0, 100, 0, 20))
                            .Text("New folder"),
                        new TextBox()
                            .PlaceholderText("Name of the folder")
                            .Text(x => x.Bind(() => vm.FolderName).Mode(BindingMode.TwoWay)
                            ),
                        new Button()
                            .Content("Save")
                            .Style(StaticResource.Get<Style>("ElevatedButtonStyle"))
                            .Command(() => vm.CreateNewFolder)
                    )
            )
        );
    }
}
