function krawl::create( %this )
{
	exec("./gui/guiProfiles.cs");
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	exec("./scripts/background.cs");
	createSceneWindow();
	createScene();
	mySceneWindow.setScene(myScene);
	createBackground();
	//myScene.setDebugOn("collision", "position", "aabb");
}

function krawl::destroy( %this )
{
	destroySceneWindow();
}