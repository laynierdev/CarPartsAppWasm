using CarPartsAppWasm.Models;

namespace CarPartsAppWasm.Services;

public class CartService
{
    private List<ProductDto> _items = new();
    public event Action? OnChange;


    public IEnumerable<ProductDto> GetItems() => _items;

    public void AddItem(ProductDto item)
    {
        var existingItem = _items.FirstOrDefault(i => i.Name == item.Name);
        if (existingItem != null)
        {
            existingItem.Quantity += item.Quantity;
        }
        else
        {
            _items.Add(item);
        }
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public void RemoveItem(string productName)
    {
        var item = _items.FirstOrDefault(i => i.Name == productName);
        if (item != null)
        {
            _items.Remove(item);
        }
        NotifyStateChanged();
    }

    public void ClearCart() => _items.Clear();

    public decimal GetTotal() => _items.Sum(i => i.Price * i.Quantity);
}
