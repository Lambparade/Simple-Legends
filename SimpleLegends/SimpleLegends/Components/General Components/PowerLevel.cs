namespace SimpleLegends.Components.General_Components
{
    public class Rating : Component
    {
        //BasePower Level can between 0 - 10. 
        public int BasePowerLevel;

        public int PowerLevelModifier{get;set;} = 0;

        public Rating(int AssignedPowerLevel)
        {
            BasePowerLevel = AssignedPowerLevel;
        }
    }
}