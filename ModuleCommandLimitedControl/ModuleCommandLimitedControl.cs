using CommNet;

namespace ModuleCommandLimitedControl
{
    public class ModuleCommandLimitedControl : ModuleCommand
    {
        public override VesselControlState UpdateControlSourceState()
        {
            VesselControlState baseState = base.UpdateControlSourceState();
            if (baseState == VesselControlState.ProbeFull)
            {
                moduleState = ModuleControlState.PartialProbe;
                return VesselControlState.ProbePartial;
            }
            return baseState;
        }
    }
}