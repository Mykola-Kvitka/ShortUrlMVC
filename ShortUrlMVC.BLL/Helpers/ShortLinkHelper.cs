using System;
using Microsoft.AspNetCore.WebUtilities;

namespace ShortUrlMVC.BLL.Helpers
{
    public static class ShortLinkHelper
    {
        public static string GetUrlChunk(string URL)
        {
            // Transform the "Id" property on this object into a short piece of text
            return WebEncoders.Base64UrlEncode(BitConverter.GetBytes(URL.GetHashCode()));
        }

        public static int GetId(string urlChunk)
        {
            // Reverse our short url text back into an interger Id
            return BitConverter.ToInt32(WebEncoders.Base64UrlDecode(urlChunk));
        }

    }
}
