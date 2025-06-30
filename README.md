## ⚙️ Принцип работы

Приложение работает на основе технологии **распознавания изображений в дополненной реальности (AR Image Tracking)**, предоставляемой Unity через AR Foundation.

---

### 🔄 Общий процесс:

1. **Запуск приложения**
   - Пользователь открывает приложение на Android-смартфоне.
   - Автоматически активируется камера устройства через компонент `AR Session`.

2. **Наведение камеры на изображение**
   - Пользователь направляет камеру на одно из заранее подготовленных изображений — например:
     - Фото хаски
     - Изображение лабрадора
     - Иллюстрацию чихуахуа

3. **Распознавание породы**
   - `AR Tracked Image Manager` в режиме реального времени анализирует изображение через камеру.
   - Сравнивает его с библиотекой (`Reference Image Library`), в которую загружены фото пород.
   - При совпадении — Unity "узнаёт" имя изображения (например, `"husky"`).

4. **Отображение информации**
  <p align="center">
  <img src="https://github.com/user-attachments/assets/21eaa4d5-0f79-4fc4-82bd-f3ec26f7717d" alt="Форма ввода - Русский">
</p>
   - После распознавания, скрипт `DogImageTracker.cs` активирует на экране **UI-панель** `InfoPanel`.
   - На этой панели динамически появляется:
     - 🐾 **Название породы** (например, "Хаски")
     - 🖼️ **Изображение породы**
     - 📖 **Описание и рекомендации**:
       - Информация адаптирована под каждую породу
       - Указывается характер, поведение, условия ухода, советы владельцам

---

## 📸 Примеры распознанных пород

### 🐕 Лабрадор

<p align="center">
  <img src="https://github.com/user-attachments/assets/50df8d8c-b3a3-420d-b351-3ab3cb1d17d8" alt="Форма ввода - Русский">
</p>

---

### 🐺 Хаски

<p align="center">
  <img src="https://github.com/user-attachments/assets/1a720be4-a59b-42ea-8285-da4f46b33da5" alt="Форма ввода - Русский">
</p>

---

## 📝 Примечание

Изображения пород размещаются в папке `Resources`, а их имена должны точно соответствовать записям в Reference Image Library (`husky`, `labrador`, `chihuahua`). Это важно для правильной работы `switch-case` в скрипте `DogImageTracker.cs`.
## 🔧 Используемые технологии

- Unity 2022.3+
- AR Foundation (v5+)
- ARCore XR Plugin
- TextMeshPro (UI)
- C#
- Android SDK / ADB

---

## 📱 Как собрать под Android

1. Установите **Unity** и **Android Build Support**
2. Установите через Package Manager:
   - `AR Foundation`
   - `ARCore XR Plugin`
   - `XR Plugin Management`
3. Включите **ARCore**:
   - `Edit → Project Settings → XR Plugin Management → Android → ARCore`
4. В `Player Settings`:
   - **Camera Usage Description**: "Требуется для AR"
   - **Minimum API Level**: 24 или выше
   - Включите `AR Required` (в XR Settings)
5. Подключите телефон с включённой отладкой (`Developer Mode`)
6. Открой `File → Build Settings → Android → Build and Run`

---

## 📁 Структура проекта

```
Assets/
├── Scripts/
│   └── DogImageTracker.cs
├── Resources/
│   ├── husky.png
│   ├── labrador.png
│   └── chihuahua.png
├── Prefabs/
│   └── InfoPanel.prefab
├── Scenes/
│   └── ARDogScene.unity
└── DogLibrary.asset
```

---

