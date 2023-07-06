using Microsoft.AspNetCore.Http;

namespace albinasHotelGuide.WebMVC.Helpers.Abstract
{
    public interface IFileHelper
    {
        void DeleteFile(string imageUrl);
        string UploadFile(IFormFile file);

    }
}
