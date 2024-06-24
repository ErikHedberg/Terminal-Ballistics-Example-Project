// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PluginTestEditorTarget : TargetRules
{
	public PluginTestEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "PluginTest" } );
	}
}
