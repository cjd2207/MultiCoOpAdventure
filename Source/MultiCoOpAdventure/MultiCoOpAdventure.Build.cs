// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MultiCoOpAdventure : ModuleRules
{
	public MultiCoOpAdventure(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"OnlineSubsystem",
            "OnlineSubsystemSteam"
        });

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MultiCoOpAdventure",
			"MultiCoOpAdventure/Variant_Platforming",
			"MultiCoOpAdventure/Variant_Platforming/Animation",
			"MultiCoOpAdventure/Variant_Combat",
			"MultiCoOpAdventure/Variant_Combat/AI",
			"MultiCoOpAdventure/Variant_Combat/Animation",
			"MultiCoOpAdventure/Variant_Combat/Gameplay",
			"MultiCoOpAdventure/Variant_Combat/Interfaces",
			"MultiCoOpAdventure/Variant_Combat/UI",
			"MultiCoOpAdventure/Variant_SideScrolling",
			"MultiCoOpAdventure/Variant_SideScrolling/AI",
			"MultiCoOpAdventure/Variant_SideScrolling/Gameplay",
			"MultiCoOpAdventure/Variant_SideScrolling/Interfaces",
			"MultiCoOpAdventure/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
