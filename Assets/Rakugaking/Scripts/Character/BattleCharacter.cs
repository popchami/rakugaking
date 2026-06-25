using Rakugaking.Battle;
using UnityEngine;

namespace Rakugaking.Character
{
    public enum FighterSide
    {
        FighterA,
        FighterB
    }

    public sealed class BattleCharacter : MonoBehaviour
    {
        [SerializeField] private FighterSide side;
        [SerializeField] private Health health;
        [SerializeField] private Rigidbody rootBody;

        public FighterSide Side => side;
        public Health Health => health;
        public Rigidbody RootBody => rootBody;

        private void Awake()
        {
            if (health == null)
            {
                health = GetComponentInChildren<Health>();
            }

            if (rootBody == null)
            {
                rootBody = GetComponentInChildren<Rigidbody>();
            }
        }

        public void Setup(FighterSide fighterSide)
        {
            side = fighterSide;

            if (health == null)
            {
                health = GetComponentInChildren<Health>();
            }

            health?.ResetHp();
        }

        public BattleWinner ToWinner()
        {
            return side == FighterSide.FighterA ? BattleWinner.FighterA : BattleWinner.FighterB;
        }

        public BattleWinner ToOpponentWinner()
        {
            return side == FighterSide.FighterA ? BattleWinner.FighterB : BattleWinner.FighterA;
        }
    }
}
