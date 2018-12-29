namespace Subnautica.Quick.Finish.Components
{
    using UnityEngine;

    internal class NeptuneRocketConstructor : MonoBehaviour
    {
        private RocketConstructor _rocketConstructor;

        internal void ConstructNextNeptuneRocketPiece()
        {
            if (_rocketConstructor == null)
            {
                // Global search call required as RocketConstructor host is unknown.
                // TODO: Optimise with GetComponent call on known host object.
                _rocketConstructor = FindObjectOfType<RocketConstructor>();

                // In case the user ran the script
                // before the Neptune Launch Platform
                // was built.
                if (_rocketConstructor == null)
                {
                    return;
                }
            }

            // Successive calls to StartRocketConstruction
            // will actually advance the current rocket
            // stage and build the next piece.
            _rocketConstructor.StartRocketConstruction();
        }
    }
}