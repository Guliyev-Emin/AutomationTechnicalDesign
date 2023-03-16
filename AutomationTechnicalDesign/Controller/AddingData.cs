using System.Collections.Generic;
using AutomationTechnicalDesign.Models;

namespace AutomationTechnicalDesign.Controller;

public abstract class AddingData
{
    /// <summary>
    ///     Метод по инициализации группы операций
    /// </summary>
    /// <returns>Лист опреаций</returns>
    public static List<Operation> GetOperations()
    {
        return new List<Operation>
        {
            new()
            {
                Id = 1,
                Name = "Автоматно-линейная"
            },
            new()
            {
                Id = 2,
                Name = "Агрегатная"
            },
            new()
            {
                Id = 3,
                Name = "Долбежная"
            },
            new()
            {
                Id = 4,
                Name = "Зубообрабатывающая"
            },
            new()
            {
                Id = 5,
                Name = "Комбинированная"
            },
            new()
            {
                Id = 6,
                Name = "Отделочная"
            },
            new()
            {
                Id = 7,
                Name = "Отрезная"
            },
            new()
            {
                Id = 8,
                Name = "Программная"
            },
            new()
            {
                Id = 9,
                Name = "Протяжная"
            },
            new()
            {
                Id = 10,
                Name = "Расточная"
            },
            new()
            {
                Id = 11,
                Name = "Резьбонарезная"
            },
            new()
            {
                Id = 12,
                Name = "Сверлильная"
            },
            new()
            {
                Id = 13,
                Name = "Строгальная"
            },
            new()
            {
                Id = 14,
                Name = "Токарная"
            },
            new()
            {
                Id = 15,
                Name = "Фрезерная"
            },
            new()
            {
                Id = 16,
                Name = "Шлифовальная"
            }
        };
    }

