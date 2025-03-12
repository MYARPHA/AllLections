Console.WriteLine("files");
//1 вариант
//DriveInfo drive = new("X");

//2 вариант
var drives = DriveInfo.GetDrives();
foreach (var drive in drives)
{
    Console.WriteLine(drive.Name);
    Console.WriteLine(drive.VolumeLabel);
    Console.WriteLine(drive.IsReady);
    Console.WriteLine(drive.DriveFormat);
    Console.WriteLine(drive.DriveType);
    Console.WriteLine(drive.TotalSize);
    Console.WriteLine(drive.AvailableFreeSpace);
    Console.WriteLine(drive.TotalFreeSpace);
}
