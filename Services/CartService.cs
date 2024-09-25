using CarPartsAppWasm.Models;

namespace CarPartsAppWasm.Services;

public class CartService
{
    private List<ProductDto> items = new List<ProductDto>();

    public IEnumerable<ProductDto> GetItems() => items;

    public void AddItem(ProductDto item)
    {
        var existingItem = items.FirstOrDefault(i => i.name == item.name);
        if (existingItem != null)
        {
            existingItem.quantity += item.quantity;
        }
        else
        {
            items.Add(item);
        }
    }

    public void RemoveItem(string productName)
    {
        var item = items.FirstOrDefault(i => i.name == productName);
        if (item != null)
        {
            items.Remove(item);
        }
    }

    public void ClearCart() => items.Clear();

    public decimal GetTotal() => items.Sum(i => i.price * i.quantity);
}
