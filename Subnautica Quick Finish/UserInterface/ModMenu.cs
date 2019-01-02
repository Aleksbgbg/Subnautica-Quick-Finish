namespace Subnautica.Quick.Finish.UserInterface
{
    using System;

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

            Button
            (
                "Build Neptune Launch Platform",
                ref currentControlRectangle,
                _modActionManager.BuildNeptuneLaunchPlatform
            );
            Button
            (
                "Build Neptune Rocket Piece",
                ref currentControlRectangle,
                _modActionManager.BuildNeptuneRocketPiece
            );
            Button
            (
                "Disable Quarantine Enforcement Platform",
                ref currentControlRectangle,
                _modActionManager.DisableQuarantineEnforcementPlatform
            );
        }

        private static void Button(string text, ref Rect currentControlRectangle, Action action)
        {
            if (GUI.Button(currentControlRectangle, text))
            {
                action();
            }

            currentControlRectangle.y += DefaultControlHeight + InterControlDistance;
        }
    }
}