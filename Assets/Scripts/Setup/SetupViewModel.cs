public class SetupViewModel : ViewModel
{
    public BindableProperty<string> Name = new BindableProperty<string>();
    public BindableProperty<string> Job = new BindableProperty<string>();
    public BindableProperty<int> ATK = new BindableProperty<int>();
    public BindableProperty<float> SuccessRate = new BindableProperty<float>();
    public BindableProperty<State> State = new BindableProperty<State>();

    public override void Init(Mode mode)
    {
        base.Init(mode);

        SetupModel setupModel = mode as SetupModel;

        Name.Value = setupModel.Name;
        Job.Value = setupModel.Job;
        ATK.Value = setupModel.ATK;
        SuccessRate.Value = setupModel.SuccessRate;
        State.Value = setupModel.State;
    }
}