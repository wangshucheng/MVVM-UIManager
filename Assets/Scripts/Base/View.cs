public interface IView
{
    ViewModel m_viewModel { get; set; }
}

public class View:MonoBehaviour,IView
{
    private ViewModel m_viewModel;
}