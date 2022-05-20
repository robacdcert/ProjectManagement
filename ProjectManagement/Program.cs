using ProjectManagementClasses;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

const string server = "localhost\\sqlexpress";
const string database = "ProjectManagementDb";

var db = new AppDbContext();

var workctrl = new WorkController(server, database);
workctrl.OpenConnection();

var projctrl = new ProjectsController(server, database);
projctrl.OpenConnection();

var resctrl = new ResourcesController(server, database);
resctrl.OpenConnection();

var work = workctrl.GetAllWorks();
var projects = projctrl.GetAllProjects();
var resources = resctrl.GetAllResources();