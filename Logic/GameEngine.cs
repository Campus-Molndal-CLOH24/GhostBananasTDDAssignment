using System;
using System.Collections.Generic;

namespace GhostBananasTDDAssignment
{
    public class GameEngine
    {
        // Spelarens startposition
        private int _playerX = 2;  // Mitten i X-led (0..4)
        private int _playerY = 2;  // Mitten i Y-led (0..4)

        // Gränser för kartan (5x5)
        private int _maxX = 4;
        private int _maxY = 4;

        // Föremål som ligger i "rummet" när spelet startar
        private List<string> _roomItems = new List<string> { "nyckel", "svärd" };

        // Spelarens inventarie (vad spelaren bär med sig)
        private List<string> _inventory = new List<string>();

        // Metod för att flytta spelaren åt norr, söder, väster eller öster
        public bool MovePlayer(string direction)
        {
            // Sätt nya koordinater till spelarens nuvarande position
            int newX = _playerX;
            int newY = _playerY;

            // Justera koordinaterna baserat på riktningen
            switch (direction)
            {
                case "norr":
                    newY--;
                    break;
                case "söder":
                    newY++;
                    break;
                case "väster":
                    newX--;
                    break;
                case "öster":
                    newX++;
                    break;
                default:
                    // Om riktningen inte känns igen
                    return false;
            }

            // Kolla så att det inte är utanför kartans gränser
            if (newX < 0 || newX > _maxX || newY < 0 || newY > _maxY)
            {
                // Kan inte gå utanför kartan
                return false;
            }

            // Uppdatera spelarens position om det är inom giltiga gränser
            _playerX = newX;
            _playerY = newY;
            return true;
        }

        // Metod för att plocka upp ett föremål från rummet
        public bool PickupItem(string itemName)
        {
            // Om föremålet finns i rummet
            if (_roomItems.Contains(itemName))
            {
                // Ta bort föremålet från rummet
                _roomItems.Remove(itemName);
                // Lägg till föremålet i spelarens inventory
                _inventory.Add(itemName);
                return true;
            }
            // Annars gick det inte att plocka upp föremålet
            return false;
        }

        // Hämtar spelarens aktuella position (X, Y)
        public (int X, int Y) GetPlayerPosition()
        {
            return (_playerX, _playerY);
        }

        // Returnerar en kopia av spelarens inventory
        public List<string> GetInventory()
        {
            // Returnera en ny lista så vi inte avslöjar den interna listan direkt
            return new List<string>(_inventory);
        }
    }
}
