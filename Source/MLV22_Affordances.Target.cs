// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MLV22_AffordancesTarget : TargetRules
{
	public MLV22_AffordancesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MLV22_Affordances" } );
	}
}
