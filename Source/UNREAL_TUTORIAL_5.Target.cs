// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UNREAL_TUTORIAL_5Target : TargetRules
{
	public UNREAL_TUTORIAL_5Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UNREAL_TUTORIAL_5" } );
	}
}
