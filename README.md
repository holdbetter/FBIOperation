# FBIOperation <img src="https://img.shields.io/badge/version-0.0.1-blue" alt="project-version">
###### Мобильное приложение, отображающее результаты спортивных событий. [Designed in Figma](https://www.figma.com/file/mkRCHwBrIxMNhtyK5li7Qe/FBI-Operation?node-id=322%3A414)

### Особенности текущей версии
* В рабочей версии:
  * Использование **ContentView** (C#) для гибкой работы с элементами
  * Использование **Binding**:
    * RelativeBinging
    * MultiBinding
    * ValueConverter
    * MultiValueConverter
  * Данные статичны, расположены в **MatchOverviewPage**
  * Описана модель данных в [Models](https://github.com/holdbetter/FBIOperation/tree/master/FBIOperation/FBIOperation/Models)
  * Примитивная работа с локальными изображениями
  * Примитивная работа со шрифтами
  * Часть страниц написана в XML, часть в C# - подробнее ниже
  
* В остальной части проекта текущей версии:
  * Помойка из старых версии страниц и частей других проектов
  
#### To-do list
 - [ ] Style and Resources implementing
 - [ ] SQLite database connect
 - [ ] MySQL or any NoSQL database migration
 - [ ] Android status bar color adjusting
 - [ ] Design with platform features
 - [ ] Caching strategy
 - [ ] Firebase with push implementation

#### Целевая платформа текущей версии
Проект был сверстан и разработан исключительно под Android. iOS - wasn't testing. UWP - wasn't debugging. 

#### Дополнительное описание проекта
Приложение содержит 3 карточки с результатами спортивных событий. Результаты - статичные данные, динамические не обновляются и с реальной жизнью не связаны. 
Каждый результат в карточке кликабелен и открывает подробную статистику события с соответствующей спорту цветовой палитрой.
При использовании приложения данные изменить нельзя.

###### :robot: FBIOperation - FootballBasketballIceOperation
