using UnrealBuildTool;

public class M2GameProg3ClientTarget : TargetRules
{
	public M2GameProg3ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("M2GameProg3");
	}
}
