using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace Jurnal10_103022300030
{
    [ApiController]
    [Route("apu/[controller]")]
    public class Movie
    {
        
        private static List<Movie> TitleList = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "", ""),
            new Movie("The Dark Knight", "", "")
        };
    [HttpGet]

    public 

    }
}
