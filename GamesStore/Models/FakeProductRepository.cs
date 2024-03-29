using System.Linq;
using System.Collections.Generic;
namespace GamesStore.Models;

public class FakeProductRepository : IProductRepository
{
      public IQueryable<Product> Products => new List<Product>
      {
            new Product{Name = "Dishonored", Price = 300M, Description = "Dishonored — это насыщенный экшен от первого лица, в котором вам предстоит вжиться в роль убийцы, чьими поступками движет жажда мести. Гибкая система боя в Dishonored позволит вам комбинировать ваши сверхъестественные способности, оружие и необычные устройства так, как того захотите вы, чтобы устранить ваши цели."},
            new Product{Name = "Dishonored 2", Price = 500M, Description = "Сюжет Действие игры Dishonored 2 разворачивается спустя пятнадцать лет после победы над лордом-регентом и избавления от ужасной крысиной чумы. Необычный враг отнял трон у императрицы Эмили Колдуин, и мрачная тень злого рока нависла над Островами."},
            new Product{Name = "Factorio", Price = 500M, Description = "Factorio - это игра о создании автоматизированных фабрик по производству вещей все более возрастающей сложности, в пределах бесконечного 2D мира - Используйте свое воображение для проектирования фабрик, комбинируйте простые элементы в комплексные структуры и, наконец, защищайтесь от враждебных существ."},
            new Product{Name = "Supreme Commander: Forged Alliance", Price = 100M, Description = "Близятся последние дни человечества. Прошло два года после завершения Бесконечной войны. Силы некогда великих наций истощены дотла, и надежда людей на светлое будущее — лишь горькие воспоминания. Новый, кажется, непобедимый враг при поддержке фанатиков Ордена стремится уничтожить человечество в лице ОЗФ, сторонников Аэона и Кибран. Прижатые к стене и глядящие в бездну, разгромленные остатки сил людей должны забыть о старых распрях и объединиться, готовясь к последнему отчаянному сопротивлению. Последнему, единственному шансу. Новый альянс — сплав крови, стали и надежды встает на пути тьмы."},
            new Product{Name = "Supreme Commander 2", Price = 100M, Description = "В Supreme Commander 2, игроки смогут участвовать в полномасштабных жестоких битвах! Игроки будут вести войну, создавая огромные настраиваемые армии и экспериментальные военные машины, которые могут изменить соотношение сил в любой момент."}          
      }.AsQueryable<Product>();
}