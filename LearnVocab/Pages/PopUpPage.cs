namespace LearnVocab.Pages;

public sealed partial class PopUpPage : Page
{
    public PopUpPage()
    {
        this.DataContext<BindablePopUpModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Content(
                new AutoLayout()
                    .Children(new NavigationBar()
                            .Content("Create a new Folder")
                            .MainCommand(
                                new AppBarButton()
                                    .Icon(
                                        new BitmapIcon()
                                            .UriSource(
                                                new Uri("ms-appx:///LearnVocab/Assets/Icons/back.png")
                                            )
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
                            .Command(() => vm.GoBackToFolderPage)
                    )
            )
        );
    }
}
