using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyApp.Models
{
    public class IndexModel
    {
        public SelectList CategoriesSelectList { get; set; }
        public Dictionary<string, string[]> Quotes { get; set; }

        public string Category { get; set; }

        public IndexModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            CategoriesSelectList = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Real", Value = "Real" },
                    new SelectListItem { Text = "Funny" , Value = "Funny" },
                    new SelectListItem { Text = "Motivational" , Value = "Motivational" },
                    new SelectListItem { Text = "Philosophical" , Value = "Philosophical" },
                }, "Value", "Text");

            string[] Philosophical = new string[]
            {
                "Dont forget: A man with one watch knows what time it is; a man with two watches is never quite sure. - Lee Segall",
                "Dont forget: Believe those who are seeking the truth; doubt those who find it. - André Gide",
                "Dont forget: Losing an illusion makes you wiser than finding a truth. - Ludwig Börne ",
                "Dont forget: A gun gives you the body, not the bird. - Henry David Thoreau"
            };
            string[] Funny = new string[]
            {
                "Dont forget: To bring a towel!",
                "Dont forget: What’s brown and sticky? A stick! ",
                "Dont forget: Two drums and a cymbal fall off a cliff. Ba-dum Tish! ",
                "Dont forget: What does a nosey pepper do? Gets jalapeno business!"
            };
            string[] Motivational = new string[]
            {
                "Dont forget to be awesome!",
                "Dont forget: Dream, imagine, believe.",
                "Dont forget: Kindness is always fashionable. ",
                "Dont forget: Good things takes time."
            };
            string[] Real = new string[]
            {
                "Dont forget: Your keys.",
                "Dont forget: To smile.",
                "Dont forget: To turn off the lights.",
                "Dont forget: Sit correctly."
            };
            Quotes = new Dictionary<string, string[]>();
            Quotes["Philosophical"] = Philosophical;
            Quotes["Funny"] = Funny;
            Quotes["Motivational"] = Motivational;
            Quotes["Real"] = Real;

        }
    }
}