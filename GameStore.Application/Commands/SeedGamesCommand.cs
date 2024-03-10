using GameStore.Application.Commands.Interface;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;


namespace GameStore.Application.Commands
{
    public class SeedGamesCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public SeedGamesCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override void Execute()
        {
            _unitOfWork.Games.Add(new Game(
                "Baldur’s Gate III",
                "Baldur’s Gate 3 стала продолжением серии Baldur’s Gate, " +
                "основанной на настольной ролевой игре Dungeons & Dragons;" +
                " её действие происходит в той же вымышленной вселенной " +
                "Forgotten Realms.",
                new DateTime(2020, 10, 6),
                "RPG",
                null));
            _unitOfWork.Games.Add(new Game(
                "Doom (1993)",
                "Doom - компьютерная игра в жанре шутера от первого лица, разработанная и выпущенная компанией " +
                "id Software в 1993 году. Doom является одной из самых значительных и влиятельных " +
                "компьютерных игр в истории индустрии; в частности, её популярность во " +
                "многом определила дальнейшее развитие и распространение жанра шутеров от первого лица",
                new DateTime(1993, 12, 10),
                "FPS",
                null));
            _unitOfWork.Games.Add(new Game(
                "Undertale",
                "Undertale — компьютерная ролевая игра, разработанная американским " +
                "программистом и композитором Тоби Фоксом. Игрок управляет ребёнком," +
                " который случайно упал в пропасть и попал в Подземелье – большой " +
                "изолированный от людей мир. В попытках вернуться домой игрок встречает" +
                " множество различных существ, некоторые из которых относятся к нему " +
                "враждебно. Во время битвы игрок управляет маленьким сердцем, которое " +
                "символизирует душу героя; избегая атак противника в стиле «Bullet Hell»," +
                " игрок может убить нападавшего или пощадить, что впоследствии будет" +
                " влиять на концовку. Также на концовку влияет взаимодействие" +
                " с иными персонажами вне сражения",
                new DateTime(2015, 9, 15),
                "RPG",
                null));
            _unitOfWork.SaveChanges();
        }

        public override void Validate() { }
    }
}
