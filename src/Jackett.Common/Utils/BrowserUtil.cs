using System;

namespace Jackett.Common.Utils
{
    public static class BrowserUtil
    {
        // When updating these make sure they are not detected by the incapsula bot detection engine
        // (e.g. kickasstorrent indexer)
        public static string ChromeUserAgent => Environment.OSVersion.Platform == PlatformID.Unix ?
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:77.0) Gecko/20100101 Firefox/77.0" :
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:77.0) Gecko/20100101 Firefox/77.0";

    }
}
