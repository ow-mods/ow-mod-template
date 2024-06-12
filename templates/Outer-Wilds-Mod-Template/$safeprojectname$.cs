using OWML.Common;
using OWML.ModHelper;

namespace $safeprojectname$;

public class $safeprojectname$ : ModBehaviour
{
	public static $safeprojectname$ Instance;
#if( usesNH )
	public INewHorizons NewHorizons;
#endif

	private void Awake()
	{
		Instance = this;
		// You won't be able to access OWML's mod helper in Awake.
		// So you probably don't want to do anything here.
		// Use Start() instead.
	}

	private void Start()
	{
		// Starting here, you'll have access to OWML's mod helper.
		ModHelper.Console.WriteLine($"My mod {nameof($safeprojectname$)} is loaded!", MessageType.Success);
#if( usesNH )

		// Get the New Horizons API and load configs
		NewHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
		NewHorizons.LoadConfigs(this);
#endif

		// Example of accessing game code.
		LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
		{
			if (loadScene != OWScene.SolarSystem) return;
			ModHelper.Console.WriteLine("Loaded into solar system!", MessageType.Success);
		};
	}
}

