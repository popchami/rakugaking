using Rakugaking.Battle;
using UnityEngine;

namespace Rakugaking.UI
{
    public sealed class BattleHud : MonoBehaviour
    {
        [SerializeField] private BattleController battleController;

        private void Awake()
        {
            if (battleController == null)
            {
                battleController = FindFirstObjectByType<BattleController>();
            }
        }

        private void OnGUI()
        {
            if (battleController == null)
            {
                GUI.Label(new Rect(20, 20, 500, 30), "BattleController not found");
                return;
            }

            var fighterA = battleController.FighterA;
            var fighterB = battleController.FighterB;
            var hpA = fighterA != null && fighterA.Health != null ? fighterA.Health.CurrentHp : 0f;
            var hpB = fighterB != null && fighterB.Health != null ? fighterB.Health.CurrentHp : 0f;

            GUI.Label(new Rect(20, 20, 220, 30), $"Fighter A HP: {hpA:0}");
            GUI.Label(new Rect(260, 20, 220, 30), $"Fighter B HP: {hpB:0}");
            GUI.Label(new Rect(20, 55, 220, 30), $"Time: {battleController.RemainingTime:0.0}");

            if (!battleController.IsRunning && battleController.Result.IsFinished)
            {
                GUI.Label(new Rect(20, 95, 500, 30), battleController.Result.ToString());

                if (GUI.Button(new Rect(20, 135, 160, 40), "Restart"))
                {
                    battleController.StartBattle();
                }
            }
        }
    }
}
