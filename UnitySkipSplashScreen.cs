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

#if !UNITY_EDITOR
using UnityEngine;
using UnityEngine.Rendering;

public sealed class UnitySkipSplashScreen
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void BeforeSplashScreen()
    {
#if UNITY_WEBGL
        Application.focusChanged += Application_focusChanged;
#else
        System.Threading.Tasks.Task.Run(AsyncSkip);
#endif
    }

#if UNITY_WEBGL
    private static void Application_focusChanged(bool obj)
    {
        Application.focusChanged -= Application_focusChanged;
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    }

#else
    private static void AsyncSkip()
    {
#if UNITY_ANDROID || UNITY_IOS || UNITY_STANDALONE || UNITY_WSA
#if UNITY_XR
        if (UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        }
        else
        {
            UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager.InitializeLoader();
            UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager.StartSubsystems();
            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        }
#else
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
#endif
#endif
    }
#endif
}
#endif