
namespace GitCredentialManager.Interop.Linux
{
    public class LinuxSystemPrompts : ISystemPrompts
    {
        public object ParentWindowId { get; set; }

        public bool ShowCredentialPrompt(string resource, string userName, out ICredential credential)
        {
            throw new System.NotImplementedException();
        }
    }
}