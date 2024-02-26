**[🇷🇺 Read this in Russian](README_RU.md)**

<h1 align="center">⭐ Unity Skip Splash Screen ⭐</h1>
<p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/RimuruDev/UnitySkipSplashScreen?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/UnitySkipSplashScreen?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/UnitySkipSplashScreen?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/UnitySkipSplashScreen/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/UnitySkipSplashScreen?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/UnitySkipSplashScreen?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/UnitySkipSplashScreen?style=flat">
  </a>
</p>

This package allows for the quick and easy removal of the Unity Splash Screen at the start of an application. It is suitable for developers who wish to immediately proceed to the content of their application without displaying the initial Unity Splash Screen.

## How to Use

To use this package, follow these steps:

1. Open your project in Unity.
2. Go to `Window -> Package Manager -> Add package from git URL...`.
3. Insert the git repository URL: `https://github.com/RimuruDev/UnitySkipSplashScreen.git`.
4. Click `Add` and wait for the package installation to complete.

After installation, the package will automatically configure your project to skip the Unity Splash Screen at startup.

## How It Works

The package contains two main components:

- `SetSplashScreenBlack`: This script operates within the Unity editor and automatically sets the Unity Splash Screen to a dark background with the Unity logo in "Light on Dark" style before each project build.
- `UnitySkipSplashScreen`: This script operates in the built application and skips the Unity Splash Screen at startup, allowing the user to immediately proceed to the main content.

Old Source -> https://github.com/Jadekylin/UnitySkipSplash
