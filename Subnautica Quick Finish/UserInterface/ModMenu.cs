namespace Subnautica.Quick.Finish.UserInterface
{
    using Subnautica.Quick.Finish.Components;

    using UnityEngine;

    internal class ModMenu : MonoBehaviour
    {
        private const float HorizontalMargin = 5f;

        private const float DefaultControlHeight = 20f;

        private const float InterControlDistance = 5f;

        private readonly Rect _backgroundRectangle = new Rect(50f, 50f, 300f, 250f);

        private ModActionManager _modActionManager;

        private void Awake()
        {
            _modActionManager = gameObject.AddComponent<ModActionManager>();
        }

        private void OnGUI()
        {
            GUI.Box(_backgroundRectangle, "Subnautica Quick Finish by Aleksbgbg");

            Rect currentControlRectangle = new Rect
            (
                _backgroundRectangle.x + HorizontalMargin,
                // Label at top of mod menu needs to be accounted for
                _backgroundRectangle.y + DefaultControlHeight + InterControlDistance,
                _backgroundRectangle.width - (HorizontalMargin * 2),
                DefaultControlHeight
            );

            if (GUI.Button(ConsumeCurrentControlRectangle(ref currentControlRectangle), "Build Neptune Launch Platform"))
            {
                _modActionManager.BuildNeptuneLaunchPlatform();
            }

            if (GUI.Button(ConsumeCurrentControlRectangle(ref currentControlRectangle), "Build Neptune Rocket Piece"))
            {
                _modActionManager.BuildNeptuneRocketPiece();
            }

            if (GUI.Button(ConsumeCurrentControlRectangle(ref currentControlRectangle), "Disable Quarantine Enforcement Platform"))
            {
                _modActionManager.DisableQuarantineEnforcementProgram();
            }
        }

        private static Rect ConsumeCurrentControlRectangle(ref Rect currentControlRectangle)
        {
            Rect originalCurrentControlRectangle = currentControlRectangle;

            currentControlRectangle.y += DefaultControlHeight + InterControlDistance;

            return originalCurrentControlRectangle;
        }
    }
}