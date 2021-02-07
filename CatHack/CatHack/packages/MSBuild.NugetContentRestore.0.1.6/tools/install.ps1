param($installPath, $toolsPath, $package, $project)

$projectPath = (Get-Project).FullName
$buildProject = @([Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($projectPath))[0]

$target = $buildProject.Xml.Targets | Where { $_.Name -eq "BeforeBuild" } | Select -First 1
If ($target -eq $Null) {
	$target = $buildProject.Xml.AddTarget("BeforeBuild")
}

$task = $target.Tasks | Where { $_.Name -eq "NugetContentRestoreTask" } | Select -First 1
If ($task -eq $Null) {
	$task = $target.AddTask("NugetContentRestoreTask")
	$task.SetParameter("SolutionDir", "`$(SolutionDir)")
	$task.SetParameter("ProjectDir", "`$(ProjectDir)")

	$buildProject.Save()
	$project.Save()
}