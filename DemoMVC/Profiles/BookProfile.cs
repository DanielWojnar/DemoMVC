using AutoMapper;
using DemoMVC.Models;

namespace DemoASP.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() {
            CreateMap<BookFormInput, Book>();
        }
    }
}
