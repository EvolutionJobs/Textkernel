namespace Evolution.Textkernel
{
    using Evolution.Textkernel.Models;
    using System.Threading.Tasks;

    /// <summary>Interface for Textkernel's CV Extract parser.</summary>
    public interface ITextkernelParser
    {
        /// <summary>Send the file bytes to the service and get back the deserialised result.</summary>
        /// <param name="file">The CV file to parse.</param>
        /// <param name="filename">Optional name of the file.</param>
        /// <returns>The deserialised result.</returns>
        Task<Profile> Parse(byte[] file, string filename = null);
    }
}