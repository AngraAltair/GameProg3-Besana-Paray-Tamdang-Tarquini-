using UnrealBuildTool;

public class M2GameProg3EditorTarget : TargetRules
{
	public M2GameProg3EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("M2GameProg3");
	}
}
