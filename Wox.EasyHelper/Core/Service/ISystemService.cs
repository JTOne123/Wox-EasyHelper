﻿namespace Wox.EasyHelper.Core.Service
{
    public interface ISystemService
    {
        string ApplicationDataPath { get; }

        void OpenUrl(string url);

        void StartCommandLine(string command, string arguments);
    }
}