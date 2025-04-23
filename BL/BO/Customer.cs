

namespace BO;

public class Customer
{
    public int ID { get; init; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }

    public Customer(int id, string name, string address = null, string phone = null)
    {
        this.ID = id;
        this.Name = name;
        this.Address = address;
        this.Phone = phone;
    }
    public override string ToString() => this.ToStringProperty();

   
}