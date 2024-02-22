using ContosoPizza.Models;
using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Services;

public class PizzaService
{
    private PizzaContext _context;
    public PizzaService(PizzaContext context)
    {
        _context = context;
    }

    public IEnumerable<Pizza> GetAll()
    {
        _context.Pizzas
        .AsNoTracking()
        .ToList();
    }

    public Pizza? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Pizza? Create(Pizza newPizza)
    {
        throw new NotImplementedException();
    }

    public void AddTopping(int PizzaId, int ToppingId)
    {
        throw new NotImplementedException();
    }

    public void UpdateSauce(int PizzaId, int SauceId)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}