using ProjectManagementClasses;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

const string server = "localhost\\sqlexpress";
const string database = "ProjectManagementDb";

var db = new AppDbContext();

var workctrl = new WorkController(server, database);
workctrl.OpenConnection();

var works = workctrl.GetAllWorks();
var projects = workctrl.GetAllWorks();