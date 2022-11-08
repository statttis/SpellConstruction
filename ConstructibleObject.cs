// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class SpellConstruction
{
    public static class ConstructibleObject
    {
        private static FormLink<IConstructibleObjectGetter> Construct(uint id) => new FormLink<IConstructibleObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IConstructibleObjectGetter> SCRecipeSpellbook => Construct(0x3363);
    }
}