    /// <summary>
    ///     Метод по инициализации действий
    /// </summary>
    /// <returns>Лист действий</returns>
    public static List<Action> GetActions()
    {
        return new List<Action>
        {
            new()
            {
                Id = 1,
                Name = "Вальцевать",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 2,
                Name = "Врезаться",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 3,
                Name = "Гальтовать",
                OperationsId = new List<int> { 6 }
            },
            new()
            {
                Id = 4,
                Name = "Гравировать",
                OperationsId = new List<int> { 15 }
            },
            new()
            {
                Id = 5,
                Name = "Довести",
                OperationsId = new List<int> { 6 }
            },
            new()
            {
                Id = 6,
                Name = "Долбить",
                OperationsId = new List<int> { 3, 4 }
            },
            new()
            {
                Id = 7,
                Name = "Закруглить",
                OperationsId = new List<int> { 1, 2, 4 }
            },
            new()
            {
                Id = 8,
                Name = "Заточить",
                OperationsId = new List<int> { 16 }
            },
            new()
            {
                Id = 9,
                Name = "Затыловать",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 10,
                Name = "Зенковать",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 11,
                Name = "Навить",
                OperationsId = new List<int> { 1, 2, 14 }
            },
            new()
            {
                Id = 12,
                Name = "Накатать",
                OperationsId = new List<int> { 1, 2, 4, 11 }
            },
            new()
            {
                Id = 13,
                Name = "Нарезать",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 11, 12, 14 }
            },
            new()
            {
                Id = 14,
                Name = "Обкатать",
                OperationsId = new List<int> { 4 }
            },
            new()
            {
                Id = 15,
                Name = "Опилить",
                OperationsId = new List<int> { 6 }
            },
            new()
            {
                Id = 16,
                Name = "Отрезать",
                OperationsId = new List<int> { 1, 2, 5, 7, 8, 10, 14, 15 }
            },
            new()
            {
                Id = 17,
                Name = "Подрезать",
                OperationsId = new List<int> { 1, 2, 5, 10, 14 }
            },
            new()
            {
                Id = 18,
                Name = "Полировать",
                OperationsId = new List<int> { 1, 2, 5, 6, 12, 14 }
            },
            new()
            {
                Id = 19,
                Name = "Притирать",
                OperationsId = new List<int> { 6 }
            },
            new()
            {
                Id = 20,
                Name = "Приработать",
                OperationsId = new List<int> { 4 }
            },
            new()
            {
                Id = 21,
                Name = "Протянуть",
                OperationsId = new List<int> { 4, 9 }
            },
            new()
            {
                Id = 22,
                Name = "Развернуть",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 23,
                Name = "Развальцевать",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 24,
                Name = "Раскатать",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 25,
                Name = "Рассверлить",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 26,
                Name = "Расточить",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 27,
                Name = "Сверлить",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 28,
                Name = "Строгать",
                OperationsId = new List<int> { 13 }
            },
            new()
            {
                Id = 29,
                Name = "Суперфинишировать",
                OperationsId = new List<int> { 6 }
            },
            new()
            {
                Id = 30,
                Name = "Точить",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 14 }
            },
            new()
            {
                Id = 31,
                Name = "Хонинговать",
                OperationsId = new List<int> { 1, 2, 6 }
            },
            new()
            {
                Id = 32,
                Name = "Шевинговать",
                OperationsId = new List<int> { 1, 2, 4 }
            },
            new()
            {
                Id = 33,
                Name = "Шлифовать",
                OperationsId = new List<int> { 1, 2, 4, 16 }
            },
            new()
            {
                Id = 34,
                Name = "Цековать",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14 }
            },
            new()
            {
                Id = 35,
                Name = "Центровать",
                OperationsId = new List<int> { 1, 2, 5, 8, 10, 12, 14, 15 }
            },
            new()
            {
                Id = 36,
                Name = "Фрезеровать",
                OperationsId = new List<int> { 1, 2, 4, 5, 8, 11, 15 }
            }
        };
    }

    /// <summary>
    ///     Метод по инициализации объектов операции
    /// </summary>
    /// <returns>Лист операций</returns>
    public static List<Objects> GetObjects()
    {
        return new List<Objects>
        {
            new()
            {
                Id = 1,
                Name = "Буртик",
                ConditionalId = new List<int> { 1, 5, 14, 15, 17, 18, 19, 20, 21, 23, 24, 30, 33, 36 }
            },
            new()
            {
                Id = 2,
                Name = "Буртики",
                ConditionalId = new List<int> { 1, 5, 14, 15, 17, 18, 19, 20, 21, 23, 24, 30, 33, 36 }
            },
            new()
            {
                Id = 3,
                Name = "Выточка",
                ConditionalId = new List<int> { 30 }
            },
            new()
            {
                Id = 4,
                Name = "Выточки",
                ConditionalId = new List<int> { 30 }
            },
            new()
            {
                Id = 5,
                Name = "Галтель",
                ConditionalId = new List<int> { 5, 7, 15, 18, 19, 20, 26, 30, 33 }
            },
            new()
            {
                Id = 6,
                Name = "Галтели",
                ConditionalId = new List<int> { 5, 7, 15, 18, 19, 20, 26, 30, 33 }
            },
            new()
            {
                Id = 7,
                Name = "Деталь",
                ConditionalId = new List<int>
                {
                    1, 3, 4, 5, 6, 7, 8, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36
                }
            },
            new()
            {
                Id = 8,
                Name = "Детали",
                ConditionalId = new List<int>
                {
                    1, 3, 4, 5, 6, 7, 8, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36
                }
            },
            new()
            {
                Id = 9,
                Name = "Заготовка",
                ConditionalId = new List<int> { 2, 15, 16, 17, 28, 30, 36 }
            },
            new()
            {
                Id = 10,
                Name = "Зуб",
                ConditionalId = new List<int> { 6, 7, 9, 13, 14, 15, 18, 19, 20, 21, 28, 32, 33, 36 }
            },
            new()
            {
                Id = 11,
                Name = "Зубья",
                ConditionalId = new List<int> { 6, 7, 9, 13, 14, 15, 18, 19, 20, 21, 28, 32, 33, 36 }
            },
            new()
            {
                Id = 12,
                Name = "Канавка",
                ConditionalId = new List<int> { 6, 15, 18, 19, 20, 21, 28, 30, 31, 33, 36 }
            },
            new()
            {
                Id = 13,
                Name = "Канавки",
                ConditionalId = new List<int> { 6, 15, 18, 19, 20, 21, 28, 30, 31, 33, 36 }
            },
            new()
            {
                Id = 14,
                Name = "Контур",
                ConditionalId = new List<int> { 4, 5, 6, 15, 18, 19, 20, 21, 28, 33, 36 }
            },
            new()
            {
                Id = 15,
                Name = "Конус",
                ConditionalId = new List<int> { 4, 5, 10, 14, 15, 16, 18, 19, 20, 22, 24, 26, 30, 33 }
            },
            new()
            {
                Id = 16,
                Name = "Лыска",
                ConditionalId = new List<int> { 5, 15, 18, 21, 28, 33, 36 }
            },
            new()
            {
                Id = 17,
                Name = "Лыски",
                ConditionalId = new List<int> { 5, 15, 18, 21, 28, 33, 36 }
            },
            new()
            {
                Id = 18,
                Name = "Отверстие",
                ConditionalId = new List<int>
                    { 5, 6, 10, 18, 19, 20, 21, 22, 24, 25, 26, 27, 29, 30, 31, 33, 34, 35, 36 }
            },
            new()
            {
                Id = 19,
                Name = "Отверстия",
                ConditionalId = new List<int>
                    { 5, 6, 10, 18, 19, 20, 21, 22, 24, 25, 26, 27, 29, 30, 31, 33, 34, 35, 36 }
            },
            new()
            {
                Id = 20,
                Name = "Паз",
                ConditionalId = new List<int> { 5, 6, 15, 18, 19, 20, 21, 28, 33, 36 }
            },
            new()
            {
                Id = 21,
                Name = "Пазы",
                ConditionalId = new List<int> { 5, 6, 15, 18, 19, 20, 21, 28, 33, 36 }
            },
            new()
            {
                Id = 22,
                Name = "Поверхность",
                ConditionalId = new List<int>
                {
                    1, 2, 4, 5, 6, 7, 8, 9, 10, 14, 15, 18, 19, 20, 21, 22, 23, 24, 25, 26, 28, 30, 31, 32, 33, 34,
                    35, 36
                }
            },
            new()
            {
                Id = 23,
                Name = "Поверхности",
                ConditionalId = new List<int>
                {
                    1, 2, 4, 5, 6, 7, 8, 9, 10, 14, 15, 18, 19, 20, 21, 22, 23, 24, 25, 26, 28, 30, 31, 32, 33, 34,
                    35, 36
                }
            },
            new()
            {
                Id = 24,
                Name = "Пружина",
                ConditionalId = new List<int> { 11 }
            },
            new()
            {
                Id = 25,
                Name = "Пружины",
                ConditionalId = new List<int> { 11 }
            },
            new()
            {
                Id = 26,
                Name = "Резьба",
                ConditionalId = new List<int> { 12, 13, 18, 30, 33, 36 }
            },
            new()
            {
                Id = 27,
                Name = "Рифление",
                ConditionalId = new List<int> { 12, 13, 30, 33, 36 }
            },
            new()
            {
                Id = 28,
                Name = "Ступень",
                ConditionalId = new List<int> { 15, 18, 19, 20, 30, 33, 36 }
            },
            new()
            {
                Id = 29,
                Name = "Сфера",
                ConditionalId = new List<int> { 5, 14, 15, 18, 19, 20, 30, 33 }
            },
            new()
            {
                Id = 30,
                Name = "Торец",
                ConditionalId = new List<int> { 4, 5, 17, 18, 19, 33, 36 }
            },
            new()
            {
                Id = 31,
                Name = "Торцы",
                ConditionalId = new List<int> { 4, 5, 17, 18, 19, 33, 36 }
            },
            new()
            {
                Id = 32,
                Name = "Фаска",
                ConditionalId = new List<int> { 5, 15, 18, 19, 26, 28, 30, 33, 36 }
            },
            new()
            {
                Id = 33,
                Name = "Фаски",
                ConditionalId = new List<int> { 5, 15, 18, 19, 26, 28, 30, 33, 36 }
            },
            new()
            {
                Id = 34,
                Name = "Червяк",
                ConditionalId = new List<int> { 13, 33 }
            },
            new()
            {
                Id = 35,
                Name = "Цилиндр",
                ConditionalId = new List<int> { 5, 18, 19, 20, 21, 29, 30, 31, 33 }
            }
        };
    }

    /// <summary>
    ///     Метод по инициализации инструментов
    /// </summary>
    /// <returns>Лист инструментов</returns>
    public static List<Tool> GetTools()
    {
        return new List<Tool>
        {
            new()
            {
                Id = 1,
                Name = "Резцы",
                OperationsId = new List<int> { 3, 13, 14 }
            },
            new()
            {
                Id = 2,
                Name = "Сверла",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 3,
                Name = "Зенкеры",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 4,
                Name = "Развертки",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 5,
                Name = "Метчики",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 6,
                Name = "Плашки",
                OperationsId = new List<int> { 14 }
            },
            new()
            {
                Id = 7,
                Name = "Долбяк",
                OperationsId = new List<int> { 3 }
            },
            new()
            {
                Id = 8,
                Name = "Резец проходной",
                OperationsId = new List<int> { 1 }
            },
            new()
            {
                Id = 9,
                Name = "Резец подрезной отогнутый",
                OperationsId = new List<int> { 1 }
            },
            new()
            {
                Id = 10,
                Name = "Резец резьбовой",
                OperationsId = new List<int> { 1 }
            },
            new()
            {
                Id = 11,
                Name = "Фреза",
                OperationsId = new List<int> {10}
            },
            new()
            {
                Id = 12,
                Name = "Протяжная",
                OperationsId = new List<int> {9}
            },
            new()
            {
                Id = 13,
                Name = "Шлифовальный круг",
                OperationsId = new List<int> {16}
            }
        };
    }

    public static List<Controls> GetControls()
    {
        return new List<Controls>
        {
            new()
            {
                Id = 1,
                Name = "Штангенциркуль",
                ToolsId = new List<int> { 1, 2, 11, 8, 2 },
                OperationsId = new List<int> { 14, 10 }
            },
            new()
            {
                Id = 2,
                Name = "Шаблон для контроля канавки",
                ToolsId = new List<int> {1},
                OperationsId = new List<int> {10}
            },
            new()
            {
                Id = 3,
                Name = "Нутромер",
                ToolsId = new List<int> {2, 12},
                OperationsId = new List<int> {9, 10}
            },
            new()
            {
                Id = 4,
                Name = "Микрометр",
                ToolsId = new List<int> {1, 13},
                OperationsId = new List<int> {14, 16}
            },
            new()
            {
                Id = 5,
                Name = "Калибр-пробка",
                ToolsId = new List<int> {2, 11},
                OperationsId = new List<int> {10}
            },
            new()
            {
                Id = 6,
                Name = "Штангенрейсмосс",
                ToolsId = new List<int> {2, 11},
                OperationsId = new List<int> {10}
            },
            new()
            {
                Id = 7,
                Name = "Нутромер НН",
                ToolsId = new List<int> {10},
                OperationsId = new List<int> {2, 11}
            },
            new()
            {
                Id = 8,
                Name = "Индикатор",
                ToolsId = new List<int> {2, 1, 16},
                OperationsId = new List<int> {14, 16}
            }
        };
    }

    public static List<Tooling> GetToolings()
    {
        return new List<Tooling>
        {
            new()
            {
                Id = 1,
                Name = "Поводковое станочное приспособление",
                OperationsId = new List<int> {10, 14},
                ToolsId = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            }
        };
    } 
}