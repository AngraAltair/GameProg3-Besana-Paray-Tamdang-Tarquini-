using UnrealBuildTool;

public class M2GameProg3Target : TargetRules
{
	public M2GameProg3Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("M2GameProg3");
	}
}
