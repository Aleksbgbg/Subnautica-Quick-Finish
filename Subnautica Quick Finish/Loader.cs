namespace Subnautica.Quick.Finish
{
    using UnityEngine;

    internal static class Loader
    {
        // Methods in this class are private as the injector does not
        // need public access to inject.
        // Methods are therefore less likely to be called by accident.

        private static void Load()
        {
            GameObject hookTarget = new GameObject();
            Object.DontDestroyOnLoad(hookTarget);
        }
    }
}