namespace LogoFX.Client.Testing.Contracts
{
    /// <summary>
    /// Represents helper for starting a client application.
    /// It should be implemented by concrete UI Automation library.
    /// </summary>
    public interface IStartApplicationHelper
    {
        /// <summary>
        /// Starts the application.
        /// </summary>
        /// <param name="startupPath">The startup path.</param>
        void StartApplication(string startupPath);
    }
}