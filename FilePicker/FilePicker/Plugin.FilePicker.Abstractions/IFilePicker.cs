﻿using System;
using System.Threading.Tasks;

namespace Plugin.FilePicker.Abstractions
{
	/// <summary>
	/// Interface for FilePicker
	/// </summary>
	public interface IFilePicker
	{
		Task<FileData> PickFile();
		Task<FileData> PickPicture();
		Task<FileData> PickVideo();

		Task<bool> SaveFile(FileData fileToSave);

		void OpenFile(string fileToOpen);

		void OpenFile(FileData fileToOpen);
	}
}
