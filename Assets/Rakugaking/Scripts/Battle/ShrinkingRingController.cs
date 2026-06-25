using Rakugaking.Character;
using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class ShrinkingRingController : MonoBehaviour
    {
        [SerializeField] private Transform ringVisual;
        [SerializeField] private float startHalfWidth = 4f;
        [SerializeField] private float startHalfDepth = 2f;
        [SerializeField] private float minimumScale = 0.5f;
        [SerializeField] private float shrinkStartSeconds = 10f;
        [SerializeField] private float fullShrinkSeconds = 60f;
        [SerializeField] private float outsideDamagePerSecond = 8f;
        [SerializeField] private float emergencyFallY = -5f;

        private float elapsedSeconds;

        public float EmergencyFallY => emergencyFallY;
        public float CurrentScale { get; private set; } = 1f;
        public float CurrentHalfWidth => startHalfWidth * CurrentScale;
        public float CurrentHalfDepth => startHalfDepth * CurrentScale;

        public void ResetRing()
        {
            elapsedSeconds = 0f;
            CurrentScale = 1f;
            ApplyVisualScale();
        }

        public void Tick(float deltaTime)
        {
            elapsedSeconds += deltaTime;

            if (elapsedSeconds <= shrinkStartSeconds)
            {
                CurrentScale = 1f;
            }
            else
            {
                var shrinkProgress = Mathf.InverseLerp(shrinkStartSeconds, fullShrinkSeconds, elapsedSeconds);
                CurrentScale = Mathf.Lerp(1f, minimumScale, shrinkProgress);
            }

            ApplyVisualScale();
        }

        public bool IsOutsideRing(BattleCharacter character)
        {
            if (character == null)
            {
                return false;
            }

            var root = character.RootBody != null ? character.RootBody.transform : character.transform;
            var local = transform.InverseTransformPoint(root.position);
            return Mathf.Abs(local.x) > CurrentHalfWidth || Mathf.Abs(local.z) > CurrentHalfDepth;
        }

        public bool IsEmergencyFall(BattleCharacter character)
        {
            if (character == null)
            {
                return false;
            }

            var root = character.RootBody != null ? character.RootBody.transform : character.transform;
            return root.position.y <= emergencyFallY;
        }

        public void ApplyOutsideRingDamage(BattleCharacter character, float deltaTime)
        {
            if (character == null || character.Health == null || !IsOutsideRing(character))
            {
                return;
            }

            character.Health.ApplyDamage(outsideDamagePerSecond * deltaTime);
        }

        private void ApplyVisualScale()
        {
            if (ringVisual == null)
            {
                return;
            }

            ringVisual.localScale = new Vector3(startHalfWidth * 2f * CurrentScale, ringVisual.localScale.y, startHalfDepth * 2f * CurrentScale);
        }
    }
}
