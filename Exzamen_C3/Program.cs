using System;
using System.Collections.Generic;
using System.IO;



while (true)
{
    Menu start = new Menu();
    start.ChoiceMenu();
}

// Уведомляем пользователя о предстоящих встречах
//meetingManager.NotifyUpcomingMeetings(TimeSpan.FromMinutes(15));


// Класс меню для пользователя
class Menu
{
    // Создаем менеджер встреч
    public MeetingManager meetingManager = new MeetingManager();

    // Создаем расписание
    public Schedule schedule = new Schedule();

    private Menu menu;
    private Meeting meeting; // Встреча
    // StartTime - начало встречи
    private string Titlemeeting; // Название встречи
    private string? textMeeting; // Тело встречи (описание)
    private int SyearMeeting;// год планируемой встречи
    private int SmonthMeeting;// месяц планируемой встречи
    private int SdateMeeting;// дата планируемой встречи
    private int ShourMeeting;// час планируемой встречи
    private int SminuteMeeting;// минута планируемой встречи

    // EndTime - Конец встречи
    private int EyearMeeting;// год планируемой встречи
    private int EmonthMeeting;// месяц планируемой встречи
    private int EdateMeeting;// дата планируемой встречи
    private int EhourMeeting;// час планируемой встречи
    private int EminuteMeeting;// минута планируемой встречи

    private int choiceMenu;
    public void ChoiceMenu()
    {
        
        Console.WriteLine("\t\tВыбирите действие с планировщиком:");
        Console.WriteLine("1 - Создать встречу");
        Console.WriteLine("2 - Обновить встречу");
        Console.WriteLine("3 - Удалить встречу");
        Console.WriteLine("4 - Выгрузить встречу");
        choiceMenu = Convert.ToInt32(Console.ReadLine());
        if(choiceMenu == 1)
        {
            // начало встречи
            Console.WriteLine("Введите название встречи:");
            Titlemeeting = Console.ReadLine();
            Console.WriteLine("Описание встречи:");
            textMeeting = Console.ReadLine();
            Console.WriteLine("Введите год начала встречи:");
            SyearMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц начала встречи:");
            SmonthMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число начала встречи:");
            SdateMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите час начала встречи:");
            ShourMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуту начала встречи:");
            SminuteMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Конец встречи
            Console.WriteLine("Введите год конца встречи:");
            EyearMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц конца встречи:");
            EmonthMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число конца встречи:");
            EdateMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите час конца встречи:");
            EhourMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуту конца встречи:");
            EminuteMeeting = Convert.ToInt32(Console.ReadLine());

            meeting = new Meeting { Title = Titlemeeting, BodyMeeting = textMeeting, StartTime = new DateTime(SyearMeeting, SmonthMeeting, SdateMeeting, ShourMeeting, SminuteMeeting, 0), EndTime = new DateTime(EyearMeeting, EmonthMeeting, EdateMeeting, EhourMeeting, EminuteMeeting, 0), ReminderTime = TimeSpan.FromMinutes(30) };
            meetingManager.AddMeeting(meeting);
        }
        else if(choiceMenu == 2)
        {
            // начало встречи
            Console.WriteLine("Введите название встречи:");
            Titlemeeting = Console.ReadLine();
            Console.WriteLine("Описание встречи:");
            textMeeting = Console.ReadLine();
            Console.WriteLine("Введите год начала встречи:");
            SyearMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц начала встречи:");
            SmonthMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число начала встречи:");
            SdateMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите час начала встречи:");
            ShourMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуту начала встречи:");
            SminuteMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Конец встречи
            Console.WriteLine("Введите год конца встречи:");
            EyearMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц конца встречи:");
            EmonthMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число конца встречи:");
            EdateMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите час конца встречи:");
            EhourMeeting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуту конца встречи:");
            EminuteMeeting = Convert.ToInt32(Console.ReadLine());

            Meeting newMeeting = new Meeting { Title = Titlemeeting, BodyMeeting = textMeeting, StartTime = new DateTime(SyearMeeting, SmonthMeeting, SdateMeeting, ShourMeeting, SminuteMeeting, 0), EndTime = new DateTime(EyearMeeting, EmonthMeeting, EdateMeeting, EhourMeeting, EminuteMeeting, 0), ReminderTime = TimeSpan.FromMinutes(30) };
            meetingManager.UpdateMeeting(meeting, newMeeting);
        }
        else if (choiceMenu == 3)
        {
            //menu.DeleteMeeting();
        }
        else if (choiceMenu == 4)
        {
            schedule.ExportSchedule(DateTime.Now, "C:\\Users\\Admin\\source\\repos\\Exzamen_C3\\Exzamen_C3\\schedule.txt");
        }
        else
        {
            Console.WriteLine("Ну тогда ладно");
        }
    }

