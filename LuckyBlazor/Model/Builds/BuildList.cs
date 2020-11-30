using System.Collections.Generic;
using System.IO.IsolatedStorage;

namespace LuckyBlazor.Model
{
    public class BuildList
    {
        public List<Build> Builds { get; set; }

        public BuildList()
        {
            Builds = new List<Build>();
        }

        public int Size()
        {
            return Builds.Count;
        }

        public Build GetBuild(int index)
        {
            return Builds[index];
        }

        public List<Build> GetBuildsByUserId(int userId)
        {
             List<Build> getBuildsByUserId = new List<Build>();
            foreach (var VARIABLE in Builds)
            {
                if(VARIABLE.UserId == userId)
                    getBuildsByUserId.Add(VARIABLE);
            }

            return getBuildsByUserId;
        }

        public void AddBuild(Build build)
        {
            Builds.Add(build);
        }

        public int GetUserId()
        {
            if (Builds != null)
            {
                return GetBuild(0).UserId;
            }

            return -1;
        }

        // public IList<System.ComponentModel.Component> GetComponents()
        // {
        //     return 
        // }
    }
}