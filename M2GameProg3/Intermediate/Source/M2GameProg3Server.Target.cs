using UnrealBuildTool;

public class M2GameProg3ServerTarget : TargetRules
{
	public M2GameProg3ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("M2GameProg3");
	}
}
