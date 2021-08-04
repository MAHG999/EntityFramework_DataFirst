using ConsoleDataFirst.Models;
using System;
using System.Linq;

namespace ConsoleDataFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PruebasContext())
            {
                #region InsertField
                var postInsert = new Post();
                postInsert.Body = "Proyecto de Trabajo";
                postInsert.Title = "Project";
                context.Posts.Add(postInsert);
                context.SaveChanges();
                #endregion

                #region UpdateField
                var postUpdate = context.Posts.Find(2);
                postUpdate.Body = "Our Project";
                postUpdate.Title = "Project 1";
                context.Entry(postUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                #endregion

                #region DeleteField
                var postDelete = context.Posts.Find(1);
                context.Remove(postDelete);
                context.SaveChanges();
                #endregion

                #region LecturaCampos
                foreach (var post in context.Posts.ToList())
                {
                    Console.WriteLine(post.PostId + " " + post.Title);
                    //Console.WriteLine(post.Title);
                }
                #endregion
            }
        }
    }
}
