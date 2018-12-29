namespace Subnautica.Quick.Finish.Components
{
    using UnityEngine;

    internal class ModActionManager : MonoBehaviour
    {
        // Methods in this class are not static due
        // to potential future expansion with
        // instance fields.

        internal void BuildNeptuneLaunchPlatform()
        {
            GameObject neptuneLaunchPlatform = CraftData.InstantiateFromPrefab(TechType.RocketBase);
            neptuneLaunchPlatform.transform.position = MainCamera.camera.transform.position;
        }

        internal void BuildNeptuneRocketPiece()
        {

        }

        internal void DisableQuarantineEnforcementProgram()
        {
            StoryGoalCustomEventHandler.main.DisableGun();
        }
    }
}