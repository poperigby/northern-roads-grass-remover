using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace NorthernRoadsGrassRemover
{
    public record Settings
    {
        [Tooltip("A list of landscape textures that should have their grass removed")]
        public List<String> TexturesToClean = new List<String>
        {
            "LBlackreachDirt",
            "LCoastBeach01",
            "LCoastBeach02",
            "LDirt01",
            "LDirt02",
            "LDirtPath01",
            "LDirtSnowPath01",
            "LFallForestDirt01",
            "LFallForestGrass01NoGrass",
            "LFallForestRocks01NoRocks",
            "LFieldGrass01NoGrass",
            "LFieldGrass01NoGrassNG",
            "LFieldGrass02NoGrass",
            "LFrozenMarshDirtSlopes01",
            "LFrozenMarshGrass01NoGrass",
            "LFrozenMarshIce01",
            "LFrozenMarshLichen01NoGrass",
            "LGrassSnow01NoGrass",
            "LPineForest01",
            "LPineForest02NG",
            "LPineForest02NoGrass",
            "LPineForest03NoGrass",
            "LReachDirt01",
            "LReachGrass01NoGrass",
            "LReachMossyRocks01NoRocks",
            "LSnow01",
            "LSnow02",
            "LTundra01NoGrass",
            "LTundraRocks01NoRocks",
            "LVolcanicTundraDirt01NoGrass",
        };
    }
}
