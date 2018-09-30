namespace LogoFX.Client.Testing.Contracts
{
    //TODO: Move to Attest.
    /// <summary>
    /// This service encapsulates functionality which is called when the test/scenario starts.
    /// </summary>
    public interface ISetupService
    {
        /// <summary>
        /// Setups this instance.
        /// </summary>
        void Setup();
    }
}