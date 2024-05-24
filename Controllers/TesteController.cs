using Microsoft.AspNetCore.Mvc;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public TesteController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            var items = await _itemRepository.GetAll();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _itemRepository.GetById(id);
            return Ok(item);
        }
    }
}
