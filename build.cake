#addin nuget:?package=Cake.Json&version=4.0.0
#addin nuget:?package=Newtonsoft.Json&version=11.0.2

#load ./Tools/GlobalSettings/Addins.cake
GlobalSettings.PrintGlobalSettings(Context);

Environment.SetVariableNames();

BuildParameters.SetParameters(
	context: Context,
	buildSystem: BuildSystem,
	title: "Interlocks",
	shouldRunDupFinder: false,
	shouldRunDotNetCorePack: true,
	repositoryOwner: "anorisoft"
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);
