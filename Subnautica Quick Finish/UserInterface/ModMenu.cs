namespace Subnautica.Quick.Finish.UserInterface
{
    using UnityEngine;

    internal class ModMenu : MonoBehaviour
    {
        private readonly Rect _backgroundRectangle = new Rect(50f, 50f, 300f, 250f);

        private void OnGUI()
        {
            GUI.Box(_backgroundRectangle, "Subnautica Quick Finish by Aleksbgbg");
        }
    }
}