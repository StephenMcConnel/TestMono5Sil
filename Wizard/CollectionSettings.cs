using System;
using System.IO;

namespace TestMono5Sil
{
	public class NewCollectionSettings : CollectionSettings
	{
		public string PathToSettingsFile;
	}

	public class CollectionSettings
	{
		public WritingSystem Language1;
		public WritingSystem Language2;
		public WritingSystem Language3;
		public WritingSystem[] LanguagesZeroBased;
		public string CollectionName;

		public CollectionSettings()
		{
			Func<string> getCodeOfDefaultLanguageForNaming = () => Language2.Iso639Code;
			Language1 = new WritingSystem(1, getCodeOfDefaultLanguageForNaming);
			Language2 = new WritingSystem(2, getCodeOfDefaultLanguageForNaming);
			Language3 = new WritingSystem(3, getCodeOfDefaultLanguageForNaming);
			LanguagesZeroBased = new WritingSystem[3];
			this.LanguagesZeroBased[0] = Language1;
			this.LanguagesZeroBased[1] = Language2;
			this.LanguagesZeroBased[2] = Language3;

			CollectionName = "dummy collection";
		}

		public CollectionSettings(NewCollectionSettings collectionInfo)
			: this(collectionInfo.PathToSettingsFile)
		{
		}

		public CollectionSettings(string desiredOrExistingSettingsFilePath)
			: this()
		{
			SettingsFilePath = desiredOrExistingSettingsFilePath;
			CollectionName = Path.GetFileNameWithoutExtension(desiredOrExistingSettingsFilePath);
		}

		public string SettingsFilePath { get; internal set; }
		public bool IsSourceCollection { get; internal set; }
		public string Country { get; internal set; }
		public string Province { get; internal set; }
		public string District { get; internal set; }

		public static string GetPathForNewSettings(string parentFolderPath, string newCollectionName)
		{
			return Path.Combine(parentFolderPath, newCollectionName, newCollectionName + ".bloomCollection");
		}
	}
}