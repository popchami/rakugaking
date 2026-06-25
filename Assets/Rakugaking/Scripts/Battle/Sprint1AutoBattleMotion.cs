using Rakugaking.Character;
using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class Sprint1AutoBattleMotion : MonoBehaviour
    {
        [SerializeField] private BattleCharacter character;
        [SerializeField] private Rigidbody rootBody;
        [SerializeField] private float forwardForce = 18f;
        [SerializeField] private float hopForce = 4f;
        [SerializeField] private float intervalSeconds = 1.2f;

        private float elapsed;

        private void Awake()
        {
            if (character == null)
            {
                character = GetComponent<BattleCharacter>();
            }

            if (rootBody == null && character != null)
            {
                rootBody = character.RootBody;
            }
        }

        private void FixedUpdate()
        {
            if (rootBody == null || character == null || character.Health == null || character.Health.IsDefeated)
            {
                return;
            }

            elapsed += Time.fixedDeltaTime;
            if (elapsed < intervalSeconds)
            {
                return;
            }

            elapsed = 0f;
            var direction = character.Side == FighterSide.FighterA ? Vector3.right : Vector3.left;
            rootBody.AddForce(direction * forwardForce + Vector3.up * hopForce, ForceMode.Impulse);
        }
    }
}
