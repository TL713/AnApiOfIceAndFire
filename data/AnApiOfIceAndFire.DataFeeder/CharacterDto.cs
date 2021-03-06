using AnApiOfIceAndFire.Data.Characters;

namespace AnApiOfIceAndFire.DataFeeder
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFemale { get; set; }
        public string Culture { get; set; }
        public string[] Titles { get; set; }
        public string[] Aliases { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
        public int? Father { get; set; }
        public int? Mother { get; set; }
        public int? Spouse { get; set; }
        public int[] Allegiances { get; set; }
        public int[] Books { get; set; }
        public int[] PovBooks { get; set; }
        public string[] PlayedBy { get; set; }
        public string[] TvSeries { get; set; }

        public CharacterEntity ToCharacterEntity()
        {
            return new CharacterEntity()
            {
                Id = Id,
                Name = Name,
                IsFemale = IsFemale,
                Born = Born,
                Died = Died,
                SpouseId = Spouse,
                FatherId = Father,
                MotherId = Mother,
                Culture = Culture,
                Titles = string.Join(";", Titles),
                Aliases = string.Join(";", Aliases),
                PlayedBy = string.Join(";", PlayedBy),
                TvSeries = string.Join(";", TvSeries),
                PovBookIdentifiers =  PovBooks,
                BookIdentifiers = Books,
                AllegianceIdentifiers = Allegiances
            };
        }
    }
}