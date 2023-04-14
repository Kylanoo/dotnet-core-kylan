namespace dotnetkylan;


public class ArgumentNull
{


    public void ThrowIfNull(object? obj)
    {
        ArgumentNullException.ThrowIfNull(obj, nameof(obj));
    }
}
