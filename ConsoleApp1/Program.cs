﻿using ConsoleApp1.Services;

var menu = new Menu();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

while(true)
{
    Console.Clear();
    menu.StartMenu();
}