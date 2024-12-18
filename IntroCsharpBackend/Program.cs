
// var sale = new Sale();
// var beer = new Beer();

// Some(sale);
// Some(beer);

// void Some(ISave save)
// {
//     save.Save();
// }

// interface ISale
// {
//     decimal Total { get; set; }
// }

// interface ISave
// {
//     public void Save(); // Void implica que no retorna nada
// }

// public class Sale : ISale, ISave
// {
//     public decimal Total { get; set; }

//     public void Save()
//     {
//         Console.WriteLine("Se guardo en DB");
//     }
// }

// public class Beer : ISave
// {
//     public void Save()
//     {
//         Console.WriteLine("Se guardo en servicio");
//     }
// }

var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

Console.WriteLine(numbers.GetContent());

Console.WriteLine("------------");

names.Add("Carlos");
names.Add("Juan");
names.Add("Pedro");
names.Add("Maria");
names.Add("Isabella");
names.Add("Sofia");
names.Add("Lucas");

Console.WriteLine(names.GetContent());

Console.WriteLine("------------");
Beer beer1 = new Beer { Name = "Heineken", Price = 1.5m };

beers.Add(new Beer()
{
    Name = "Erdinger",
    Price = 5
});
beers.Add(new Beer()
{
    Name = "Corona",
    Price = 3
});
beers.Add(new Beer()
{
    Name = "Delirium",
    Price = 6
});
beers.Add(new Beer()
{
    Name = "Paulaner",
    Price = 10
});

Console.WriteLine(beers.GetContent());



public class MyList<T>
{
    private List<T> _list;
    private int _limit;
    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";

        foreach (var element in _list)
        {
            content += element + ", ";
        }

        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Beer: " + Name + "Precio: " + Price;
    }
}