    public void DeleteMeeting(Meeting meeting1)
    {
        meetingManager.DeleteMeeting(meeting1);
    }




}

// Класс для хранения информации о встрече
class Meeting
{
    public string Title { get; set; } // Название встречи
    public string BodyMeeting { get; set; } // тело встречи
    public DateTime StartTime { get; set; } // Время начала встречи
    public DateTime EndTime { get; set; } // Время окончания встречи
    public TimeSpan ReminderTime { get; set; } // Время напоминания о встрече
}

// Класс для управления встречами
class MeetingManager
{
    List<Meeting> meetings = new List<Meeting>();
    // Метод для добавления встречи
    public void AddMeeting(Meeting meeting)
    {
        // Проверяем, не пересекается ли новая встреча с уже существующими встречами
        if (IsMeetingOverlap(meeting))
        {
            throw new Exception("Meeting overlaps with existing meetings.");
        }

        // Добавляем встречу в список
        meetings.Add(meeting);
    }

    // Метод для обновления встречи
    public void UpdateMeeting(Meeting oldMeeting, Meeting newMeeting)
    {
        // Проверяем, не пересекается ли новая встреча с уже существующими встречами
        if (IsMeetingOverlap(newMeeting))
        {
            throw new Exception("Meeting overlaps with existing meetings.");
        }

        // Находим индекс старой встречи в списке и заменяем ее на новую встречу
        int index = meetings.IndexOf(oldMeeting);
        meetings[index] = newMeeting;
    }

    // Метод для удаления встречи
    public void DeleteMeeting(Meeting meeting)
    {
        // Удаляем встречу из списка
        meetings.Remove(meeting);
    }

    // Метод для получения списка встреч на определенный день
    public List<Meeting> GetMeetings(DateTime date)
    {
        List<Meeting> result = new List<Meeting>();

        // Проходим по всем встречам в списке и добавляем те, которые проходят в указанный день, в новый список
        foreach (Meeting meeting in meetings)
        {
            if (meeting.StartTime.Date == date.Date)
            {
                result.Add(meeting);
            }
        }

        return result;
    }

    // Метод для уведомления пользователя о предстоящих встречах
    public void NotifyUpcomingMeetings(TimeSpan timeSpan)
    {
        // Проходим по всем встречам в списке и проверяем, не наступило ли время напоминания о встрече
        foreach (Meeting meeting in meetings)
        {
            if (meeting.StartTime - DateTime.Now <= timeSpan)
            {
                // Если наступило, выводим сообщение о предстоящей встрече
                Console.WriteLine("Upcoming meeting: {0} at {1}", meeting.Title, meeting.StartTime);
            }
        }
    }

    // Метод для проверки пересечения встреч
    private bool IsMeetingOverlap(Meeting meeting)
    {
        // Проходим по всем встречам в списке и проверяем, не пересекается ли новая встреча с уже существующими встречами
        foreach (Meeting m in meetings)
        {
            if (meeting.StartTime >= m.StartTime && meeting.StartTime < m.EndTime)
            {
                return true;
            }

            if (meeting.EndTime > m.StartTime && meeting.EndTime <= m.EndTime)
            {
                return true;
            }
        }

        return false;
    }
}

// Класс для отображения расписания встреч
class Schedule
{
    private MeetingManager meetingManager = new MeetingManager(); // Менеджер встреч

    // Метод для добавления встречи
    public void AddMeeting(Meeting meeting)
    {
        meetingManager.AddMeeting(meeting);
    }

    // Метод для обновления встречи
    public void UpdateMeeting(Meeting oldMeeting, Meeting newMeeting)
    {
        meetingManager.UpdateMeeting(oldMeeting, newMeeting);
    }

    // Метод для удаления встречи
    public void DeleteMeeting(Meeting meeting)
    {
        meetingManager.DeleteMeeting(meeting);
    }

    // Метод для экспорта расписания встреч в текстовый файл
    public void ExportSchedule(DateTime date, string fileName)
    {
        // Получаем список встреч на указанный день
        List<Meeting> meetings = meetingManager.GetMeetings(date);

        // Создаем файл и записываем в него расписание встреч
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Schedule for {0}", date.ToShortDateString());
            writer.WriteLine();

            foreach (Meeting meeting in meetings)
            {
                writer.WriteLine("{0} - {1}: {2}", meeting.StartTime.ToShortTimeString(), meeting.EndTime.ToShortTimeString(), meeting.Title);
            }
        }
    }
}