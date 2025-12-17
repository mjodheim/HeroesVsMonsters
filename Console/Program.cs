using Domain;
using Domain.Entities.Heroes;

// Création d'un plateau de jeu contenant notre héros aléatoire et les monstres
GameBoard gameBoard = new GameBoard(HeroType.Nain,5);

gameBoard.Run();