using Microsoft.Extensions.Options;
using System;
using TestDocker.DAL;
using TestDocker.Models;

namespace TestDocker.Business
{
    public class AuthorsBusiness
    {
        private DbStrings _settings { get; set; }

        public string First()
        {
            return new AuthorsRepository().First();
        }
    }
}
