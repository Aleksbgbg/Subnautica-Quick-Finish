namespace Subnautica.Quick.Finish.UserInterface
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Subnautica.Quick.Finish.Components;

    using UnityEngine;

    internal class ModMenu : MonoBehaviour
    {
        private const float HorizontalMargin = 5f;

        private const float DefaultControlHeight = 20f;

        private const float InterControlDistance = 5f;

        private readonly Rect _backgroundRectangle = new Rect(50f, 50f, 300f, 250f);

        private readonly Dictionary<string, Action> _buttonsTextActionMap;

        private ModActionManager _modActionManager;

        internal ModMenu()
        {
            _buttonsTextActionMap = new Dictionary<string, Action>
            {
                ["Build Neptune Launch Platform"] = _modActionManager.BuildNeptuneLaunchPlatform,
                ["Built Neptune Rocket Piece"] = _modActionManager.BuildNeptuneRocketPiece,
                ["Disable Quarantine Enforcement Platform"] = _modActionManager.DisableQuarantineEnforcementPlatform
            };
        }

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

            ButtonArray(_buttonsTextActionMap, ref currentControlRectangle);
        }

        private static void ButtonArray(IDictionary<string, Action> textActionMap, ref Rect currentControlRectangle)
        {
            foreach (KeyValuePair<string, Action> textActionPair in textActionMap)
            {
                if (GUI.Button(currentControlRectangle, textActionPair.Key))
                {
                    textActionPair.Value();
                }

                currentControlRectangle.y += DefaultControlHeight + InterControlDistance;
            }
        }
    }
}