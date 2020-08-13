namespace CommonGames.Utilities.Singletons
{
	/// <summary> <see cref="EnsuredSingleton"/> that persists across multiple scenes </summary>
	public abstract class PersistentEnsuredSingleton<T> : EnsuredSingleton<T> where T : EnsuredSingleton<T>
	{
		protected override void OnEnable()
		{
			base.OnEnable();
			DontDestroyOnLoad(gameObject);
		}
	}
}