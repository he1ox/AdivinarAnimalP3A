using AdivinarAnimalP3A;

Console.WriteLine("Bienvenido al fabuloso juego de adivinar animal");

bool otroJuego = true;

AdivinaAnimal juego = new();

do
{
    juego.Jugar();
    Console.WriteLine("Jugamos otra vez?");
    otroJuego = juego.respuesta();
} while (otroJuego);