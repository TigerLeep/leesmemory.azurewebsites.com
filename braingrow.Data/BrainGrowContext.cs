using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using braingrow.Core;

namespace braingrow.Data
{
    public class BrainGrowContext : IBrainGrowContext
    {
      public Category RootCategory { get; set; }
      public List<Resource> Resources { get; set; }

      public BrainGrowContext()
      {
        this.RootCategory = new Category() { Name = "Root", Parent = null };

        Category computersCategory = new Category() { Name = "Computers", Parent = this.RootCategory};

        Category computerGlossaryCategory = new Category() { Name = "Glossary of Terms, Acronyms and Abbreviations", Parent = computersCategory };

        Category linuxCategory = new Category() { Name = "Linux", Parent = computersCategory };
        Category linuxScriptingCategory = new Category() { Name = "Scripting in the Linux shell", Parent = linuxCategory };
        Category linuxFileSystemCategory = new Category() { Name = "Layout of the Linux File System", Parent = linuxCategory };
        Category linuxUtilitiesCategory = new Category() { Name = "Linux Utilities", Parent = linuxCategory };
        Category linuxCronCategory = new Category() { Name = "cron", Parent = linuxUtilitiesCategory };
        Category linuxXdotoolCategory = new Category() { Name = "xdotool", Parent = linuxUtilitiesCategory };

        Category windowsCategory = new Category() { Name = "Windows", Parent = computersCategory };
        Category windowsProgrammingCategory = new Category() { Name = "Programming", Parent = windowsCategory };
        Category MVCCategory = new Category() { Name = "MVC", Parent = windowsCategory };
        Category WebAPICategory = new Category() { Name = "Web API", Parent = windowsCategory };
        Category DependencyInjectionCategory = new Category() { Name = "Dependency Injection", Parent = windowsCategory };

        this.Resources = new List<Resource>()
        {
          new HyperlinkResource()
          {
            Category = linuxCategory,
            Text = "Low Fat Linux - Free Linux Training",
            Description = "[...] a free course for learning Linux, a version of Unix that runs on ordinary personal computers. [It was created] for people who want to learn the basics of using Linux, and thereby Unix, without getting bogged down in too much detail or technobabble.",
            Url = "http://lowfatlinux.com/"
          },
          new HyperlinkResource()
          {
            Category = linuxFileSystemCategory,
            Text = "Low Far Linux - File System",
            Description = "When Linux is installed, a file system is carved out of a chunk of hard disk and formatted so that Linux can use it. A hierarchical (treelike) structure for storing files imposes some order on the file system to help both you and Linux find needed files.",
            Url = "http://lowfatlinux.com/linux-files.html"
          }
        };
      }

    }
}
