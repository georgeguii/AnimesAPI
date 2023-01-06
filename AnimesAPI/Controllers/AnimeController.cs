using AnimesAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using AnimesAPI.Manager.Interfaces;

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
        /// Cadastrar um novo anime
        /// </summary>
        /// <param name="createAnime"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(AnimeDTO createAnime)
        {
            try
            {
                AnimeDTO animeResponse = _animeManager.Create(createAnime);

                return Ok(animeResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        /// <summary>
        /// Busca uma lista de animes cadastrados
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
