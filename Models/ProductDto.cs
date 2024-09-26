﻿namespace CarPartsAppWasm.Models;

public class ProductDto
{
 public string? Name { get; set; } = string.Empty;
 public string Description { get; set; } = string.Empty;
 public decimal Price { get; set; }
 public int Quantity { get; set; }
 public string? ImageUrl { get; set; }
 }
