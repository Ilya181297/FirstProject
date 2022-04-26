using Bloggers.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с блогерами
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BloggersController : Controller
    {
        private ILogger<BloggersController> _logger;
        private IDataManager _dataManager;
        public BloggersController(IDataManager dataManager, ILogger<BloggersController> logger)
        {
            _dataManager = dataManager;
            _logger = logger;
        }

        /// <summary>
        /// Возвращает список всех блогеров
        /// </summary>
        [HttpGet]
        public ActionResult<List<Blogger>> Get()
        {
            try
            {
                return Ok(_dataManager.GetBloggers());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while GetBloggers");
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Удаляет блогера
        /// </summary>
        /// <param name="id">Идентификатор блогера</param>
        /// <returns>True - прошло успешно, иначе False</returns>
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                var result = _dataManager.DeleteBlogger(id);
                if (!result)
                    return NotFound($"Blogger with Id={id} not found");

                return Ok(_dataManager.DeleteBlogger(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Добавляет нового блогера
        /// </summary>
        /// <param name="blogger">Модель блогера</param>
        /// <returns>True - прошло успешно, иначе False</returns>
        [HttpPost]
        public ActionResult<bool> Post(Blogger blogger)
        {
            try
            {
                #region Check
                if (blogger is null)
                    return BadRequest("Blogger is null");

                if (string.IsNullOrWhiteSpace(blogger.Name))
                    return BadRequest($"{nameof(blogger.Name)} is empty");

                if (string.IsNullOrWhiteSpace(blogger.Post))
                    return BadRequest($"{nameof(blogger.Post)} is empty");

                #endregion

                return Ok(_dataManager.InsertBlogger(blogger.Name, blogger.Post));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Изменение блогера
        /// </summary>
        /// <param name="blogger">Модель блогера для изменения</param>
        /// <returns>True - прошло успешно, иначе False</returns>
        [HttpPut]
        public ActionResult<bool> Put(Blogger blogger)
        {
            try
            {
                #region Check
                if (blogger is null)
                    return BadRequest("Blogger is null");

                if (string.IsNullOrWhiteSpace(blogger.Name))
                    return BadRequest($"{nameof(blogger.Name)} is empty");

                if (string.IsNullOrWhiteSpace(blogger.Post))
                    return BadRequest($"{nameof(blogger.Post)} is empty");

                var existBlogger = _dataManager.Get(blogger.Id);
                if (existBlogger is null)
                    return NotFound($"Blogger with Id={blogger.Id} not found");

                #endregion

                return Ok(_dataManager.UpdateBlogger(blogger.Id, blogger.Name, blogger.Post));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

    }

}
