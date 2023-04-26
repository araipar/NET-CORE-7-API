using System;
using MagicVila_Restful_Course.Models;
namespace MagicVila_Restful_Course.Data
{
    public static class VillaStore
    {
        public static List<Villa> villaList = new List<Villa> {
            new Villa{Id=1,Name="Pool View" },
            new Villa{Id=2,Name="Beach View" }
            };
    }
}

