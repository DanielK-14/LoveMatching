namespace Logic
{
    /// <summary>
    /// Part of the Strategy Pattern
    /// The Strategy interface which is needed to be implented to filter our input.
    /// </summary>
    public interface IFilterStrategy
    {
        bool DoFilterOnFriends(Request i_Request);
    }
}
