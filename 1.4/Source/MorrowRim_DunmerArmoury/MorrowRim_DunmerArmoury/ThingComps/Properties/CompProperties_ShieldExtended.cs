﻿using RimWorld;

namespace MorrowRim_DunmerArmoury
{
    public class CompProperties_ShieldExtended : CompProperties_Shield
    {
        public CompProperties_ShieldExtended()
        {
            compClass = typeof(Comp_ShieldExtended);
        }

        //defaults to vanilla bubble
        public string texPath = "Other/ShieldBubble";
    }
}
