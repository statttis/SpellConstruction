using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace SpellConstruction
{
    public class Aspect
    {
        public FormLink<IBookGetter> Book { get; set; }
        public List<FormLink<IKeywordGetter>> Keywords { get; set; } = new List<FormLink<IKeywordGetter>>();
        public List<MagicEffectArchetype.TypeEnum> Archetypes { get; set; } = new List<MagicEffectArchetype.TypeEnum>();
        public List<ActorValue> ActorValues { get; set; } = new List<ActorValue>();
        public ActorValueRequirement ActorValueRequiement { get; set; } = ActorValueRequirement.None;
        public List<string> Phrases { get; set; } = new List<string>();
    }

    public enum ActorValueRequirement
    {
        None,
        PositiveHeal,
        PositiveBuff,
        NegativeDamage,
        NegativeDebuff
    }
}
