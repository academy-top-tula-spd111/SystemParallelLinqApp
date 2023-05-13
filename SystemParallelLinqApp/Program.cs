using System.Threading.Channels;

List<int> intList = new List<int>();
for(int i = 0; i < 20; i++) intList.Add(i + 1);

//var square = from item in intList.AsParallel()
//             orderby item
//             select item * item;

//(from item in intList.AsParallel()
//             orderby item
//             select item * item
//             ).ForAll(Console.WriteLine);

//intList.AsParallel().Select(i => i * i).ForAll(Console.WriteLine);
var square = intList.AsParallel().AsOrdered().Select(i => i * i);

foreach (var item in square)
    Console.WriteLine(item);