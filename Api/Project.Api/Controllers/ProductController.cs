using Microsoft.AspNetCore.Mvc;
using Project.Api.Models;

namespace Project.Api.Controllers;

/// <summary>
/// Handles product-related operations.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Gets the product by ID.
    /// </summary>
    /// <param name="id">The ID of the product.</param>
    /// <returns>The product details.</returns>
    /// <response code="200">Returns the product details.</response>
    /// <response code="404">If the product is not found.</response>
    /// <response code="500">If there is an internal server error.</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Product), 200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public IActionResult GetProductById(int id)
    {
        try
        {
            // Simulating retrieval of a product. This should be replaced with actual data retrieval logic.
            if (id <= 0)
            {
                throw new ArgumentException("Product ID must be greater than zero.", nameof(id));
            }

            var product = new Product
            {
                Id = id,
                Name = "Sample Product",
                Description = "This is a sample product.",
                Price = 19.99m
            };

            return Ok(product);
        }
        catch (ArgumentException ex)
        {
            _logger.LogError(ex, "Invalid product ID: {ProductId}", id);
            return BadRequest(new { Message = ex.Message, ProductId = id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while retrieving product with ID: {ProductId}", id);
            throw new Exception("An error occurred while processing your request.", ex);
        }
    }
}