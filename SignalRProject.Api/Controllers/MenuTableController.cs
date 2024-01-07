using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.Businnes.Abstrack;
using SignalRProject.Dto.MenuTableDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTableController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }
        [HttpGet("MenuTableCount")]
        public ActionResult MenuTableCount()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }
        [HttpGet]
        public IActionResult MenuTableList()
        {
            return Ok(_menuTableService.TGetListAll());
        }
        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            MenuTable menuTable = new MenuTable()
            {
                Name = createMenuTableDto.Name,
                Status = false,
            };
            _menuTableService.TAdd(menuTable);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var values = _menuTableService.TGetById(id);
            _menuTableService.TDelete(values);
            return Ok("Masa silindi.");
        }
        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTable)
        {
            MenuTable menuTable = new MenuTable()
            {
                MenuTableId = updateMenuTable.MenuTableId,
                Name = updateMenuTable.Name,
                Status = true,
            };
            _menuTableService.TUpdate(menuTable);
            return Ok("Masa Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetMenuTable(int id)
        {
            var values = _menuTableService.TGetById(id);
            return Ok(values);
        }
    }
}
