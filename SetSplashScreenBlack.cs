// Resharper disable all
// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//          - GitHubRepo: https://github.com/RimuruDev/UnitySkipSplashScreen.git
//
// **************************************************************** //

#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public sealed class SetSplashScreenBlack : IPreprocessBuildWithReport
{
    public int callbackOrder { get; }

    public void OnPreprocessBuild(BuildReport report)
    {
        PlayerSettings.SplashScreen.unityLogoStyle = PlayerSettings.SplashScreen.UnityLogoStyle.LightOnDark;
        PlayerSettings.SplashScreen.backgroundColor = Color.black;
    }
}
#endif