using VerifyTests;

namespace OpenMacroBoard.Meta.TestUtils.VerifyStuff
{
    public static class DefaultVerifySettings
    {
        static DefaultVerifySettings()
        {
            VerifyImageSharp.Initialize();
        }

        public static ExtendedVerifySettings Build(bool autoVerify = false)
        {
            return new ExtendedVerifySettings
            {
                Directory = "VerifiedSnapshots",
                AutoVerify = autoVerify,
            };
        }
    }
}
