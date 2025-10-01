// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HybridFP_TP_Project : ModuleRules
{
	public HybridFP_TP_Project(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"HybridFP_TP_Project",
			"HybridFP_TP_Project/Variant_Platforming",
			"HybridFP_TP_Project/Variant_Platforming/Animation",
			"HybridFP_TP_Project/Variant_Combat",
			"HybridFP_TP_Project/Variant_Combat/AI",
			"HybridFP_TP_Project/Variant_Combat/Animation",
			"HybridFP_TP_Project/Variant_Combat/Gameplay",
			"HybridFP_TP_Project/Variant_Combat/Interfaces",
			"HybridFP_TP_Project/Variant_Combat/UI",
			"HybridFP_TP_Project/Variant_SideScrolling",
			"HybridFP_TP_Project/Variant_SideScrolling/AI",
			"HybridFP_TP_Project/Variant_SideScrolling/Gameplay",
			"HybridFP_TP_Project/Variant_SideScrolling/Interfaces",
			"HybridFP_TP_Project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
