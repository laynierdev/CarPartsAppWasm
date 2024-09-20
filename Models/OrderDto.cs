namespace CarPartsAppWasm.Models;

public class OrderDto
{
    public IList<ProductDto> Products { get; set; } = new List<ProductDto>();
    public decimal Total { get; set; } = 0;
    public DateTime Date { get; set; } = DateTime.Now;
}