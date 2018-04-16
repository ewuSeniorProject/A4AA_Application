using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace A4AA_Application.Utils
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters.
  /// </summary>
  public static class Settings
{
	private static ISettings AppSettings
	{
		get
		{
			return CrossSettings.Current;
		}
	}

	#region Setting Constants

	private const string LastUsedUsernameSettingsKey = "last_used_username_settings_key";
	private static readonly string SettingsDefault = string.Empty;
	private const string LastUsedPasswordSettingsKey = "last_used_password_settings_key";

		#endregion


		public static string LastUsedUsername
	{
		get
		{
			return AppSettings.GetValueOrDefault(LastUsedUsernameSettingsKey, SettingsDefault);
		}
		set
		{
			AppSettings.AddOrUpdateValue(LastUsedUsernameSettingsKey, value);
		}
	}

		public static string LastUsedPassword
		{
			get
			{
				return AppSettings.GetValueOrDefault(LastUsedPasswordSettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(LastUsedPasswordSettingsKey, value);
			}
		}

	}
}