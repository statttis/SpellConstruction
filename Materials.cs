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
                Materials = { Skyrim.MiscItem.IngotQuicksilver }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionConjuration,
                Materials = { Skyrim.MiscItem.IngotIMoonstone }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionDestruction,
                Materials = { Skyrim.MiscItem.IngotGold }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionIllusion,
                Materials = { Skyrim.MiscItem.ingotSilver }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionRestoration,
                Materials = { Skyrim.MiscItem.IngotCorundum }
            }
        };

        public static List<Material> Intentions = new List<Material>()
        {
            new Material
            {
                Book = SCMod.Book.SCConstructionSelf,
                Materials = { Skyrim.MiscItem.GemRuby, Skyrim.MiscItem.gemRubyFlawless }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionTarget,
                Materials = { Skyrim.MiscItem.GemGarnet, Skyrim.MiscItem.GemGarnetFlawless }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionTouch,
                Materials = { Skyrim.MiscItem.GemEmerald, Skyrim.MiscItem.GemEmeraldFlawless }
            }
        };

        public static List<Material> Methods = new List<Material>()
        {
            new Material
            {
                Book = SCMod.Book.SCConstructionFireAndForget,
                Materials = { Skyrim.MiscItem.GemDiamond, Skyrim.MiscItem.GemDiamondFlawless }
            },
            new Material
            {
                Book = SCMod.Book.SCConstructionConcentration,
                Materials = { Skyrim.MiscItem.GemAmethyst, Skyrim.MiscItem.GemAmethystFlawless }
            }
        };
    }
}
