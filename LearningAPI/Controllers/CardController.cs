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
		public async Task<ActionResult> GetAll()
		{
			var json = await _service.GetAll();
			return Ok(json);
		}
		[HttpGet("get/{id}")]
		public async Task<ActionResult> GetById(Guid id)
		{
			var json = await _service.GetById(id);
			return Ok(json);
		}
		[HttpPost("add")]
		public async Task<ActionResult> Add(Card card)
		{
			var json = await _service.Add(card);
			return Ok(json);
		}
		[HttpPut("update")]
		public async Task<ActionResult> Update(Card card)
		{
			var json = await _service.Update(card);
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
