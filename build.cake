#addin nuget:?package=Cake.Json&version=4.0.0
#addin nuget:?package=Newtonsoft.Json&version=11.0.2

#load ./Tools/GlobalSettings/Addins.cake

Environment.SetVariableNames();

BuildParameters.SetParameters(
	context: Context,
	buildSystem: BuildSystem,
	title: "Interlocks",
	shouldRunDupFinder: true,
	shouldRunDotNetCorePack: true
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);
