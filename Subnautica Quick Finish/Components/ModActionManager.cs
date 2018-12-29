namespace Subnautica.Quick.Finish.Components
{
    using UnityEngine;

    internal class ModActionManager : MonoBehaviour
    {
        // Methods in this class are not static due
        // to potential future expansion with
        // instance fields.

        private NeptuneRocketConstructor _neptuneRocketConstructor;

        internal void BuildNeptuneLaunchPlatform()
        {
            GameObject neptuneLaunchPlatform = CraftData.InstantiateFromPrefab(TechType.RocketBase);
            neptuneLaunchPlatform.transform.position = MainCamera.camera.transform.position;
        }

        internal void BuildNeptuneRocketPiece()
        {
            _neptuneRocketConstructor.ConstructNextNeptuneRocketPiece();
        }

        internal void DisableQuarantineEnforcementProgram()
        {
            StoryGoalCustomEventHandler.main.DisableGun();
        }

        private void Awake()
        {
            _neptuneRocketConstructor = gameObject.AddComponent<NeptuneRocketConstructor>();
        }
    }
}