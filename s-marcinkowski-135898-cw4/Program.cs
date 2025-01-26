using s_marcinkowski_135898_cw4;

var width = 5;

Square square = new Square(width);
ITarget adapter = new Adapter(square);

var results = adapter.GetWidth();
Console.WriteLine($"Pole kwadratu o boku {width} wynosi {results}.");
