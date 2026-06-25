using Rakugaking.Character;
using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class RingOutDetector : MonoBehaviour
    {
        [SerializeField] private float ringOutY = -3f;

        public float RingOutY
        {
            get => ringOutY;
            set => ringOutY = value;
        }

        public bool IsRingOut(BattleCharacter character)
        {
            if (character == null)
            {
                return false;
            }

            var root = character.RootBody != null ? character.RootBody.transform : character.transform;
            return root.position.y <= ringOutY;
        }
    }
}
