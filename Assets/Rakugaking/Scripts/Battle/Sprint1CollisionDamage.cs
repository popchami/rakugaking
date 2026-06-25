using Rakugaking.Character;
using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class Sprint1CollisionDamage : MonoBehaviour
    {
        [SerializeField] private BattleCharacter owner;
        [SerializeField] private BattleController battleController;
        [SerializeField] private float minimumImpactSpeed = 1.5f;
        [SerializeField] private float damageMultiplier = 2f;
        [SerializeField] private float maxDamagePerHit = 12f;
        [SerializeField] private float hitCooldownSeconds = 0.5f;

        private float lastHitTime;

        private void Awake()
        {
            if (owner == null)
            {
                owner = GetComponentInParent<BattleCharacter>();
            }

            if (battleController == null)
            {
                battleController = FindFirstObjectByType<BattleController>();
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (battleController == null || owner == null || Time.time - lastHitTime < hitCooldownSeconds)
            {
                return;
            }

            var target = collision.collider.GetComponentInParent<BattleCharacter>();
            if (target == null || target == owner)
            {
                return;
            }

            var impactSpeed = collision.relativeVelocity.magnitude;
            if (impactSpeed < minimumImpactSpeed)
            {
                return;
            }

            var damage = Mathf.Min(maxDamagePerHit, impactSpeed * damageMultiplier);
            battleController.ApplyDamage(target, damage);
            lastHitTime = Time.time;
        }
    }
}
