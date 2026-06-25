namespace Rakugaking.Battle
{
    public enum BattleEndReason
    {
        None,
        HpZero,
        RingOut,
        TimeUp
    }

    public enum BattleWinner
    {
        None,
        FighterA,
        FighterB,
        Draw
    }

    public readonly struct BattleResult
    {
        public BattleResult(BattleWinner winner, BattleEndReason reason)
        {
            Winner = winner;
            Reason = reason;
        }

        public BattleWinner Winner { get; }
        public BattleEndReason Reason { get; }

        public bool IsFinished => Winner != BattleWinner.None;

        public override string ToString()
        {
            return $"Winner: {Winner} / Reason: {Reason}";
        }
    }
}
