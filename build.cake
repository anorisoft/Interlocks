#load ./Tools/GlobalSettings/Addins.cake

Environment.SetVariableNames();

BuildParameters.SetParameters(
	context: Context,
	buildSystem: BuildSystem,
	title: "Interlocks",
	shouldRunDupFinder: false
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context, buildMSBuildToolVersion: MSBuildToolVersion.VS2019 );
