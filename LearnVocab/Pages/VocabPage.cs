namespace LearnVocab.Pages;

public sealed partial class VocabPage : Page
{
    public VocabPage()
    {
        this.DataContext<VocabModel>((page, vm) => page
            .Content(
                new Grid()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Children(
                        new TextBlock()
                            .Grid(row: 0)
                            .Text(() => vm.Name)
                    )
            )
        );
    }
}
