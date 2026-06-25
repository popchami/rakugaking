using System;
using UnityEngine;

namespace Rakugaking.Character
{
    public sealed class Health : MonoBehaviour
    {
        [SerializeField] private float maxHp = 100f;

        public event Action<Health> Defeated;
        public event Action<Health, float, float> Changed;

        public float MaxHp => maxHp;
        public float CurrentHp { get; private set; }
        public bool IsDefeated => CurrentHp <= 0f;

        private void Awake()
        {
            ResetHp();
        }

        public void ResetHp()
        {
            CurrentHp = maxHp;
            Changed?.Invoke(this, CurrentHp, MaxHp);
        }

        public void ApplyDamage(float amount)
        {
            if (amount <= 0f || IsDefeated)
            {
                return;
            }

            CurrentHp = Mathf.Max(0f, CurrentHp - amount);
            Changed?.Invoke(this, CurrentHp, MaxHp);

            if (IsDefeated)
            {
                Defeated?.Invoke(this);
            }
        }
    }
}
