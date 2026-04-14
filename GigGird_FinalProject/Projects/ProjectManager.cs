using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Projects
{
    internal class ProjectManager
    {
        //TODO: Singleton? Only one instance of Project Manager
        public ProjectManager() { }

        List<BaseContract> CurrentProjects = new List<BaseContract>();
        List<BaseContract> PastProjects = new List<BaseContract>();
    }
}
