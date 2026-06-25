using Rakugaking.Character;
using UnityEngine;

namespace Rakugaking.Battle
{
    public sealed class BattleController : MonoBehaviour
    {
        [Header("Fighters")]
        [SerializeField] private BattleCharacter fighterA;
        [SerializeField] private BattleCharacter fighterB;

        [Header("Rules")]
        [SerializeField] private float battleDurationSeconds = 60f;
        [SerializeField] private bool autoStart = true;

        private BattleTimer timer;
        private ShrinkingRingController shrinkingRing;
        private BattleResult result;
        private bool isRunning;

        public BattleCharacter FighterA => fighterA;
        public BattleCharacter FighterB => fighterB;
        public float RemainingTime => timer?.RemainingSeconds ?? 0f;
        public BattleResult Result => result;
        public bool IsRunning => isRunning;

        private void Awake()
        {
            timer = new BattleTimer(battleDurationSeconds);
            shrinkingRing = GetComponent<ShrinkingRingController>();

            if (shrinkingRing == null)
            {
                shrinkingRing = gameObject.AddComponent<ShrinkingRingController>();
            }
        }

        private void Start()
        {
            if (autoStart)
            {
                StartBattle();
            }
        }

        private void Update()
        {
            if (!isRunning)
            {
                return;
            }

            timer.Tick(Time.deltaTime);
            shrinkingRing.Tick(Time.deltaTime);
            ApplyShrinkingRingRules();
            CheckHpDefeat();
            CheckTimeUp();
        }

        public void SetFighters(BattleCharacter first, BattleCharacter second)
        {
            fighterA = first;
            fighterB = second;
        }

        public void StartBattle()
        {
            if (fighterA == null || fighterB == null)
            {
                Debug.LogWarning("Battle cannot start because fighters are missing.");
                return;
            }

            fighterA.Setup(FighterSide.FighterA);
            fighterB.Setup(FighterSide.FighterB);

            timer.Reset();
            shrinkingRing.ResetRing();
            result = new BattleResult(BattleWinner.None, BattleEndReason.None);
            isRunning = true;
        }

        public void ApplyDamage(BattleCharacter target, float damage)
        {
            if (!isRunning || target == null || target.Health == null)
            {
                return;
            }

            target.Health.ApplyDamage(damage);
        }

        private void ApplyShrinkingRingRules()
        {
            if (shrinkingRing.IsEmergencyFall(fighterA))
            {
                EndBattle(new BattleResult(BattleWinner.FighterB, BattleEndReason.EmergencyFall));
                return;
            }

            if (shrinkingRing.IsEmergencyFall(fighterB))
            {
                EndBattle(new BattleResult(BattleWinner.FighterA, BattleEndReason.EmergencyFall));
                return;
            }

            shrinkingRing.ApplyOutsideRingDamage(fighterA, Time.deltaTime);
            shrinkingRing.ApplyOutsideRingDamage(fighterB, Time.deltaTime);
        }

        private void CheckHpDefeat()
        {
            if (!isRunning)
            {
                return;
            }

            if (fighterA.Health != null && fighterA.Health.IsDefeated)
            {
                EndBattle(new BattleResult(BattleWinner.FighterB, BattleEndReason.HpZero));
            }
            else if (fighterB.Health != null && fighterB.Health.IsDefeated)
            {
                EndBattle(new BattleResult(BattleWinner.FighterA, BattleEndReason.HpZero));
            }
        }

        private void CheckTimeUp()
        {
            if (!isRunning || !timer.IsFinished)
            {
                return;
            }

            var hpA = fighterA.Health != null ? fighterA.Health.CurrentHp : 0f;
            var hpB = fighterB.Health != null ? fighterB.Health.CurrentHp : 0f;

            if (Mathf.Approximately(hpA, hpB))
            {
                EndBattle(new BattleResult(BattleWinner.Draw, BattleEndReason.TimeUp));
            }
            else if (hpA > hpB)
            {
                EndBattle(new BattleResult(BattleWinner.FighterA, BattleEndReason.TimeUp));
            }
            else
            {
                EndBattle(new BattleResult(BattleWinner.FighterB, BattleEndReason.TimeUp));
            }
        }

        private void EndBattle(BattleResult battleResult)
        {
            if (!isRunning)
            {
                return;
            }

            result = battleResult;
            isRunning = false;
            Debug.Log(result.ToString());
        }
    }
}
