public class SetupView:View
{
    public Text nameMessageText;

    void Awake()
    {
        m_viewModel = new SetupViewModel();

        m_viewModel.Name.OnValueChanged += NameValueChanged;

        
    }

    void Start()
    {
        m_viewModel.Name.Value = "";
    }

    private void NameValueChanged(string oldvalue, string newvalue)
    {
        nameMessageText.text = newvalue.ToString();
    }

    void Destory()
    {
        m_viewModel.Name.OnValueChanged -= NameValueChanged;
    }
}