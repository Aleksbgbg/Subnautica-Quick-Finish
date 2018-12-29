namespace Subnautica.Quick.Finish
{
    using Subnautica.Quick.Finish.UserInterface;

    using UnityEngine;

    internal class Hook : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.AddComponent<ModMenu>();
        }
    }
}