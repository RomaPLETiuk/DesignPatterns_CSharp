

using Strategy;
using Strategy.Strategies;

Soldier soldier = new Soldier("Ivan");

soldier.Attack();

soldier.SetPistol(new TT());
soldier.Attack();

soldier.SetPistol(new PM());
soldier.Attack();
Console.ReadLine();