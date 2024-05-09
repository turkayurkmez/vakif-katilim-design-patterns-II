using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /*
     * Problem:
     *   Bellekte ağaç-dal-yaprak biçiminde iç içe hiyerarşik bir biçimde tutmanız gereken nesneleriniz var. Bu ihtiyacı nasıl karşılarsınız?
     */

    public class Category : IComparable<Category>
    {

        public string Name { get; set; }
        public int CompareTo(Category? other)
        {
           return this.Name.Equals(other?.Name) ? 1 : -1;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Composite<T> where T:IComparable<T>,new()
    {
        public T Node { get; set; } = new T();
        public List<Composite<T>> Children { get; set; } = new List<Composite<T>>();

        public Composite<T> Add(T child) 
        {
            Composite<T> composite = new Composite<T>() { Node = child};
            Children.Add(composite);
            return composite;
        }

        public static void Show(int level, Composite<T> composite, TreeView treeView)
        {
            TreeNode treeNode = new TreeNode(composite.Node.ToString());
            addItemToNode(composite, treeNode);
            treeView.Nodes.Add(treeNode);
        }

        private static void addItemToNode(Composite<T> composite, TreeNode treeNode)
        {
            TreeNode child = treeNode.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                addItemToNode(item, child);
            }
        }
    }
}
