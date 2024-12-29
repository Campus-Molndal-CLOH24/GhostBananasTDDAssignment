using System;
using System.Collections.Generic;

namespace GhostBananasTDDAssignment
{
    public class GameEngine
    {
        // Spelarens startposition
        private int _playerX = 2;  // Mitten i X-led (0..4)
        private int _playerY = 2;  // Mitten i Y-led (0..4)

        // Gr�nser f�r kartan (5x5)
        private int _maxX = 4;
        private int _maxY = 4;

        // F�rem�l som ligger i "rummet" n�r spelet startar
        private List<string> _roomItems = new List<string> { "nyckel", "sv�rd" };

        // Spelarens inventarie (vad spelaren b�r med sig)
        private List<string> _inventory = new List<string>();

        // Metod f�r att flytta spelaren �t norr, s�der, v�ster eller �ster
        public bool MovePlayer(string direction)
        {
            // S�tt nya koordinater till spelarens nuvarande position
            int newX = _playerX;
            int newY = _playerY;

            // Justera koordinaterna baserat p� riktningen
            switch (direction)
            {
                case "norr":
                    newY--;
                    break;
                case "s�der":
                    newY++;
                    break;
                case "v�ster":
                    newX--;
                    break;
                case "�ster":
                    newX++;
                    break;
                default:
                    // Om riktningen inte k�nns igen
                    return false;
            }

            // Kolla s� att det inte �r utanf�r kartans gr�nser
            if (newX < 0 || newX > _maxX || newY < 0 || newY > _maxY)
            {
                // Kan inte g� utanf�r kartan
                return false;
            }

            // Uppdatera spelarens position om det �r inom giltiga gr�nser
            _playerX = newX;
            _playerY = newY;
            return true;
        }

        // Metod f�r att plocka upp ett f�rem�l fr�n rummet
        public bool PickupItem(string itemName)
        {
            // Om f�rem�let finns i rummet
            if (_roomItems.Contains(itemName))
            {
                // Ta bort f�rem�let fr�n rummet
                _roomItems.Remove(itemName);
                // L�gg till f�rem�let i spelarens inventory
                _inventory.Add(itemName);
                return true;
            }
            // Annars gick det inte att plocka upp f�rem�let
            return false;
        }

        // H�mtar spelarens aktuella position (X, Y)
        public (int X, int Y) GetPlayerPosition()
        {
            return (_playerX, _playerY);
        }

        // Returnerar en kopia av spelarens inventory
        public List<string> GetInventory()
        {
            // Returnera en ny lista s� vi inte avsl�jar den interna listan direkt
            return new List<string>(_inventory);
        }
    }
}
