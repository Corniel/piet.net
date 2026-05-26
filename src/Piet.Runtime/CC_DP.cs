namespace Piet.Runtime;

/// <summary>Combines Codel Chooser (CC) and Direction Pointer (DP).</summary>
public enum CC_DP
{
    /// <summary>Choose left, move right.</summary>
    LR = 0b_000,
    
    /// <summary>Choose left, move down.</summary>
    LD = 0b_001,

    /// <summary>Choose left, move left.</summary>
    LL = 0b_010,

    /// <summary>Choose left, move top.</summary>
    LT = 0b_011,

    /// <summary>Choose right, move right.</summary>
    RR = 0b_100,

    /// <summary>Choose right, move down.</summary>
    RD = 0b_101,

    /// <summary>Choose right, move left.</summary>
    RL = 0b_110,

    /// <summary>Choose right, move top.</summary>
    RT = 0b_111,
}

public static class CC_DPExtenions
{ 
    extension(CC_DP pt)
    {
        /// <summary>The <see cref="int"/> representation.</summary>
        private int Int => (int)pt;

        /// <summary>The Direction Pointer (DP) component.</summary>
        public int DP => pt.Int & 3;

        public CC_DP Switch(long value = 1)
        {
            var mod = (int)(value & 1) << 2;
            var next = pt.Int ^ mod;
            return (CC_DP)next;
        }

        public CC_DP Rotate(long value)
        {
            var next = (int)((pt.Int & 3) + value) & 3;
            next |= pt.Int & 0b100;
            return (CC_DP)next;
        }
    }
}
