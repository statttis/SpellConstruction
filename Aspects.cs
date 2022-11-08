using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using SCMod = Mutagen.Bethesda.FormKeys.SkyrimSE.SpellConstruction;

namespace SpellConstruction
{
    public class Aspects
    {
        public static List<Aspect> Essences = new List<Aspect>()
        {
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectArmor,
                Keywords = { Skyrim.Keyword.MagicArmorSpell, Skyrim.Keyword.MagicDamageResist },
                ActorValues = { ActorValue.DamageResist, ActorValue.HeavyArmor, ActorValue.LightArmor, ActorValue.Block },
                Phrases = { "armor", "shield", "defen", "block" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectHeat,
                Keywords = { Skyrim.Keyword.MagicDamageFire, Skyrim.Keyword.MagicSummonFire },
                ActorValues = { ActorValue.ResistFire },
                Phrases = { "fire", "burn", "heat", "ash", "pyre", "flar" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectCold,
                Keywords = { Skyrim.Keyword.MagicDamageFrost, Skyrim.Keyword.MagicSummonFrost },
                ActorValues = { ActorValue.ResistFrost },
                Phrases = { "frost", "froze", "freeze", "ice", "cold", "chill", "cool" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectShock,
                Keywords = { Skyrim.Keyword.MagicDamageShock, Skyrim.Keyword.MagicSummonShock },
                ActorValues = { ActorValue.ResistShock },
                Phrases = { "shock", "lightning", "zap", "elec", "thunder", "jolt" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectPoison,
                Archetypes = { MagicEffectArchetype.TypeEnum.CurePoison },
                ActorValues = { ActorValue.PoisonResist },
                Phrases = { "poison", "acid", "blight", "toxi", "venom" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectLove,
                Keywords = { Skyrim.Keyword.MagicInfluenceCharm },
                ActorValues = { ActorValue.Speech, ActorValue.SpeechcraftModifier, ActorValue.SpeechcraftPowerModifier },
                Phrases = { "love", "charm", "fascinat", "allur" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectFear,
                Keywords = { Skyrim.Keyword.MagicInfluenceFear },
                Archetypes = { MagicEffectArchetype.TypeEnum.Rally },
                ActorValues = { ActorValue.Confidence },
                Phrases = { "fear", "fright", "rally", "courag", "brav", "panic", "terror" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectAnger,
                Keywords = { Skyrim.Keyword.MagicInfluenceFrenzy },
                Archetypes = { MagicEffectArchetype.TypeEnum.Frenzy },
                ActorValues = { ActorValue.Aggression },
                Phrases = { "anger", "frenz", "rage", "fury" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectVisibility,
                Keywords = { Skyrim.Keyword.MagicInvisibility },
                Archetypes = { MagicEffectArchetype.TypeEnum.Invisibility },
                ActorValues = { ActorValue.Invisibility },
                Phrases = { "visibl", "hide", "hidden", "veil" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectParalysis,
                Keywords = { Skyrim.Keyword.MagicParalysis },
                Archetypes = { MagicEffectArchetype.TypeEnum.CureParalysis, MagicEffectArchetype.TypeEnum.Paralysis },
                ActorValues = { ActorValue.Paralysis },
                Phrases = { "paraly", "stun", "daz" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectUndead,
                Keywords = { Skyrim.Keyword.MagicSummonUndead, Skyrim.Keyword.MagicTurnUndead },
                Archetypes = { MagicEffectArchetype.TypeEnum.TurnUndead, MagicEffectArchetype.TypeEnum.Reanimate },
                Phrases = { "undead", "reanim", "skeleton", "zombie", "corpse", "vampir" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDaedra,
                Archetypes = { MagicEffectArchetype.TypeEnum.Banish },
                Phrases = { "daedr", "oblivion", "dremora", "scamp", "atronach", "saint", "seducer" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDisease,
                Archetypes = { MagicEffectArchetype.TypeEnum.CureDisease },
                ActorValues = { ActorValue.ResistDisease },
                Phrases = { "diseas", "sick", "plagu", "infect", "contag" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectTime,
                Archetypes = { MagicEffectArchetype.TypeEnum.SlowTime },
                Phrases = { "time", "pause", "chrono" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectForce,
                Keywords = { Skyrim.Keyword.MagicTelekinesis },
                Archetypes = { MagicEffectArchetype.TypeEnum.Stagger, MagicEffectArchetype.TypeEnum.Telekinesis, MagicEffectArchetype.TypeEnum.GrabActor },
                Phrases = { "telekine", "forc", "stagger", "throw" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectLight,
                Archetypes = { MagicEffectArchetype.TypeEnum.Light },
                Phrases = { "light", "sun", "lumin", "radia", "shin" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDark,
                Keywords = { Skyrim.Keyword.MagicNightEye },
                ActorValues = { ActorValue.NightEye },
                Phrases = { "dark", "night", "moon", "dusk", "black" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectSpeed,
                Keywords = { Skyrim.Keyword.MagicSlow },
                ActorValues = { ActorValue.SpeedMult },
                Phrases = { "speed", "fast", "slow", "quick", "hast", "swift", "fleet" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectWater,
                ActorValues = { ActorValue.WaterBreathing, ActorValue.WaterWalking },
                Phrases = { "water", "wet", "sea", "lake", "river", "ocean", "liquid", "swim" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectAir,
                Phrases = { "air", "wind", "breez", "blow", "sky", "gust", "weather", "atmos" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectSoul,
                Keywords = { Skyrim.Keyword.MagicSummonFamiliar },
                Archetypes = { MagicEffectArchetype.TypeEnum.Etherealize, MagicEffectArchetype.TypeEnum.SoulTrap },
                Phrases = { "ghost", "spirit", "familiar", "ethereal", "invuln", "shade", "spect", "soul", "death", "mortal" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectSound,
                ActorValues = { ActorValue.ShoutRecoveryMult, ActorValue.VoicePoints, ActorValue.VoiceRate },
                Phrases = { "sound", "loud", "quiet", "silen", "nois", "shout", "voic", "vibrat", "music" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectHealth,
                Keywords = { Skyrim.Keyword.MagicRestoreHealth },
                ActorValues = { ActorValue.Health, ActorValue.HealRate, ActorValue.HealRateMult },
                Phrases = { "heal", "life", "hardy", "hardi" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectStamina,
                ActorValues = { ActorValue.Stamina, ActorValue.StaminaRate, ActorValue.StaminaRateMult },
                Phrases = { "stamin", "exhaust", "endur", "constitution", "fort", "resilien" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectMagicka,
                ActorValues = { ActorValue.Magicka, ActorValue.MagickaRate, ActorValue.MagickaRateMult },
                Phrases = { "magic" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectWeapon,
                Keywords = { Skyrim.Keyword.MagicFortifyOneHanded, Skyrim.Keyword.MagicFortifyTwoHanded, Skyrim.Keyword.MagicWeaponSpeed },
                Archetypes = { MagicEffectArchetype.TypeEnum.Bound, MagicEffectArchetype.TypeEnum.Disarm, MagicEffectArchetype.TypeEnum.EnhanceWeapon },
                ActorValues = { ActorValue.AttackDamageMult, ActorValue.WeaponSpeedMult, ActorValue.CriticalChance, ActorValue.MeleeDamage,
                    ActorValue.BowSpeedBonus, ActorValue.MarksmanModifier, ActorValue.MarksmanPowerModifier,
                    ActorValue.OneHanded, ActorValue.OneHandedModifier, ActorValue.OneHandedPowerModifier,
                    ActorValue.TwoHanded, ActorValue.TwoHandedModifier, ActorValue.TwoHandedModifier },
                Phrases = { "weap", "bow", "sword", "spear", "axe", "arrow", "mace", "staff", "stav", "dagger", "knife", "blade", "blunt", "handed", "bolt" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectMass,
                ActorValues = { ActorValue.InventoryWeight, ActorValue.CarryWeight, ActorValue.Mass },
                Phrases = { "mass", "weigh", "carr", "lighten", "heav", "encumb" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDevice,
                Archetypes = { MagicEffectArchetype.TypeEnum.Lock, MagicEffectArchetype.TypeEnum.Open },
                ActorValues = { ActorValue.Smithing, ActorValue.SmithingModifier, ActorValue.SmithingPowerModifier,
                    ActorValue.Lockpicking, ActorValue.LockpickingModifier, ActorValue.LockpickingPowerModifier },
                Phrases = { "lock", "open", "smith", "device", "construct", "mechan", "tool", "equip", "machin" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectEarth,
                Phrases = { "natur", "wild", "earth", "ston", "soil", "rock", "plant", "terra", "environ" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectMind,
                Keywords = { Skyrim.Keyword.MagicInfluence },
                Archetypes = { MagicEffectArchetype.TypeEnum.Calm, MagicEffectArchetype.TypeEnum.Frenzy, MagicEffectArchetype.TypeEnum.Rally },
                ActorValues = { ActorValue.Energy, ActorValue.Morality, ActorValue.Mood },
                Phrases = { "mind", "control", "mental", "psych", "cogn", "brain" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectBody,
                ActorValues = { ActorValue.JumpingBonus, ActorValue.UnarmedDamage },
                Phrases = { "jump", "unarmed", "strength", "strong", "body", "musc", "leap" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectShadow,
                ActorValues = { ActorValue.Pickpocket, ActorValue.PickpocketModifier, ActorValue.PickpocketPowerModifier,
                    ActorValue.Sneak, ActorValue.SneakingModifier, ActorValue.SneakingPowerModifier },
                Phrases = { "shadow", "sneak", "pickpocket", "steal", "gloom", "conceal" },
            }
        };

        public static List<Aspect> Mechanisms = new List<Aspect>()
        {
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectCloak,
                Keywords = { Skyrim.Keyword.MagicCloak },
                Archetypes = { MagicEffectArchetype.TypeEnum.Cloak },
                Phrases = { "cloak", "aura", "surround" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDamage,
                Keywords = { Skyrim.Keyword.MagicDamageFire, Skyrim.Keyword.MagicDamageFrost, Skyrim.Keyword.MagicDamageShock },
                Archetypes = { MagicEffectArchetype.TypeEnum.DualValueModifier, MagicEffectArchetype.TypeEnum.PeakValueModifier, MagicEffectArchetype.TypeEnum.ValueModifier },
                ActorValues = { ActorValue.AttackDamageMult, ActorValue.MeleeDamage, ActorValue.UnarmedDamage, ActorValue.ReflectDamage },
                ActorValueRequiement = ActorValueRequirement.NegativeDamage,
                Phrases = { "damag", "harm", "hurt", "destr", "break", "disintegrat" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectHeal,
                Keywords = { Skyrim.Keyword.MagicRestoreHealth },
                Archetypes = { MagicEffectArchetype.TypeEnum.DualValueModifier, MagicEffectArchetype.TypeEnum.PeakValueModifier, MagicEffectArchetype.TypeEnum.ValueModifier },
                ActorValues = { ActorValue.Health, ActorValue.HealRate, ActorValue.HealRateMult, ActorValue.Stamina, ActorValue.StaminaRate, ActorValue.StaminaRateMult },
                ActorValueRequiement = ActorValueRequirement.PositiveHeal,
                Phrases = { "heal", "life", "restor", "regen", "soothe", "mend", "salve"  },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectInfluence,
                Keywords = { Skyrim.Keyword.MagicInfluence },
                Archetypes = { MagicEffectArchetype.TypeEnum.CommandSummoned },
                Phrases = { "command", "control", "dominat", "compel" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectRune,
                Keywords = { Skyrim.Keyword.MagicRune, Skyrim.Keyword.RitualSpellEffect },
                Archetypes = { MagicEffectArchetype.TypeEnum.SpawnHazard },
                Phrases = { "rune", "symbol", "word", "trap", "sign" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectSummon,
                Keywords = { Skyrim.Keyword.MagicSummonFamiliar, Skyrim.Keyword.MagicSummonFire, Skyrim.Keyword.MagicSummonFrost,
                    Skyrim.Keyword.MagicSummonShock, Skyrim.Keyword.MagicSummonUndead },
                Archetypes = { MagicEffectArchetype.TypeEnum.SummonCreature },
                Phrases = { "summon", "conjur" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectBind,
                Archetypes = { MagicEffectArchetype.TypeEnum.Bound },
                Phrases = { "bound", "bind", "enslav" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDismiss,
                Keywords = { Skyrim.Keyword.MagicTurnUndead },
                Archetypes = { MagicEffectArchetype.TypeEnum.Banish, MagicEffectArchetype.TypeEnum.TurnUndead, MagicEffectArchetype.TypeEnum.Dispel },
                Phrases = { "turn", "banish", "dismiss", "dispel", "cancel", "remov", "counter" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectTeleport,
                Phrases = { "tele", "blink", "recall" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectCure,
                Archetypes = { MagicEffectArchetype.TypeEnum.CureDisease, MagicEffectArchetype.TypeEnum.CureParalysis, MagicEffectArchetype.TypeEnum.CurePoison },
                Phrases = { "cure", "remed", "antidot" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDetect,
                Archetypes = { MagicEffectArchetype.TypeEnum.DetectLife, MagicEffectArchetype.TypeEnum.Guide },
                ActorValues = { ActorValue.DetectLifeRange },
                Phrases = { "detect", "guid", "clairvoyan", "show", "reveal" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectResist,
                Keywords = { Skyrim.Keyword.MagicDamageResist },
                Archetypes = { MagicEffectArchetype.TypeEnum.DualValueModifier, MagicEffectArchetype.TypeEnum.PeakValueModifier, MagicEffectArchetype.TypeEnum.ValueModifier },
                ActorValues = { ActorValue.DamageResist, ActorValue.ResistDisease, ActorValue.ResistFire, ActorValue.ResistFrost, ActorValue.ResistMagic, ActorValue.ResistShock },
                ActorValueRequiement = ActorValueRequirement.PositiveBuff,
                Phrases = { "resist", "protect" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectDrain,
                Archetypes = { MagicEffectArchetype.TypeEnum.DualValueModifier, MagicEffectArchetype.TypeEnum.PeakValueModifier, MagicEffectArchetype.TypeEnum.ValueModifier },
                ActorValues = { ActorValue.DamageResist, ActorValue.ResistDisease, ActorValue.ResistFire, ActorValue.ResistFrost, ActorValue.ResistMagic, ActorValue.ResistShock,
                    ActorValue.OneHanded, ActorValue.TwoHanded, ActorValue.Archery, ActorValue.Block, ActorValue.Smithing, ActorValue.HeavyArmor,
                    ActorValue.LightArmor, ActorValue.Pickpocket, ActorValue.Lockpicking, ActorValue.Sneak, ActorValue.Alchemy, ActorValue.Speech,
                    ActorValue.Alteration, ActorValue.Conjuration, ActorValue.Destruction, ActorValue.Illusion, ActorValue.Restoration, ActorValue.Enchanting,
                    ActorValue.OneHandedModifier, ActorValue.TwoHandedModifier, ActorValue.MarksmanModifier, ActorValue.BlockModifier,
                    ActorValue.SmithingModifier, ActorValue.HeavyArmorModifier, ActorValue.LightArmorModifier, ActorValue.PickpocketModifier,
                    ActorValue.LockpickingModifier, ActorValue.SneakingModifier, ActorValue.AlchemyModifier, ActorValue.SpeechcraftModifier,
                    ActorValue.AlterationModifier, ActorValue.ConjurationModifier, ActorValue.DestructionModifier, ActorValue.IllusionModifier,
                    ActorValue.RestorationModifier, ActorValue.EnchantingModifier, ActorValue.OneHandedPowerModifier, ActorValue.TwoHandedPowerModifier,
                    ActorValue.MarksmanPowerModifier, ActorValue.BlockPowerModifier, ActorValue.SmithingPowerModifier, ActorValue.HeavyArmorPowerModifier,
                    ActorValue.LightArmorPowerModifier, ActorValue.PickpocketPowerModifier, ActorValue.LockpickingPowerModifier,
                    ActorValue.SneakingPowerModifier, ActorValue.AlchemyPowerModifier, ActorValue.SpeechcraftPowerModifier, ActorValue.AlterationPowerModifier,
                    ActorValue.ConjurationPowerModifier, ActorValue.DestructionPowerModifier, ActorValue.IllusionPowerModifier,
                    ActorValue.RestorationPowerModifier, ActorValue.EnchantingPowerModifier
                },
                ActorValueRequiement= ActorValueRequirement.NegativeDebuff,
                Phrases = { "weak", "vulnerab", "drain", "frail", "reduc" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectFortify,
                Archetypes = { MagicEffectArchetype.TypeEnum.DualValueModifier, MagicEffectArchetype.TypeEnum.PeakValueModifier, MagicEffectArchetype.TypeEnum.ValueModifier },
                ActorValues = { ActorValue.OneHanded, ActorValue.TwoHanded, ActorValue.Archery, ActorValue.Block, ActorValue.Smithing, ActorValue.HeavyArmor,
                    ActorValue.LightArmor, ActorValue.Pickpocket, ActorValue.Lockpicking, ActorValue.Sneak, ActorValue.Alchemy, ActorValue.Speech,
                    ActorValue.Alteration, ActorValue.Conjuration, ActorValue.Destruction, ActorValue.Illusion, ActorValue.Restoration, ActorValue.Enchanting,
                    ActorValue.OneHandedModifier, ActorValue.TwoHandedModifier, ActorValue.MarksmanModifier, ActorValue.BlockModifier,
                    ActorValue.SmithingModifier, ActorValue.HeavyArmorModifier, ActorValue.LightArmorModifier, ActorValue.PickpocketModifier,
                    ActorValue.LockpickingModifier, ActorValue.SneakingModifier, ActorValue.AlchemyModifier, ActorValue.SpeechcraftModifier,
                    ActorValue.AlterationModifier, ActorValue.ConjurationModifier, ActorValue.DestructionModifier, ActorValue.IllusionModifier,
                    ActorValue.RestorationModifier, ActorValue.EnchantingModifier, ActorValue.OneHandedPowerModifier, ActorValue.TwoHandedPowerModifier,
                    ActorValue.MarksmanPowerModifier, ActorValue.BlockPowerModifier, ActorValue.SmithingPowerModifier, ActorValue.HeavyArmorPowerModifier,
                    ActorValue.LightArmorPowerModifier, ActorValue.PickpocketPowerModifier, ActorValue.LockpickingPowerModifier,
                    ActorValue.SneakingPowerModifier, ActorValue.AlchemyPowerModifier, ActorValue.SpeechcraftPowerModifier, ActorValue.AlterationPowerModifier,
                    ActorValue.ConjurationPowerModifier, ActorValue.DestructionPowerModifier, ActorValue.IllusionPowerModifier,
                    ActorValue.RestorationPowerModifier, ActorValue.EnchantingPowerModifier },
                ActorValueRequiement= ActorValueRequirement.PositiveBuff,
                Phrases = { "fortify", "strength", "improv", "boost", "increas" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectAbsorb,
                Keywords = { Skyrim.Keyword.MagicVampireDrain },
                Archetypes = { MagicEffectArchetype.TypeEnum.Absorb },
                Phrases = { "absorb", "drain", "consum", "devour" },
            },
            new Aspect
            {
                Book = SCMod.Book.SCConstructionAspectWard,
                Keywords = { Skyrim.Keyword.MagicWard },
                Archetypes = { MagicEffectArchetype.TypeEnum.AccumulateMagnitude },
                ActorValues = { ActorValue.WardDeflection, ActorValue.WardPower },
                Phrases = { "ward", "protect", "reflect" },
            }
        };

        public static List<Aspect> All = Essences.Concat(Mechanisms).ToList();
    }
}
