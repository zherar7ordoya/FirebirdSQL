﻿using Superserver;

using var db = new TodoContext();
db.Database.EnsureCreated();

db.Tareas.Add(new TodoItem { Titulo = "Probar Firebird" });
db.SaveChanges();

var tareas = db.Tareas.ToList();

foreach (var t in tareas)
{
    Console.WriteLine($"[{(t.EstaHecho ? "X" : " ")}] {t.Titulo}");
}

Console.ReadKey();