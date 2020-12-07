using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model
{
    public class ComponentList
    {
        public List<Component> Components { get; set; }

        public ComponentList()
        {
            Components = new List<Component>();
        }

        public int Size()
        {
            return Components.Count;
        }

        public Component GetComponent(int index)
        {
            return Components[index];
        }

        public void AddComponent(Component component)
        {
            Components.Add(component);
        }
    }
}