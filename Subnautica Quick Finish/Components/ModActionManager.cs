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