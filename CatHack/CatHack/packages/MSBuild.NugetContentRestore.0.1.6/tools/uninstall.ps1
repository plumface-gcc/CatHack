param($installPath, $toolsPath, $package, $project)

$projectPath = (Get-Project).FullName
$buildProject = @([Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($projectPath))[0]

$target = $buildProject.Xml.Targets | Where { $_.Name -eq "BeforeBuild" } | Select -First 1
If ($target -ne $Null) {
	$task = $target.Tasks | Where { $_.Name -eq "NugetContentRestoreTask" } | Select -First 1
	If ($task -ne $Null) {
		$target.RemoveChild($task)

		$buildProject.Save()
		$project.Save()
	}
}

