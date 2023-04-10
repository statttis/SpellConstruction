using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace SpellConstruction
{
    internal class Settings
    {
        [SettingName("Limit constructible spell tomes to those that appear at vendors or in loot")]
        public bool FilterSpellTomesByLeveledList { get; set; } = true;
        [SettingName("Spell tomes to exclude ([mod name]:[form id], separated by | e.g. MyMod.esp:00001D8A|MyMod.esp:00001D8C)")]
        public string SpellTomeExclusion { get; set; } = "Vigilant.esm:000C5853|Vigilant.esm:000D429C|Vigilant.esm:000EFC35|Vigilant.esm:000F6B57|Vigilant.esm:000FD09F|Vigilant.esm:0010C89F|Vigilant.esm:0010D83D|Vigilant.esm:0010D83F|Vigilant.esm:0010F6AD|Vigilant.esm:0010F6B5|Vigilant.esm:00110C71|Vigilant.esm:00110C76|Vigilant.esm:00110C7B|Vigilant.esm:00110C80|Vigilant.esm:00110C85|Vigilant.esm:00110C8A|Vigilant.esm:001125A1|Vigilant.esm:00113C49|Vigilant.esm:00113C50|Vigilant.esm:00115EBC|Vigilant.esm:0011672B|Vigilant.esm:0011672D|Vigilant.esm:0011672E|Vigilant.esm:0011672F|Vigilant.esm:00116730|Vigilant.esm:00116731|Vigilant.esm:0011E0A5|Vigilant.esm:0012A7B4|Vigilant.esm:0012A7B9|Vigilant.esm:0012BB72|Vigilant.esm:0012BB74|Vigilant.esm:0013B506|Vigilant.esm:0013BAB0|Vigilant.esm:00140504|Vigilant.esm:00152144|Vigilant.esm:00194C3A|Vigilant.esm:0019EB9B|Vigilant.esm:001B923A|Vigilant.esm:001BA56D|Vigilant.esm:001BCBCA|Vigilant.esm:001BCBD2|Vigilant.esm:001E2C33|Vigilant.esm:0022A05A|Vigilant.esm:0023611B|Vigilant.esm:002C241B|Vigilant.esm:0051D5D2|Vigilant.esm:0003B3A1|Vigilant.esm:0003B3A3|Vigilant.esm:0003B3A4|Vigilant.esm:00273505|Vigilant.esm:002C2417|Vigilant.esm:002C2419|Vigilant.esm:002C241A|Vigilant.esm:002C241B|Vigilant.esm:002F2036";
        [SettingName("Mods to exclude spell tomes from (separated by | e.g. MyMod1.esp|MyMod2.esp)")]
        public string ModExclusion { get; set; } = "";
        [SettingName("Spell tomes to include, overriding any limits/exclusions ([mod name]:[form id], separated by | e.g. MyMod.esp:00001D8A|MyMod.esp:00001D8C)")]
        public string SpellTomeInclusion { get; set; } = "ccBGSSSE002-ExoticArrows.esl:00000816|ccBGSSSE002-ExoticArrows.esl:0000082B|ccbgssse014-spellpack01.esl:00000815|ccbgssse014-spellpack01.esl:00000816|ccbgssse014-spellpack01.esl:00000817|ccbgssse014-spellpack01.esl:00000818|ccbgssse014-spellpack01.esl:00000861|ccbgssse014-spellpack01.esl:00000862|ccbgssse014-spellpack01.esl:00000863|ccbgssse014-spellpack01.esl:00000864|ccbgssse014-spellpack01.esl:00000865|ccbgssse014-spellpack01.esl:00000866|ccbgssse014-spellpack01.esl:00000867|ccbgssse014-spellpack01.esl:00000868|ccbgssse014-spellpack01.esl:00000869|ccbgssse014-spellpack01.esl:0000086A|ccbgssse014-spellpack01.esl:0000086B|ccbgssse014-spellpack01.esl:0000086C|ccBGSSSE067-DaedInv.esm:00000B64|ccBGSSSE067-DaedInv.esm:00147D93|ccKRTSSE001_Altar.esl:00000CE1|Dwarfsphere.esp:00A68B94|Dwarfsphere.esp:00A68B98|Dwarfsphere.esp:00A68B9E|Dwarfsphere.esp:00B62BC8|HeartOfTheReach.esp:00096175|Requiem - Magic Redone.esp:00005C04|Skyrim.esm:000F4997|Dawnguard.esm:000045B0|Dawnguard.esm:000045B1|Dawnguard.esm:000045B2|Apocalypse - Magic of Skyrim.esp:0003C517|Apocalypse - Magic of Skyrim.esp:00089703|Apocalypse - Magic of Skyrim.esp:0003C51A|Apocalypse - Magic of Skyrim.esp:0003C51B|Apocalypse - Magic of Skyrim.esp:0003C519|Apocalypse - Magic of Skyrim.esp:0003C51D|Apocalypse - Magic of Skyrim.esp:0003C51E|Apocalypse - Magic of Skyrim.esp:0003C522|Apocalypse - Magic of Skyrim.esp:0003C521|Apocalypse - Magic of Skyrim.esp:0003C520|Apocalypse - Magic of Skyrim.esp:0003C528|Apocalypse - Magic of Skyrim.esp:0003C526|Apocalypse - Magic of Skyrim.esp:0003C52B|Apocalypse - Magic of Skyrim.esp:0005F257|Apocalypse - Magic of Skyrim.esp:00089705|Apocalypse - Magic of Skyrim.esp:00047E25|Apocalypse - Magic of Skyrim.esp:0003C530|Apocalypse - Magic of Skyrim.esp:0003C52D|Apocalypse - Magic of Skyrim.esp:00089706|Apocalypse - Magic of Skyrim.esp:0003D042|Apocalypse - Magic of Skyrim.esp:0003D044|Apocalypse - Magic of Skyrim.esp:0003D047|Apocalypse - Magic of Skyrim.esp:0003D04D|Apocalypse - Magic of Skyrim.esp:0003D04C|Apocalypse - Magic of Skyrim.esp:0003D04E|Apocalypse - Magic of Skyrim.esp:0003D5B5|Apocalypse - Magic of Skyrim.esp:0003D5B6|Apocalypse - Magic of Skyrim.esp:00089707|Apocalypse - Magic of Skyrim.esp:0003D5BC|Apocalypse - Magic of Skyrim.esp:0003DB1F|Apocalypse - Magic of Skyrim.esp:0003DB20|Apocalypse - Magic of Skyrim.esp:00089709|Apocalypse - Magic of Skyrim.esp:0003DB22|Apocalypse - Magic of Skyrim.esp:0003DB21|Apocalypse - Magic of Skyrim.esp:0003DB23|Apocalypse - Magic of Skyrim.esp:0003DB26|Apocalypse - Magic of Skyrim.esp:0003DB25|Apocalypse - Magic of Skyrim.esp:0003DB27|Apocalypse - Magic of Skyrim.esp:0003DB28|Apocalypse - Magic of Skyrim.esp:0003DB29|Apocalypse - Magic of Skyrim.esp:0003DB2A|Apocalypse - Magic of Skyrim.esp:0003DB2B|Apocalypse - Magic of Skyrim.esp:0003DB2C|Apocalypse - Magic of Skyrim.esp:0003E094|Apocalypse - Magic of Skyrim.esp:0003E092|Apocalypse - Magic of Skyrim.esp:0003E08F|Apocalypse - Magic of Skyrim.esp:0003E091|Apocalypse - Magic of Skyrim.esp:0003E093|Apocalypse - Magic of Skyrim.esp:0003E090|Apocalypse - Magic of Skyrim.esp:0003E095|Apocalypse - Magic of Skyrim.esp:0003E099|Apocalypse - Magic of Skyrim.esp:0003E096|Apocalypse - Magic of Skyrim.esp:0003E097|Apocalypse - Magic of Skyrim.esp:0005E219|Apocalypse - Magic of Skyrim.esp:0003E098|Apocalypse - Magic of Skyrim.esp:0008970A|Apocalypse - Magic of Skyrim.esp:0008970B|Apocalypse - Magic of Skyrim.esp:0003E09A|Apocalypse - Magic of Skyrim.esp:00047345|Apocalypse - Magic of Skyrim.esp:0003E601|Apocalypse - Magic of Skyrim.esp:0003E5FF|Apocalypse - Magic of Skyrim.esp:0003E602|Apocalypse - Magic of Skyrim.esp:0003E603|Apocalypse - Magic of Skyrim.esp:0003E600|Apocalypse - Magic of Skyrim.esp:0003E604|Apocalypse - Magic of Skyrim.esp:0003E605|Apocalypse - Magic of Skyrim.esp:0003E607|Apocalypse - Magic of Skyrim.esp:0003E609|Apocalypse - Magic of Skyrim.esp:0003E60C|Apocalypse - Magic of Skyrim.esp:0003E60F|Apocalypse - Magic of Skyrim.esp:0003E613|Apocalypse - Magic of Skyrim.esp:0003E616|Apocalypse - Magic of Skyrim.esp:0003E611|Apocalypse - Magic of Skyrim.esp:0003E614|Apocalypse - Magic of Skyrim.esp:0008970E|Apocalypse - Magic of Skyrim.esp:0003EB7B|Apocalypse - Magic of Skyrim.esp:0003EB7C|Apocalypse - Magic of Skyrim.esp:0003EB7E|Apocalypse - Magic of Skyrim.esp:0003EB7F|Apocalypse - Magic of Skyrim.esp:0003EB80|Apocalypse - Magic of Skyrim.esp:0003EB81|Apocalypse - Magic of Skyrim.esp:0003EB83|Apocalypse - Magic of Skyrim.esp:0003EB85|Apocalypse - Magic of Skyrim.esp:0003EB87|Apocalypse - Magic of Skyrim.esp:0003EB88|Apocalypse - Magic of Skyrim.esp:0003EB8A|Apocalypse - Magic of Skyrim.esp:0003EB89|Apocalypse - Magic of Skyrim.esp:0003EB8E|Apocalypse - Magic of Skyrim.esp:0003EB8D|Apocalypse - Magic of Skyrim.esp:0003EB8C|Apocalypse - Magic of Skyrim.esp:0003EB8B|Apocalypse - Magic of Skyrim.esp:00047343|Apocalypse - Magic of Skyrim.esp:0003EB8F|Apocalypse - Magic of Skyrim.esp:00089711";
        [SettingName("Multiplier on required aspects for spells that are 'rare' - not easily purchased/found")]
        public double RareSpellTomeMultiplier { get; set; } = 1.5;
        [SettingName("Spell tomes that are considered rare ([mod name]:[form id], separated by | e.g. MyMod.esp:00001D8A|MyMod.esp:00001D8C)")]
        public string RareSpellTomes { get; set; } = "ccbgssse014-spellpack01.esl:00000815|ccbgssse014-spellpack01.esl:00000816|ccbgssse014-spellpack01.esl:00000817|ccbgssse014-spellpack01.esl:00000818|ccbgssse014-spellpack01.esl:00000861|ccbgssse014-spellpack01.esl:00000862|ccbgssse014-spellpack01.esl:00000863|ccbgssse014-spellpack01.esl:00000864|ccbgssse014-spellpack01.esl:00000865|ccbgssse014-spellpack01.esl:00000866|ccbgssse014-spellpack01.esl:00000867|ccbgssse014-spellpack01.esl:00000868|ccbgssse014-spellpack01.esl:00000869|ccbgssse014-spellpack01.esl:0000086A|ccbgssse014-spellpack01.esl:0000086B|ccbgssse014-spellpack01.esl:0000086C|ccBGSSSE067-DaedInv.esm:00000B64|ccBGSSSE067-DaedInv.esm:00147D93|Dwarfsphere.esp:00A68B94|Dwarfsphere.esp:00A68B98|Dwarfsphere.esp:00A68B9E|Dwarfsphere.esp:00B62BC8|HeartOfTheReach.esp:00096175|Requiem - Magic Redone.esp:00005C04|Skyrim.esm:000F4997|Dawnguard.esm:000045B0|Dawnguard.esm:000045B1|Dawnguard.esm:000045B2";
        [SettingName("Required number of aspects for novice spells")]
        public int NoviceAspects { get; set; } = 5;
        [SettingName("Required number of aspects for apprentice spells")]
        public int ApprenticeAspects { get; set; } = 7;
        [SettingName("Required number of aspects for adept spells")]
        public int AdeptAspects { get; set; } = 10;
        [SettingName("Required number of aspects for expert spells")]
        public int ExpertAspects { get; set; } = 15;
        [SettingName("Required number of aspects for master spells")]
        public int MasterAspects { get; set; } = 23;
        [SettingName("Required number of unique aspects for novice spells")]
        public int NoviceUniqueAspects { get; set; } = 4;
        [SettingName("Required number of unique aspects for apprentice spells")]
        public int ApprenticeUniqueAspects { get; set; } = 5;
        [SettingName("Required number of unique aspects for adept spells")]
        public int AdeptUniqueAspects { get; set; } = 7;
        [SettingName("Required number of unique aspects for expert spells")]
        public int ExpertUniqueAspects { get; set; } = 9;
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
        [SettingName("Total value of materials required to craft intents and methods")]
        public int IntentMethodRequiredValue { get; set; } = 400;
        [SettingName("Minimum quantity of materials required to craft intents and methods")]
        public int IntentMethodMinimumQuantity { get; set; } = 1;
        [SettingName("Maximum quantity of materials required to craft intents and methods")]
        public int IntentMethodMaximumQuantity { get; set; } = 40;
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
