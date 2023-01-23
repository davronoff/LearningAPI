using LearningAPI.Interface;
using LearningAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningAPI.Controllers
{
	[Microsoft.AspNetCore.Components.Route("api/[controller]")]
	[ApiController]
	public class CardController : ControllerBase
	{
		private readonly ICardInterface _service;

		public CardController(ICardInterface service)
		{
			_service = service;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var json = _service.GetAll();
			return Ok(json);
		}
		[HttpGet("get/{id}")]
		public IActionResult GetById(Guid id)
		{
			var json = _service.GetById(id);
			return Ok(json);
		}
		[HttpPost("add")]
		public IActionResult Add(Card card)
		{
			var json = _service.Add(card);
			return Ok(json);
		}
		[HttpPut("update")]
		public IActionResult Update(Card card)
		{
			var json = _service.Update(card);
			return Ok(json);
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(Guid id)
		{
			_service.Delete(id);
			return Ok();
		}

	}
}
