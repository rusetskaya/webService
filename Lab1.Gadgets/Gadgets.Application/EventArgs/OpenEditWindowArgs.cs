namespace Gadgets.Application.EventArgs
{
    /// <summary>
    /// Action Type
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// Add a gadget
        /// </summary>
        Add,

        /// <summary>
        /// Edit gadget
        /// </summary>
        Edit
    }

    /// <summary>
    /// Open EditWindow arguments
    /// </summary>
    public class OpenEditWindowArgs
    {
        /// <summary>
        /// If <see cref="ActionType"/> is Edit, then the value for this property need to be provided
        /// </summary>
        public SelectedGadgetViewModel SelectedGadget { get; set; }

        public ActionType Type { get; set; }
    }
}