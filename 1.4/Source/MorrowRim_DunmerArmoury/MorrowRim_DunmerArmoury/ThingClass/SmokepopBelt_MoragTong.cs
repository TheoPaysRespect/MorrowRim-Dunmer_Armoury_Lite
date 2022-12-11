using Verse;
using RimWorld;

namespace MorrowRim_DunmerArmoury
{
    public class SmokepopBelt_MoragTong : SmokepopBelt
    {
        public override bool CheckPreAbsorbDamage(DamageInfo dinfo)
        {
            Verb_SmokePop.Pop(this.TryGetComp<CompReloadable>());
            return base.CheckPreAbsorbDamage(dinfo);
        }
    }
}
