using Ejercicio4;

CircularGame juego = new CircularGame();

// Insertamos 6 jugadores (J1 a J6)
juego.insertion(6);

Console.Write("Círculo inicial: ");
juego.Remain();
Console.WriteLine();

// Ejecutamos el juego eliminando cada 3 posiciones (K = 3)
juego.Start(3);