using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class BattleTimer
    {
        public BattleTimer(float durationSeconds)
        {
            DurationSeconds = Mathf.Max(1f, durationSeconds);
            RemainingSeconds = DurationSeconds;
        }

        public float DurationSeconds { get; }
        public float RemainingSeconds { get; private set; }
        public bool IsFinished => RemainingSeconds <= 0f;

        public void Reset()
        {
            RemainingSeconds = DurationSeconds;
        }

        public void Tick(float deltaTime)
        {
            if (IsFinished)
            {
                return;
            }

            RemainingSeconds = Mathf.Max(0f, RemainingSeconds - deltaTime);
        }
    }
}
