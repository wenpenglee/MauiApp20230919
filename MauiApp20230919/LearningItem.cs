using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919
{
    public class LearningItem
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
    public class LearningData
    {
        public List<LearningItem> Animals { get; set; }
        public List<LearningItem> Letters { get; set; }
        public List<LearningItem> Numbers { get; set; }
        public List<LearningItem> Colors { get; set; }
        public List<LearningItem> Fruits { get; set; }
        public List<LearningItem> Shapes { get; set; }

        public LearningData()
        {
            Animals = new List<LearningItem>()
            {
                new LearningItem() { Name = "Lion", ImageUrl = "lion.png" },
                new LearningItem() { Name = "Fox", ImageUrl = "fox.png" },
                new LearningItem() { Name = "Tiger", ImageUrl = "tiger.png" },
                new LearningItem() { Name = "Elephant", ImageUrl = "Elephant.png" },
                new LearningItem() { Name = "Zebra", ImageUrl = "zebra.png" },
                new LearningItem() { Name = "Monkey", ImageUrl = "monkey.png" },
                new LearningItem() { Name = "Giraffe", ImageUrl = "giraffe.png" },
                new LearningItem() { Name = "Dog", ImageUrl = "Dog.png" },
                new LearningItem() { Name = "Cat", ImageUrl = "cat.png" },
                new LearningItem() { Name = "Rabbit", ImageUrl = "rabbit.png" },
                new LearningItem() { Name = "Horse", ImageUrl = "horse.png" },
            };


            Letters = new List<LearningItem>()
            {
               new LearningItem(){Name="a", ImageUrl="alphabet_a.png"},
               new LearningItem(){Name="b", ImageUrl="alphabet_b.png"},
               new LearningItem(){Name="c", ImageUrl="alphabet_c.png"},
               new LearningItem(){Name="d", ImageUrl="alphabet_d.png"},
               new LearningItem(){Name="e", ImageUrl="alphabet_e.png"},
               new LearningItem(){Name="f", ImageUrl="alphabet_f.png"},
               new LearningItem(){Name="g", ImageUrl="alphabet_g.png"},
               new LearningItem(){Name="h", ImageUrl="alphabet_h.png"},
               new LearningItem(){Name="i", ImageUrl="alphabet_i.png"},
               new LearningItem(){Name="j", ImageUrl="alphabet_j.png"},
               new LearningItem(){Name="k", ImageUrl="alphabet_k.png"},
               new LearningItem(){Name="l", ImageUrl="alphabet_l.png"},
               new LearningItem(){Name="m", ImageUrl="alphabet_m.png"},
               new LearningItem(){Name="n", ImageUrl="alphabet_n.png"},
               new LearningItem(){Name="o", ImageUrl="alphabet_o.png"},
               new LearningItem(){Name="p", ImageUrl="alphabet_p.png"},
               new LearningItem(){Name="q", ImageUrl="alphabet_q.png"},
               new LearningItem(){Name="r", ImageUrl="alphabet_r.png"},
               new LearningItem(){Name="s", ImageUrl="alphabet_s.png"},
               new LearningItem(){Name="t", ImageUrl="alphabet_t.png"},
               new LearningItem(){Name="u", ImageUrl="alphabet_u.png"},
               new LearningItem(){Name="v", ImageUrl="alphabet_v.png"},
               new LearningItem(){Name="w", ImageUrl="alphabet_w.png"},
               new LearningItem(){Name="x", ImageUrl="alphabet_x.png"},
               new LearningItem(){Name="y", ImageUrl="alphabet_y.png"},
               new LearningItem(){Name="z", ImageUrl="alphabet_z.png"},
            };

            Numbers = new List<LearningItem>()
            {
              new LearningItem() { Name = "One", ImageUrl = "one.png" },
              new LearningItem() { Name = "Two", ImageUrl = "two.png" },
              new LearningItem() { Name = "Three", ImageUrl = "three.png" },
              new LearningItem() { Name = "Four", ImageUrl = "four.png" },
              new LearningItem() { Name = "Five", ImageUrl = "five.png" },
              new LearningItem() { Name = "Six", ImageUrl = "six.png" },
              new LearningItem() { Name = "Seven", ImageUrl = "seven.png" },
              new LearningItem() { Name = "Eight", ImageUrl = "eight.png" },
              new LearningItem() { Name = "Nine", ImageUrl = "nine.png" },
              new LearningItem() { Name = "Ten", ImageUrl = "ten.png" },

            };

            Colors = new List<LearningItem>()
            {
               new LearningItem() { Name = "Black", ImageUrl = "color_black.png" },
               new LearningItem() { Name = "Blue", ImageUrl = "color_blue.png" },
               new LearningItem() { Name = "Gray", ImageUrl = "color_gray.png" },
               new LearningItem() { Name = "Green", ImageUrl = "color_green.png" },
               new LearningItem() { Name = "Orange", ImageUrl = "color_orange.png" },
               new LearningItem() { Name = "Purple", ImageUrl = "color_purple.png" },
               new LearningItem() { Name = "Red", ImageUrl = "color_red.png" },
               new LearningItem() { Name = "Yellow", ImageUrl = "color_yellow.png" },

            };

            Fruits = new List<LearningItem>()
           {
               new LearningItem { Name = "Apple", ImageUrl = "apple.png" },
               new LearningItem { Name = "Banana", ImageUrl = "banana.png" },
               new LearningItem { Name = "Orange", ImageUrl = "orange.png" },
               new LearningItem { Name = "Strawberry", ImageUrl = "strawberry.png" },
               new LearningItem { Name = "Mango", ImageUrl = "mango.png" },
               new LearningItem { Name = "Kiwi", ImageUrl = "kiwi.png" },
               new LearningItem { Name = "Watermelon", ImageUrl = "watermelon.png" },
               new LearningItem { Name = "Grapes", ImageUrl = "grapes.png" },
               new LearningItem { Name = "Pineapple", ImageUrl = "pineapple.png" },
               new LearningItem { Name = "Coconut", ImageUrl = "coconut.png" },
               new LearningItem { Name = "Peach", ImageUrl = "peach.png" },
               new LearningItem { Name = "Apricot", ImageUrl = "apricot.png" },
               new LearningItem { Name = "Guava", ImageUrl = "guava.png" },

           };

            Shapes = new List<LearningItem>()
            {
               new LearningItem() { Name = "Triangle", ImageUrl = "triangle.png" },
               new LearningItem() { Name = "Circle", ImageUrl = "circle.png" },
               new LearningItem() { Name = "Square", ImageUrl = "square.png" },
               new LearningItem() { Name = "Rectangle", ImageUrl = "rectangle.png" },
               new LearningItem() { Name = "Oval", ImageUrl = "oval.png" },
               new LearningItem() { Name = "Star", ImageUrl = "star.png" },
               new LearningItem() { Name = "Heart", ImageUrl = "heart.png" },
               new LearningItem() { Name = "Arrow", ImageUrl = "arrow.png" },
               new LearningItem() { Name = "Pyramid", ImageUrl = "pyramid.png" },
               new LearningItem() { Name = "Cube", ImageUrl = "cube.png" },

            };
        }
    }
}
