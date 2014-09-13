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
    public List<Category> Categories { get; set; }
    public List<Resource> Resources { get; set; }

    public BrainGrowContext()
    {
      this.Categories = new List<Category>();
      AddCategory("Computers", null, "This category contains all manner of topics concerning computers. From Linux to Windows, from Intel to Apple to the Raspberry Pi, from software to hardware.");
      AddCategory("Linux", "Computers", "This category is all about computers running the Linux operating system.  Topics range from configuring it to using it to programming it.");
      AddCategory("Linux How To", "Linux", "");
      AddCategory("Scripting in the Linux shell", "Linux", "");
      AddCategory("Linux File System", "Linux", "");
      AddCategory("Linux Utilities", "Linux", "");
      AddCategory("cron", "Linux Utilities", "");
      AddCategory("xdotool", "Linux Utilities", "");
      AddCategory("Windows", "Computers", "This category is all about comptuers running the Microsoft Windows operating system.  Topics range from configuring it to using it to programming it.");
      AddCategory("Programming with Windows", "Windows", "");
      AddCategory("MVC", "Programming with Windows", "");
      AddCategory("Web API", "Programming with Windows", "");
      AddCategory("Dependency Injection", "Programming with Windows", "");
      AddCategory("SignalR", "Programming with Windows", "");
      AddCategory("Games", null, "This category contains topics about all types of games, including (but not limited to) board, card and video games.");
      AddCategory("Swimming Pools & Hot Tubs", null, "This category contains topics about pools and hot tubs.  Specifically, about the pool and the hot tub that I own.");

      this.Resources = new List<Resource>()
        {
          new ViewResource()
          {
            Category = this.Categories.Single(c => c.Name == "Computers"),
            Title = "Glossary of Computer Terms",
            Description = "This is a Glossary of Terms, Acronyms and Abbreviations related to the very broad field of computers.",
            ViewName = "_computerGlossary"
          },
          new HyperlinkResource()
          {
            Category = this.Categories.Single(c => c.Name == "Linux"),
            Title = "Low Fat Linux - Free Linux Training",
            Description = "[...] a free course for learning Linux, a version of Unix that runs on ordinary personal computers. [It was created] for people who want to learn the basics of using Linux, and thereby Unix, without getting bogged down in too much detail or technobabble.",
            Url = "http://lowfatlinux.com/"
          },
          new HyperlinkResource()
          {
            Category = this.Categories.Single(c => c.Name == "Linux File System"),
            Title = "Low Fat Linux - File System",
            Description = "When Linux is installed, a file system is carved out of a chunk of hard disk and formatted so that Linux can use it. A hierarchical (treelike) structure for storing files imposes some order on the file system to help both you and Linux find needed files.",
            Url = "http://lowfatlinux.com/linux-files.html"
          },
          new ViewResource()
          {
            Category = this.Categories.Single(c => c.Name == "Linux How To"),
            Title = "How to Autostart apps in Linux",
            Description = "This resource shows how to autostart apps in a miriad of ways in Linux, in and out of the graphical environment.",
            ViewName = "_linuxHowToAutoStart"
          }
        };
    }

    private void AddCategory(string name, string parentName, string description)
    {
      if (this.Categories.Any(c => c.Name.ToLower() == name.ToLower()))
      {
        throw new InvalidOperationException("Duplicate Category Name (\"" + name + "\") not allowed.");
      }
      Category parentCategory = null;
      if (!string.IsNullOrEmpty(parentName))
      {
        parentCategory = this.Categories.Single(c => c.Name.ToLower() == parentName.ToLower());
      }
      var category = new Category() { Name = name, Description = description, Parent = parentCategory };
      this.Categories.Add(category);
    }

  }

}
