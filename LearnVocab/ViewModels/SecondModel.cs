namespace LearnVocab.ViewModels;

public partial record SecondModel(Vocab Vocab)
{
    public string Title { get; } = "Vocab";
}
