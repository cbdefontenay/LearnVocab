using Uno.Toolkit.UI.Material.Markup;

namespace LearnVocab;

public sealed class AppResources : ResourceDictionary
{
    public AppResources()
    {
        // Load WinUI Resources
        this.Build(r => r.Merged(
                new XamlControlsResources()
            )
        );

        // Load Uno.UI.Toolkit and Material Resources
        this.Build(r => r.Merged(
                new MaterialToolkitTheme(
                    new Styles.ColorPaletteOverride(),
                    new Styles.MaterialFontsOverride()
                )
            )
        );
        this.Build(r => r.UseMaterialToolkit(
            new Styles.ColorPaletteOverride(),
            new Styles.MaterialFontsOverride()
        ));
    }
}
