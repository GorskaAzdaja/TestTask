using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Models.RepositoryInterface;

namespace TodoApi.Controllers
{

    // ------------------------------------------------------------------------------------
    // I didn't create views yet, since I'm not sure if this is the correct way to do this.
    // If it isn't, I can do it without the repository pattern, and try this in a different
    // way later
    // ------------------------------------------------------------------------------------
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly DatabaseContext _dbContext;
        
        public ProjectController(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public ActionResult Index()
        {
            var project = _projectRepository.FindAll();
            return View(project);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectRepository.Create(project);
                _projectRepository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // This was kind of a rabbit hole for FindByCondition, but it seems good to use

            var project = _projectRepository.FindByCondition(project => project.Id.Equals(id));
            return View(project);
        }
        [HttpPost] 
        public ActionResult Edit(Project project)
        {
            if(ModelState.IsValid)
            {
                _projectRepository.Update(project);
                _projectRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(project);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var project = _projectRepository.FindByCondition(project => project.Id.Equals(id));
            return View(project);
        }

        [HttpPost]
        public Action ConfirmDelete(Project project)
        {
            _projectRepository.Delete(project);
            _projectRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
