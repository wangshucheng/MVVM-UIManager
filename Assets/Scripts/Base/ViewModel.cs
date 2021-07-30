public interface IViewModel
{
    void Init(Model model);
}

public class ViewModel:IViewModel
{
    public BindableProperty<int> Id = new BindableProperty<int>();

    public virtual void Init(Model model)
    {

    }
}