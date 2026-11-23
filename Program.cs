using System.Data;
using System.Diagnostics;

Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");



Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");



Console.WriteLine($"Логических процессов: {Environment.ProcessorCount}");



Console.WriteLine($"PID процесса: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");
Console.ReadLine();



Console.WriteLine();
Console.WriteLine("Дополнительное задание.");

Console.WriteLine("МИНИ-МОНИТОР СИСТЕМЫ\n");
Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}\n");
Process currentProcess = Process.GetCurrentProcess();

Console.WriteLine($"PID процесса: {currentProcess.Id}\n");
Console.WriteLine("Память процесса:");
for (int i = 1; i <= 3; i++) {
    currentProcess.Refresh();
    long memory1 = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i} измерение: {memory1} МБ");
    if (i < 3) {
        Console.WriteLine("Обновите окно через несколько секунд…");
        Console.ReadLine();
    }
}
Console.WriteLine("Исследование завершено.");
