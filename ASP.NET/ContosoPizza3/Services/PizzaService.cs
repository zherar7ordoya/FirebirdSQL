using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public class PizzaService(PizzaContext context)
    {
        public IList<Pizza> GetPizzas()
        {
            if(context.Pizzas != null)
            {
                return context.Pizzas.ToList();
            }
            return [];
        }

        public void AddPizza(Pizza pizza)
        {
            if (context.Pizzas != null)
            {
                context.Pizzas.Add(pizza);
                context.SaveChanges();
            }
        }

        public void DeletePizza(int id)
        {
            if (context.Pizzas != null)
            {
                var pizza = context.Pizzas.Find(id);
                if (pizza != null)
                {
                    context.Pizzas.Remove(pizza);
                    context.SaveChanges();
                }
            }            
        } 
    }
}
