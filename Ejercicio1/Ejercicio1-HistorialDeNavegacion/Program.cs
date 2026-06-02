using Ejercicio1_HistorialDeNavegacion;

BrowserHistory history = new BrowserHistory();

// Visitar tres paginas en secuencia
history.VisitPage("google.com");
history.VisitPage("github.com");
history.VisitPage("docs.microsoft.com");
history.PrintHistory();

Console.WriteLine(history.GoBack()); // Deberia mostrar "github.com"
Console.WriteLine(history.GoBack()); // Deberia mostrar "google.com"
history.PrintHistory();

Console.WriteLine(history.GoBack());
Console.WriteLine(history.GoForward()); // Deberia mostrar "github.com"
history.PrintHistory();

Console.WriteLine(history.GoBack());
history.ClearForward();
history.VisitPage("hackerrank.com");
history.PrintHistory();


Console.ReadKey();
