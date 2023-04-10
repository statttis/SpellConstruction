// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class SpellConstruction
{
    public static class Keyword
    {
        private static FormLink<IKeywordGetter> Construct(uint id) => new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IKeywordGetter> SCCraftingSpellbook => Construct(0x800);
    }
}
