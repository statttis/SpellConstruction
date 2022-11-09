using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;

namespace SpellConstruction
{
    internal class SpellTomeFilters
    {
        public static HashSet<IBookGetter> FilterSpellTomeExclusions(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, string exclusions, HashSet<IBookGetter> spellTomes)
        {
            return spellTomes.Except(ParseSpellTomes(state, exclusions)).ToHashSet();
        }

        public static HashSet<IBookGetter> FilterModExclusions(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, string exclusions, HashSet<IBookGetter> spellTomes)
        {
            if (string.IsNullOrWhiteSpace(exclusions))
            {
                return spellTomes;
            }

            var mods = exclusions.Split('|').Select(x => ModKey.FromNameAndExtension(x));
            return spellTomes.Where(x => !mods.Contains(x.FormKey.ModKey)).ToHashSet();
        }

        public static HashSet<IBookGetter> AddSpellTomeInclusions(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, string inclusions, HashSet<IBookGetter> spellTomes)
        {
            return spellTomes.Concat(ParseSpellTomes(state, inclusions)).ToHashSet();
        }

        private static IEnumerable<IBookGetter> ParseSpellTomes(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, string spellTomePairs)
        {
            if (string.IsNullOrWhiteSpace(spellTomePairs))
            {
                return Enumerable.Empty<IBookGetter>();
            }

            return spellTomePairs.Split('|')
                .Select(x =>
                {
                    var modFormPair = x.Split(':');
                    var modKey = ModKey.FromNameAndExtension(modFormPair.First());
                    var spellTome = new FormLink<IBookGetter>(modKey.MakeFormKey(Convert.ToUInt32(modFormPair.Last(), 16)));
                    try
                    {
                        return spellTome.Resolve(state.LinkCache);
                    }
                    catch (RecordException)
                    {
                        Console.WriteLine($"Spell tome record not found: {x}");
                        return null;
                    }
                })
                .Where(x => x != null);
        }
    }
}
