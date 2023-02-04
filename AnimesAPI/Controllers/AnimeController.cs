using AnimesAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using AnimesAPI.Manager.Interfaces;
using AutoMapper;

namespace AnimesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimeController : ControllerBase
    {

        private readonly IAnimeManager _animeManager;

        public AnimeController(IAnimeManager animeManager)
        {
            _animeManager = animeManager;
        }


        /// <summary>
        /// Register a new anime
        /// </summary>
        /// <param name="createAnime"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(AnimeDTO createAnime)
        {
            try
            {
                AnimeDTO animeResponse = await _animeManager.Create(createAnime);

                return Ok(animeResponse);
            }
            catch (AutoMapperMappingException)
            {
                return BadRequest("Não foi possível converter os dados");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        /// <summary>
        /// Search a list of registered animes
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet("{page}")]
        public async Task<IActionResult> GetAllAsync([FromRoute] int page)
        {
            try
            {
                List<AnimeDTO> listResponse = await _animeManager.GetAllAsync(page);
                return Ok(listResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
