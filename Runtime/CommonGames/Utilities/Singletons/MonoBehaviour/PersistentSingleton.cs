namespace CommonGames.Utilities.Singletons
{
	/// <summary> Singleton that persists across multiple scenes </summary>
	public class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		protected override void OnEnable()
		{
			base.OnEnable();

			if(UnityEngine.Application.isPlaying)
			{
				DontDestroyOnLoad(gameObject);
			}
			
		}
	}
}