using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using SCMod = Mutagen.Bethesda.FormKeys.SkyrimSE.SpellConstruction;

namespace SpellConstruction
{
    internal class Skills
    {
        public static FormLink<IBookGetter> GetSchoolConstruction(Skill school)
        {
            switch (school)
            {
                case Skill.Alteration:
                    return SCMod.Book.SCConstructionAlteration;
                case Skill.Conjuration:
                    return SCMod.Book.SCConstructionConjuration;
                case Skill.Destruction:
                    return SCMod.Book.SCConstructionDestruction;
                case Skill.Illusion:
                    return SCMod.Book.SCConstructionIllusion;
                case Skill.Restoration:
                    return SCMod.Book.SCConstructionRestoration;
                default:
                    throw new Exception($"Unexpected skill: {school}");
            }
        }

        public static (Skill, SkillLevel) GetSchoolAndExpertise(IFormLinkGetter<IPerkGetter> halfCostPerk)
        {
            if (halfCostPerk.FormKey.ID == Skyrim.Perk.AlterationNovice00.FormKey.ID)
            {
                return (Skill.Alteration, SkillLevel.Novice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.AlterationApprentice25.FormKey.ID)
            {
                return (Skill.Alteration, SkillLevel.Apprentice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.AlterationAdept50.FormKey.ID)
            {
                return (Skill.Alteration, SkillLevel.Adept);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.AlterationExpert75.FormKey.ID)
            {
                return (Skill.Alteration, SkillLevel.Expert);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.AlterationMaster100.FormKey.ID)
            {
                return (Skill.Alteration, SkillLevel.Master);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.ConjurationNovice00.FormKey.ID)
            {
                return (Skill.Conjuration, SkillLevel.Novice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.ConjurationApprentice25.FormKey.ID)
            {
                return (Skill.Conjuration, SkillLevel.Apprentice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.ConjurationAdept50.FormKey.ID)
            {
                return (Skill.Conjuration, SkillLevel.Adept);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.ConjurationExpert75.FormKey.ID)
            {
                return (Skill.Conjuration, SkillLevel.Expert);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.ConjurationMaster100.FormKey.ID)
            {
                return (Skill.Conjuration, SkillLevel.Master);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.DestructionNovice00.FormKey.ID)
            {
                return (Skill.Destruction, SkillLevel.Novice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.DestructionApprentice25.FormKey.ID)
            {
                return (Skill.Destruction, SkillLevel.Apprentice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.DestructionAdept50.FormKey.ID)
            {
                return (Skill.Destruction, SkillLevel.Adept);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.DestructionExpert75.FormKey.ID)
            {
                return (Skill.Destruction, SkillLevel.Expert);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.DestructionMaster100.FormKey.ID)
            {
                return (Skill.Destruction, SkillLevel.Master);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.IllusionNovice00.FormKey.ID)
            {
                return (Skill.Illusion, SkillLevel.Novice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.IllusionApprentice25.FormKey.ID)
            {
                return (Skill.Illusion, SkillLevel.Apprentice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.IllusionAdept50.FormKey.ID)
            {
                return (Skill.Illusion, SkillLevel.Adept);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.IllusionExpert75.FormKey.ID)
            {
                return (Skill.Illusion, SkillLevel.Expert);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.IllusionMaster100.FormKey.ID)
            {
                return (Skill.Illusion, SkillLevel.Master);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.RestorationNovice00.FormKey.ID)
            {
                return (Skill.Restoration, SkillLevel.Novice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.RestorationApprentice25.FormKey.ID)
            {
                return (Skill.Restoration, SkillLevel.Apprentice);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.RestorationAdept50.FormKey.ID)
            {
                return (Skill.Restoration, SkillLevel.Adept);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.RestorationExpert75.FormKey.ID)
            {
                return (Skill.Restoration, SkillLevel.Expert);
            }

            if (halfCostPerk.FormKey.ID == Skyrim.Perk.RestorationMaster100.FormKey.ID)
            {
                return (Skill.Restoration, SkillLevel.Master);
            }

            throw new Exception($"Unexpected half cost perk: {halfCostPerk}");
        }

        public static (int, int) GetRequiredAspectCount(Settings settings, SkillLevel skillLevel)
        {
            switch (skillLevel)
            {
                case SkillLevel.Novice:
                    return (settings.NoviceAspects, settings.NoviceUniqueAspects);
                case SkillLevel.Apprentice:
                    return (settings.ApprenticeAspects, settings.ApprenticeUniqueAspects);
                case SkillLevel.Adept:
                    return (settings.AdeptAspects, settings.AdeptUniqueAspects);
                case SkillLevel.Expert:
                    return (settings.ExpertAspects, settings.ExpertUniqueAspects);
                case SkillLevel.Master:
                    return (settings.MasterAspects, settings.MasterUniqueAspects);
                default:
                    throw new Exception($"Unexpected SkillLevel: {skillLevel}");
            }
        }
    }
}
