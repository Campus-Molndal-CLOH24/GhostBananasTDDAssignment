using System.Collections.Generic;
using GhostBananasTDDAssignment.Data;

namespace GhostBananasTDDAssignment.Logic
{
    public class GameState
    {
        // Här lagrar du alla rum under en strängnyckel (ex. "PolarkylansSkog")
        public Dictionary<string, Room> Rooms { get; set; } = new Dictionary<string, Room>();

        // Det aktuella rum där spelaren befinner sig
        public Room CurrentRoom { get; set; }

        // Spelarens inventory (föremål som plockats upp)
        public List<string> Inventory { get; set; } = new List<string>();

        public GameState()
        {
            // Du kan antingen anropa InitializeRooms() här i konstruktorn
            InitializeRooms();
        }

        public void InitializeRooms()
        {
            // Skapa instanser av de fem rums-klasser du redan har definierat
            var polarkylansSkog = new PolarkylansSkog();
            var isgrottansHjärta = new IsgrottansHjärta();
            var rudolfsHed = new RudolfsHed();
            var pepparkaksbyn = new Pepparkaksbyn();
            var tomteland = new Tomteland();

            // Länka rummens utgångar, t.ex. "norr", "söder", "öst", "väst"
            polarkylansSkog.Exits["syd"] = rudolfsHed;
            rudolfsHed.Exits["norr"] = polarkylansSkog;

            rudolfsHed.Exits["öst"] = pepparkaksbyn;
            pepparkaksbyn.Exits["väst"] = rudolfsHed;

            pepparkaksbyn.Exits["syd"] = isgrottansHjärta;
            isgrottansHjärta.Exits["norr"] = pepparkaksbyn;

            // Exempel: koppla in "Tomteland" också
            isgrottansHjärta.Exits["öst"] = tomteland;
            tomteland.Exits["väst"] = isgrottansHjärta;

            // Lägg in rums-objekten i dictionaryn
            Rooms["PolarkylansSkog"] = polarkylansSkog;
            Rooms["IsgrottansHjärta"] = isgrottansHjärta;
            Rooms["RudolfsHed"] = rudolfsHed;
            Rooms["Pepparkaksbyn"] = pepparkaksbyn;
            Rooms["Tomteland"] = tomteland;

            // Bestäm vilket rum spelaren ska starta i
            CurrentRoom = polarkylansSkog;
        }
    }
}
