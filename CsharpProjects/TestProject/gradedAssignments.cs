﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

decimal gradedAssignments1 = ((decimal) (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments );
decimal gradedAssignments2 = ((decimal) (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments );
decimal gradedAssignments3 = ((decimal) (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments );
decimal gradedAssignments4 = ((decimal) (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments );

Console.WriteLine(@"Student     Grade ");
Console.WriteLine(@"Sophia      " +   gradedAssignments1+" A");
Console.WriteLine(@"Nicolas     "+   gradedAssignments2+" B");
Console.WriteLine(@"Zahirah     "+   gradedAssignments3+" B");
Console.WriteLine(@"Jeong       "+     gradedAssignments4+" A");
