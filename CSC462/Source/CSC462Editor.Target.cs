// Copyright 2016 Derek Fletcher, All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CSC462EditorTarget : TargetRules
{
	public CSC462EditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "CSC462" } );
	}
}
