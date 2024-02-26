**[en Read this in English](README.md)**

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



Этот пакет позволяет быстро и легко убрать заставку Unity при запуске приложения. Подходит для разработчиков, желающих сразу перейти к содержанию своего приложения без отображения начального Splash Screen от Unity.

## Как использовать

Для использования пакета выполните следующие шаги:

1. Откройте ваш проект в Unity.
2. Перейдите в `Window -> Package Manager -> Add package from git URL...`.
3. Вставьте ссылку на git-репозиторий: `https://github.com/RimuruDev/UnitySkipSplashScreen.git`.
4. Нажмите `Add` и дождитесь окончания установки пакета.

После установки пакет автоматически настроит ваш проект на пропуск заставки Unity при запуске.

## Как это работает

Пакет содержит два основных компонента:

- `SetSplashScreenBlack`: Этот скрипт работает в редакторе Unity и автоматически настраивает заставку Unity на темный фон с логотипом Unity в стиле "Light on Dark" перед каждой сборкой проекта.
- `UnitySkipSplashScreen`: Этот скрипт работает в собранном приложении и пропускает заставку Unity при запуске приложения, позволяя пользователю сразу перейти к основному содержанию.

Old Source -> https://github.com/Jadekylin/UnitySkipSplash
