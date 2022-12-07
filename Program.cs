using ConsoleApp1;

Game chifoumi;

chifoumi = new Game(new Joueur("benji"), new Computer(),1);

Console.WriteLine("*** Chifoumi ***");
chifoumi.jouer();
