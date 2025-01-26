namespace s_marcinkowski_135898_cw4;

public class Adapter : ITarget
{
    private Square _square;

    public Adapter(Square square)
    {
        _square = square;
    }

    public double GetWidth()
        => _square.Width * _square.Width;
}
