using Microsoft.AspNetCore.Mvc;

namespace Employee.Hierarchy.Controllers.Order
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController:ControllerBase
    {
        private readonly Repository.Repository _repository;

        public OrderController(Repository.Repository repository)
        {
            _repository = repository;
        }
    }
}
