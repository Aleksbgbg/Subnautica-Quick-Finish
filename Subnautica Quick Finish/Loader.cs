namespace Subnautica.Quick.Finish
{
    using UnityEngine;

    internal static class Loader
    {
        // Methods in this class are private as the injector does not
        // need public access to inject.
        // Methods are therefore less likely to be called by accident.

        private static GameObject hookTarget;

        private static void Load()
        {
            hookTarget = new GameObject();
            Object.DontDestroyOnLoad(hookTarget);

            hookTarget.AddComponent<Hook>();
        }

        // If the injector injects the DLL again, but calls the Unload
        // method instead, Mono will cache the DLL and call the Unload
        // method on the same code instance.
        // AssemblyVersion must stay the same between injections for
        // this to work.
        private static void Unload()
        {
            Object.Destroy(hookTarget);
        }
    }
}