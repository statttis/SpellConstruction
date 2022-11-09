using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace SpellConstruction
{
    internal class Settings
    {
        [SettingName("Limit constructible spell tomes to those that appear at vendors or in loot")]
        public bool FilterSpellTomesByLeveledList { get; set; } = false;
        [SettingName("Spell tomes to exclude ([mod name]:[form id], separated by | e.g. MyMod.esp:00001D8A|MyMod.esp:00001D8C)")]
        public string SpellTomeExclusion { get; set; } = "";
        [SettingName("Mods to exclude spell tomes from (separated by | e.g. MyMod1.esp|MyMod2.esp)")]
        public string ModExclusion { get; set; } = "Magic of the Magna-Ge.esp";
        [SettingName("Spell tomes to include, overriding any limits/exclusions ([mod name]:[form id], separated by | e.g. MyMod.esp:00001D8A|MyMod.esp:00001D8C)")]
        public string SpellTomeInclusion { get; set; } = "Skyrim.esm:000F4997";
        [SettingName("Required number of aspects for novice spells")]
        public int NoviceAspects { get; set; } = 3;
        [SettingName("Required number of aspects for apprentice spells")]
        public int ApprenticeAspects { get; set; } = 5;
        [SettingName("Required number of aspects for adept spells")]
        public int AdeptAspects { get; set; } = 8;
        [SettingName("Required number of aspects for expect spells")]
        public int ExpertAspects { get; set; } = 13;
        [SettingName("Required number of aspects for master spells")]
        public int MasterAspects { get; set; } = 21;
        [SettingName("Required number of unique aspects for novice spells")]
        public int NoviceUniqueAspects { get; set; } = 3;
        [SettingName("Required number of unique aspects for apprentice spells")]
        public int ApprenticeUniqueAspects { get; set; } = 4;
        [SettingName("Required number of unique aspects for adept spells")]
        public int AdeptUniqueAspects { get; set; } = 6;
        [SettingName("Required number of unique aspects for expert spells")]
        public int ExpertUniqueAspects { get; set; } = 8;
        [SettingName("Required number of unique aspects for master spells")]
        public int MasterUniqueAspects { get; set; } = 10;
        [SettingName("Number of different aspects available from skill books")]
        public int SkillBookAspects { get; set; } = 3;
        [SettingName("Number of different aspects available from enchanted weapons")]
        public int WeaponAspects { get; set; } = 3;
        [SettingName("Number of different aspects available from enchanted wearables")]
        public int ArmorAspects { get; set; } = 3;
        [SettingName("Number of different aspects available from scrolls")]
        public int ScrollAspects { get; set; } = 4;
        [SettingName("Minimum skill required to craft apprentice spell tomes")]
        public int TomesAvailableApprentice { get; set; } = 15;
        [SettingName("Minimum skill required to craft adept spell tomes")]
        public int TomesAvailableAdept { get; set; } = 40;
        [SettingName("Minimum skill required to craft expert spell tomes")]
        public int TomesAvailableExpert { get; set; } = 65;
        [SettingName("Minimum skill required to craft master spell tomes")]
        public int TomesAvailableMaster { get; set; } = 90;
        [SettingName("Ritual quest required to craft master spell tomes")]
        public bool MasterTomesRequireRitualQuest { get; set; } = true;
        [SettingName("Total value of materials required to craft fundamentals")]
        public int FundamentalRequiredValue { get; set; } = 500;
        [SettingName("Minimum quantity of materials required to craft fundamentals")]
        public int FundamentalMinimumQuantity { get; set; } = 1;
        [SettingName("Maximum quantity of materials required to craft fundamentals")]
        public int FundamentalMaximumQuantity { get; set; } = 50;
        [SettingName("Total value of materials required to craft intentions and methods")]
        public int IntentionMethodRequiredValue { get; set; } = 400;
        [SettingName("Minimum quantity of materials required to craft intentions and methods")]
        public int IntentionMethodMinimumQuantity { get; set; } = 1;
        [SettingName("Maximum quantity of materials required to craft intentions and methods")]
        public int IntentionMethodMaximumQuantity { get; set; } = 40;
        [SettingName("Minimum value of ingredient to be eligible for crafting aspects")]
        public int IngredientMinimumValue { get; set; } = 20;
        [SettingName("Total value of ingredients required to craft aspects")]
        public int IngredientRequiredValue { get; set; } = 500;
        [SettingName("Minimum quantity of ingredients required to craft aspects")]
        public int IngredientMinimumQuantity { get; set; } = 1;
        [SettingName("Maximum quantity of ingredients required to craft aspects")]
        public int IngredientMaximumQuantity { get; set; } = 50;
        public int ScoreMatchingKeyword { get; set; } = 10;
        public int ScoreMatchingArchetype { get; set; } = 10;
        public int ScoreMatchingActorValue { get; set; } = 15;
        public int ScoreMatchingPhrase { get; set; } = 1;
    }
}
