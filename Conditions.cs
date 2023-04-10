using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using SCMod = Mutagen.Bethesda.FormKeys.SkyrimSE.SpellConstruction;

namespace SpellConstruction
{
    internal class Conditions
    {
        public static ConstructibleObject GenerateBaseRecipe(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, IConstructibleGetter construction, string editorId)
        {
            var recipe = state.PatchMod.ConstructibleObjects.AddNew();
            recipe.EditorID = $"SCRecipe{editorId}";
            recipe.WorkbenchKeyword = SCMod.Keyword.SCCraftingSpellbook.AsNullable();
            recipe.CreatedObjectCount = 1;
            recipe.CreatedObject = construction.ToNullableLink();
            recipe.Items = new Noggog.ExtendedList<ContainerEntry>();
            return recipe;
        }

        public static ConditionFloat GetEffectKnownCondition(IIngredientGetter ingredient, int effectIndex)
        {
            IFormLink<IPlacedObjectGetter> container;
            switch (effectIndex)
            {
                case 0:
                    container = SCMod.PlacedObject.SC1stEffectKnownContainer;
                    break;
                case 1:
                    container = SCMod.PlacedObject.SC2ndEffectKnownContainer;
                    break;
                case 2:
                    container = SCMod.PlacedObject.SC3rdEffectKnownContainer;
                    break;
                case 3:
                    container = SCMod.PlacedObject.SC4thEffectKnownContainer;
                    break;
                default:
                    Console.WriteLine($"Unexpected index of effects ({effectIndex}) on ingredient {ingredient.FormKey.ModKey} - {ingredient.EditorID}");
                    return null;
            }

            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.GreaterThanOrEqualTo;
            condition.ComparisonValue = 1;
            var data = new GetItemCountConditionData();
            data.RunOnType = Condition.RunOnType.Reference;
            data.ItemOrList.Link.SetTo(ingredient);
            data.Reference = container;
            condition.Data = data;
            return condition;
        }

        public static ConditionFloat GetObjectEffectKnownCondition(IObjectEffectGetter enchantment)
        {
            IFormLink<IEffectRecordGetter> effect;
            if (!enchantment.BaseEnchantment.IsNull)
            {
                effect = enchantment.BaseEnchantment.Cast<IEffectRecordGetter>();
            }
            else
            {
                effect = enchantment.ToLink();
            }

            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.EqualTo;
            condition.ComparisonValue = 1;
            var data = new PlayerKnowsConditionData();
            data.Knowable.Link.SetTo(effect.FormKey);
            data.RunOnType = Condition.RunOnType.Subject;
            condition.Data = data;
            return condition;
        }

        public static ConditionFloat GetSpellKnownCondition(IFormLink<ISpellGetter> spell)
        {
            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.EqualTo;
            condition.ComparisonValue = 1;
            var data = new HasSpellConditionData();
            data.RunOnType = Condition.RunOnType.Subject;
            data.Spell.Link.SetTo(spell);
            condition.Data = data;
            return condition;
        }

        public static ConditionFloat GetRequiredCountCondition(IFormLink<IItemGetter> item, int quantity = 1)
        {
            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.GreaterThanOrEqualTo;
            condition.ComparisonValue = quantity;
            var data = new GetItemCountConditionData();
            data.RunOnType = Condition.RunOnType.Subject;
            data.ItemOrList.Link.SetTo(item.FormKey);
            condition.Data = data;
            return condition;
        }

        public static void SetRitualQuestCondition(ConstructibleObject recipe, Skill skill, SkillLevel skillLevel)
        {
            if (skillLevel != SkillLevel.Master)
            {
                return;
            }

            IFormLink<IGlobalGetter> questCompletedGlobal;
            switch (skill)
            {
                case Skill.Alteration:
                    questCompletedGlobal = Skyrim.Global.MGRitualAltBook;
                    break;
                case Skill.Conjuration:
                    questCompletedGlobal = Skyrim.Global.MGRitualConjBook;
                    break;
                case Skill.Destruction:
                    questCompletedGlobal = Skyrim.Global.MGRitualDestBook;
                    break;
                case Skill.Illusion:
                    questCompletedGlobal = Skyrim.Global.MGRitualIllBook;
                    break;
                case Skill.Restoration:
                    questCompletedGlobal = Skyrim.Global.MGRitualRestBook;
                    break;
                default:
                    return;
            }

            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.EqualTo;
            condition.ComparisonValue = 0;
            var data = new GetGlobalValueConditionData();
            data.RunOnType = Condition.RunOnType.Subject;
            data.Global.Link.SetTo(questCompletedGlobal);
            condition.Data = data;

            recipe.Conditions.Add(condition);
        }

        public static void SetSkillLevelCondition(Settings settings, ConstructibleObject recipe, Skill skill, SkillLevel skillLevel)
        {
            int requiredSkill = 0;
            switch (skillLevel)
            {
                case SkillLevel.Novice:
                    return;
                case SkillLevel.Apprentice:
                    requiredSkill = settings.TomesAvailableApprentice;
                    break;
                case SkillLevel.Adept:
                    requiredSkill = settings.TomesAvailableAdept;
                    break;
                case SkillLevel.Expert:
                    requiredSkill = settings.TomesAvailableExpert;
                    break;
                case SkillLevel.Master:
                    requiredSkill = settings.TomesAvailableMaster;
                    break;
            }

            var condition = new ConditionFloat();
            condition.CompareOperator = CompareOperator.GreaterThanOrEqualTo;
            condition.ComparisonValue = requiredSkill;
            var data = new GetActorValueConditionData();
            data.RunOnType = Condition.RunOnType.Subject;
            data.ActorValue = (ActorValue)skill;
            condition.Data = data;

            recipe.Conditions.Add(condition);
        }
    }
}
