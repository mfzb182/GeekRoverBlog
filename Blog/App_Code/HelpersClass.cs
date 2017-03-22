using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.App_Code
{
    public class DropDownList
    {
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }
    }

    public class HelpersClass
    {

        static DcDataContext dc = new DcDataContext();

        static public List<Admin> Admins()
        {
            return dc.Admins.Select(m => new Admin { Username = m.Username, Fullname = m.Fullname }).ToList();
        }
        static public List<Menu> Menu()
        {
            return dc.Menus.Select(m => new Menu { Id = m.Id, Name = m.Name }).ToList();
        }
        static public List<Image> Slider()
        {
            return dc.Images.Select(m => new Image { Id = m.Id, Alt = m.Alt, Url = m.Url }).ToList();
        }
        static public List<Post> Posts(Guid? Group = null, string Username = null)
        {
            var posts = dc.Posts.Select(m => new Post { Id = m.Id, Group_Id = m.Group_Id, Title = m.Title, Abstract = m.Abstract, Body = m.Body, Date = m.Date, Admin_Username = m.Admin_Username });
            if (Group != null)
                posts = posts.Where(m => m.Group_Id == Group);
            if (Username != null)
                posts = posts.Where(m => m.Admin_Username == Username);

            return posts.OrderByDescending(m => m.Id).Take(25).ToList();
        }
        static public List<DropDownList> Groups()
        {
            List<DropDownList> output = new List<DropDownList>();
            foreach (var item in dc.Groups)
            {
                output.Add(new DropDownList { DisplayMember = item.Name, ValueMember = item.Id.ToString() });
            }
            return output;
        }

    }
}