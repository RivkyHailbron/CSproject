

namespace DO;

public record Product
    (int ID,
    string Name,
    Categories Category,
    double Price,
    int Amount)
{
    public Product() : this(0, "", Categories.sport, 100, 0)
    {

    }
}
