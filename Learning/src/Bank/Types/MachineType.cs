namespace Bank.Types;

public interface MachineType
{
    public static sbyte TYPE_RETRAIT = 1;
    public static sbyte TYPE_DEPOT = 2;
    
    /**
     * Get the action_type according to the 'choice'
     */
    public int GetActionType(string choice)
    {
        if (choice.ToLower() == "retrait")
            return MachineType.TYPE_RETRAIT;

        return MachineType.TYPE_DEPOT;
    }
}