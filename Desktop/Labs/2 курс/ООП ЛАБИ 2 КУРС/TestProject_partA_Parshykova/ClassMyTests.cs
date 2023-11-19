using System.Xml.Linq;
using ProjectA;


namespace TestProject1
{
    public class Tests1
    {
        [SetUp]

        public void Setup()
        { }
        public void ClassMyTests()
        {
            [Test]
            void Player_Constructor_InitializesPropertiesCorrectly()
            {
                // Arrange
                string expectedName = "John";
                int expectedAge = 25;
                int expectedHP = 100;
                Elements expectedElement = Elements.Pyro;

                // Act
                Player player = new Player(expectedName, expectedAge, expectedHP, expectedElement);

                // Assert
                Assert.AreEqual(expectedName, player.Name);
                Assert.AreEqual(expectedAge, player.Age);
                Assert.AreEqual(expectedHP, player.HP);
                Assert.AreEqual(expectedElement, player.Element);
            }

            [Test]
            void Player_Attack_Reduces_Boss_HP()
            {
                // Arrange
                Player player = new Player("John", 25, 100, Elements.Dendro);
                Boss boss = new Boss(1/25, 1150,41);
                int initialHP = boss.HP;
                int damage = 20;

                // Act
                player.Attack(damage);

                // Assert
                Assert.AreEqual(initialHP - damage, boss.HP);
            }

            [Test]
            void Leader_Constructor_InitializesPropertiesCorrectly()
            {
                // Arrange
                string expectedName = "Alef";
                int expectedAge = 40;
                int expectedHPForLeading = 200;
                int expectedHP = 100;
                Elements expectedElement = Elements.Hydro;

                // Act
                Leader leader = new Leader(expectedName, expectedAge, expectedHPForLeading, expectedHP, expectedElement);

                // Assert
                Assert.AreEqual(expectedName, leader.Name);
                Assert.AreEqual(expectedAge, leader.Age);
                Assert.AreEqual(expectedHPForLeading, leader.HPForLeading);
                Assert.AreEqual(expectedHP, leader.HP);
                Assert.AreEqual(expectedElement, leader.Element);
            }

            [Test]
            void Leader_Attack_Reduces_Boss_HP()
            {
                // Arrange
                Leader leader = new Leader ("Alef", 40, 50,250,  Elements.Dendro);
                Boss boss = new Boss(1 / 25, 1150, 41);
                int initialHP = boss.HP;
                int damage = 20+ leader.HPForLeading;

                // Act
                leader.Attack(damage);

                // Assert
                Assert.AreEqual(initialHP - damage, boss.HP);
            }

            [Test]
            void Team_GeneralHP_CalculatesCorrectly()
            {
                // Arrange
                Leader leader = new Leader("Alef", 40, 50, 250, Elements.Cryo);
                Team team = new Team("Cryo Camera", leader);

                Player player1 = new Player("Player1", 25, 100, Elements.Geo);
                Player player2 = new Player("Player2", 28, 120, Elements.Electro);
                Player player3 = new Player("Player3", 14, 360, Elements.Hydro);
                Player player4 = new Player("Player4", 93, 401, Elements.Anemo);
                team.Players.Add(player1);
                team.Players.Add(player2);
                team.Players.Add(player3);
                team.Players.Add(player4);

                int expectedGeneralHP = leader.HPForLeading + player1.HP + player2.HP+player3.HP+player4.HP;

                // Act
                int actualGeneralHP = team.GeneralHP(team.Players);

                // Assert
                Assert.AreEqual(expectedGeneralHP, actualGeneralHP);
            }
            [Test]
            void Game_Constructor_InitializesTeamCorrectly()
            {
                // Arrange
                Leader leader = new Leader("Alef", 40, 50, 250, Elements.Cryo);
                Team team = new Team("Fire Dragons", leader);
                Boss boss = new Boss(1 / 25, 1150, 41);

                // Act
                Game game = new Game(team, 3, 750, boss);

                // Assert
                Assert.AreEqual(team, game.Team);
            }

            [Test]
            void Boss_Constructor_InitializesPropertiesCorrectly()
            {
                // Arrange
                int expectedAttackFrequency = 9;
                int expectedHP = 3700;
                int expectedAttackPower = 80;

                // Act
                Boss boss = new Boss(expectedAttackFrequency, expectedHP, expectedAttackPower);

                // Assert
                Assert.AreEqual(expectedAttackFrequency, boss.AttackFrequensy);
                Assert.AreEqual(expectedHP, boss.HP);
                Assert.AreEqual(expectedAttackPower, boss.AttackPower);
            }

            [Test]
            void Boss_AttackPlayers_CallsAttackPlayersCorrectly()
            {
                // Arrange
                int attackFrequency = 9;
                int initialHP = 3700;
                int attackPower = 80;

                Boss boss = new Boss(attackFrequency, initialHP, attackPower);
                Player player = new Player("Hanna", 34, 3000, Elements.Pyro);

                // Act
                int damage = boss.AttackPlayers();

                // Assert

                Assert.AreEqual(attackPower, damage);

                Assert.AreEqual(player.HP - damage, player.HP);
            }
        }

    }
}