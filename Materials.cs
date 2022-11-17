using Mutagen.Bethesda.FormKeys.SkyrimSE;
using SCMod = Mutagen.Bethesda.FormKeys.SkyrimSE.SpellConstruction;

namespace SpellConstruction
{
    public class Materials
    {
        public static List<Material> Fundamentals = new List<Material>()
        {
            new Material
            {
                Book = SCMod.Book.SCConstructionAlteration,
                Materials = { Skyrim.MiscItem.IngotQuicksilver },
                Aspects = { SCMod.Book.SCConstructionAspectTime, SCMod.Book.SCConstructionAspectForce, SCMod.Book.SCConstructionAspectDevice,
                    SCMod.Book.SCConstructionAspectSpeed, SCMod.Book.SCConstructionAspectMass }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionConjuration,
                Materials = { Skyrim.MiscItem.IngotIMoonstone },
                Aspects = { SCMod.Book.SCConstructionAspectUndead, SCMod.Book.SCConstructionAspectDaedra, SCMod.Book.SCConstructionAspectSummon,
                    SCMod.Book.SCConstructionAspectBind, SCMod.Book.SCConstructionAspectTeleport }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionDestruction,
                Materials = { Skyrim.MiscItem.IngotGold },
                Aspects = { SCMod.Book.SCConstructionAspectHeat, SCMod.Book.SCConstructionAspectCold, SCMod.Book.SCConstructionAspectShock,
                    SCMod.Book.SCConstructionAspectDamage, SCMod.Book.SCConstructionAspectDrain }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionIllusion,
                Materials = { Skyrim.MiscItem.ingotSilver },
                Aspects = { SCMod.Book.SCConstructionAspectLove, SCMod.Book.SCConstructionAspectFear, SCMod.Book.SCConstructionAspectAnger,
                    SCMod.Book.SCConstructionAspectVisibility, SCMod.Book.SCConstructionAspectInfluence }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionRestoration,
                Materials = { Skyrim.MiscItem.IngotCorundum },
                Aspects = { SCMod.Book.SCConstructionAspectPoison, SCMod.Book.SCConstructionAspectDisease, SCMod.Book.SCConstructionAspectHeal,
                    SCMod.Book.SCConstructionAspectDismiss, SCMod.Book.SCConstructionAspectCure }
            }
        };

        public static List<Material> Intentions = new List<Material>()
        {
            new Material
            {
                Book = SCMod.Book.SCConstructionSelf,
                Materials = { Skyrim.MiscItem.GemRuby, Skyrim.MiscItem.gemRubyFlawless },
                Aspects = { SCMod.Book.SCConstructionAspectMind, SCMod.Book.SCConstructionAspectBody, SCMod.Book.SCConstructionAspectCloak,
                    SCMod.Book.SCConstructionAspectResist, SCMod.Book.SCConstructionAspectFortify }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionTarget,
                Materials = { Skyrim.MiscItem.GemGarnet, Skyrim.MiscItem.GemGarnetFlawless },
                Aspects = { SCMod.Book.SCConstructionAspectWater, SCMod.Book.SCConstructionAspectAir, SCMod.Book.SCConstructionAspectEarth,
                    SCMod.Book.SCConstructionAspectDark, SCMod.Book.SCConstructionAspectArmor }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionTouch,
                Materials = { Skyrim.MiscItem.GemEmerald, Skyrim.MiscItem.GemEmeraldFlawless },
                Aspects = { SCMod.Book.SCConstructionAspectWeapon, SCMod.Book.SCConstructionAspectParalysis, SCMod.Book.SCConstructionAspectSoul,
                    SCMod.Book.SCConstructionAspectShadow, SCMod.Book.SCConstructionAspectRune }
            }
        };

        public static List<Material> Methods = new List<Material>()
        {
            new Material
            {
                Book = SCMod.Book.SCConstructionFireAndForget,
                Materials = { Skyrim.MiscItem.GemDiamond, Skyrim.MiscItem.GemDiamondFlawless },
                Aspects = { SCMod.Book.SCConstructionAspectHealth, SCMod.Book.SCConstructionAspectStamina, SCMod.Book.SCConstructionAspectMagicka,
                    SCMod.Book.SCConstructionAspectLight }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionConcentration,
                Materials = { Skyrim.MiscItem.GemAmethyst, Skyrim.MiscItem.GemAmethystFlawless },
                Aspects = { SCMod.Book.SCConstructionAspectDetect, SCMod.Book.SCConstructionAspectWard, SCMod.Book.SCConstructionAspectAbsorb,
                    SCMod.Book.SCConstructionAspectSound }
            }
        };
    }
}
