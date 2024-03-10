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
                "Baldur�s Gate III",
                "Baldur�s Gate 3 ����� ������������ ����� Baldur�s Gate, " +
                "���������� �� ���������� ������� ���� Dungeons & Dragons;" +
                " � �������� ���������� � ��� �� ����������� ��������� " +
                "Forgotten Realms.",
                new DateTime(2020, 10, 6),
                "RPG",
                null));
            _unitOfWork.Games.Add(new Game(
                "Doom (1993)",
                "Doom - ������������ ���� � ����� ������ �� ������� ����, ������������� � ���������� ��������� " +
                "id Software � 1993 ����. Doom �������� ����� �� ����� ������������ � ����������� " +
                "������������ ��� � ������� ���������; � ���������, � ������������ �� " +
                "������ ���������� ���������� �������� � ��������������� ����� ������� �� ������� ����",
                new DateTime(1993, 12, 10),
                "FPS",
                null));
            _unitOfWork.Games.Add(new Game(
                "Undertale",
                "Undertale � ������������ ������� ����, ������������� ������������ " +
                "������������� � ������������ ���� ������. ����� ��������� �������," +
                " ������� �������� ���� � �������� � ����� � ���������� � ������� " +
                "������������� �� ����� ���. � �������� ��������� ����� ����� ���������" +
                " ��������� ��������� �������, ��������� �� ������� ��������� � ���� " +
                "���������. �� ����� ����� ����� ��������� ��������� �������, ������� " +
                "������������� ���� �����; ������� ���� ���������� � ����� �Bullet Hell�," +
                " ����� ����� ����� ����������� ��� ��������, ��� ������������ �����" +
                " ������ �� ��������. ����� �� �������� ������ ��������������" +
                " � ����� ����������� ��� ��������",
                new DateTime(2015, 9, 15),
                "RPG",
                null));
            _unitOfWork.SaveChanges();
        }

        public override void Validate() { }
    }
}
