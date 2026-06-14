using MimeDetective;

namespace BamirnoMimeMapper;

public class Map
{
    private readonly Dictionary<string, string> _mimeMap = new()
    {
        [".jpg"] = "image/jpeg",
        [".jpeg"] = "image/jpeg",
        [".png"] = "image/png",
        [".gif"] = "image/gif",
        [".bmp"] = "image/bmp",
        [".webp"] = "image/webp",
        [".tiff"] = "image/tiff",
        [".ico"] = "image/x-icon",
        [".svg"] = "image/svg+xml",
        [".heic"] = "image/heic",
        [".heif"] = "image/heif",
        [".jfif"] = "image/jpeg",
        [".pjpeg"] = "image/pjpeg",
        [".pjp"] = "image/pjpeg",

        [".mp3"] = "audio/mpeg",
        [".wav"] = "audio/wav",
        [".ogg"] = "audio/ogg",
        [".oga"] = "audio/ogg",
        [".flac"] = "audio/flac",
        [".aac"] = "audio/aac",
        [".m4a"] = "audio/mp4",
        [".opus"] = "audio/opus",
        [".mid"] = "audio/midi",
        [".midi"] = "audio/midi",

        [".mp4"] = "video/mp4",
        [".m4v"] = "video/x-m4v",
        [".mov"] = "video/quicktime",
        [".avi"] = "video/x-msvideo",
        [".wmv"] = "video/x-ms-wmv",
        [".flv"] = "video/x-flv",
        [".mkv"] = "video/x-matroska",
        [".webm"] = "video/webm",
        [".3gp"] = "video/3gpp",
        [".3g2"] = "video/3gpp2",

        [".pdf"] = "application/pdf",
        [".doc"] = "application/msword",
        [".docx"] = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
        [".docm"] = "application/vnd.ms-word.document.macroEnabled.12",
        [".xls"] = "application/vnd.ms-excel",
        [".xlsx"] = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        [".ppt"] = "application/vnd.ms-powerpoint",
        [".pptx"] = "application/vnd.openxmlformats-officedocument.presentationml.presentation",
        [".odt"] = "application/vnd.oasis.opendocument.text",
        [".ods"] = "application/vnd.oasis.opendocument.spreadsheet",
        [".odp"] = "application/vnd.oasis.opendocument.presentation",
        [".rtf"] = "application/rtf",
        [".epub"] = "application/epub+zip",
        [".pages"] = "application/x-iwork-pages-sffpages",
        [".numbers"] = "application/x-iwork-numbers-sffnumbers",
        [".key"] = "application/x-iwork-keynote-sffkey",

        [".zip"] = "application/zip",
        [".rar"] = "application/x-rar-compressed",
        [".7z"] = "application/x-7z-compressed",
        [".tar"] = "application/x-tar",
        [".gz"] = "application/gzip",
        [".bz2"] = "application/x-bzip2",
        [".xz"] = "application/x-xz",
        [".lz"] = "application/x-lzip",
        [".z"] = "application/x-compress",

        [".js"] = "application/javascript",
        [".ts"] = "application/typescript",
        [".json"] = "application/json",
        [".xml"] = "application/xml",
        [".html"] = "text/html",
        [".htm"] = "text/html",
        [".css"] = "text/css",
        [".php"] = "application/x-httpd-php",
        [".asp"] = "application/x-aspx",
        [".aspx"] = "application/x-aspx",
        [".py"] = "text/x-python",
        [".rb"] = "application/x-ruby",
        [".sh"] = "application/x-sh",
        [".bat"] = "application/x-bat",
        [".c"] = "text/x-c",
        [".cpp"] = "text/x-c",
        [".cs"] = "text/plain",
        [".java"] = "text/x-java-source",
        [".go"] = "text/x-go",
        [".swift"] = "text/x-swift",

        [".ttf"] = "font/ttf",
        [".otf"] = "font/otf",
        [".woff"] = "font/woff",
        [".woff2"] = "font/woff2",
        [".eot"] = "application/vnd.ms-fontobject",

        [".db"] = "application/x-sqlite3",
        [".sqlite"] = "application/x-sqlite3",
        [".mdb"] = "application/x-msaccess",
        [".accdb"] = "application/x-msaccess",
        [".bak"] = "application/octet-stream",
        [".bin"] = "application/octet-stream",
        [".dat"] = "application/octet-stream",
        [".dmp"] = "application/vnd.tcpdump.pcap",

        [".eml"] = "message/rfc822",
        [".msg"] = "application/vnd.ms-outlook",
        [".ics"] = "text/calendar",
        [".vcf"] = "text/vcard",

        [".dwg"] = "image/vnd.dwg",
        [".dxf"] = "image/vnd.dxf",
        [".gpx"] = "application/gpx+xml",
        [".kml"] = "application/vnd.google-earth.kml+xml",
        [".kmz"] = "application/vnd.google-earth.kmz",
        [".shp"] = "application/octet-stream",
        [".shx"] = "application/octet-stream",
        [".dbf"] = "application/octet-stream",

        [".mat"] = "application/x-matlab-data",
        [".m"] = "text/x-octave",
        [".nc"] = "application/x-netcdf",
        [".hdf"] = "application/x-hdf",
        [".cdf"] = "application/x-cdf",
        [".grib"] = "application/x-grib",

        [".exe"] = "application/vnd.microsoft.portable-executable",
        [".msi"] = "application/x-msdownload",
        [".apk"] = "application/vnd.android.package-archive",
        [".dmg"] = "application/x-apple-diskimage",
        [".pkg"] = "application/octet-stream",
        [".deb"] = "application/x-debian-package",
        [".rpm"] = "application/x-rpm",
        [".appx"] = "application/vnd.ms-appx",
        [".jar"] = "application/java-archive",
        [".war"] = "application/java-archive",

        [".ini"] = "text/plain",
        [".cfg"] = "text/plain",
        [".conf"] = "text/plain",
        [".reg"] = "text/plain",
        [".sys"] = "application/octet-stream",
        [".dll"] = "application/x-msdownload",
        [".drv"] = "application/octet-stream",
        [".icns"] = "image/x-icns",
        [".plist"] = "application/xml",

        [".iso"] = "application/x-iso9660-image",
        [".vhd"] = "application/x-vhd",
        [".vhdx"] = "application/x-vhdx",
        [".vmdk"] = "application/x-vmdk",
        [".ova"] = "application/x-virtualbox-ova",
        [".ovf"] = "application/x-virtualbox-ovf",

        [".psd"] = "image/vnd.adobe.photoshop",
        [".ai"] = "application/postscript",
        [".indd"] = "application/x-indesign",
        [".sketch"] = "application/x-sketch",
        [".fig"] = "application/x-xfig",
        [".blend"] = "application/x-blender",
        [".3ds"] = "image/x-3ds",
        [".obj"] = "application/x-tgif",
        [".fbx"] = "application/octet-stream"
    };

    /// <summary>
    /// Get File MimeType From File Extension
    /// </summary>
    /// <param name="extension"></param>
    /// <returns></returns>
    public string FromExtension(string extension)
    {
        try
        {
            extension = extension.Replace(".", "").ToLowerInvariant();
            return _mimeMap[$".{extension}"];
        }
        catch
        {
            return string.Empty;
        }
    }

    /// <summary>
    /// Get File Extension From File MimeType
    /// </summary>
    /// <param name="mimeType"></param>
    /// <returns></returns>
    public string ToExtension(string mimeType)
    {
        try
        {
            mimeType = mimeType.ToLowerInvariant();
            return _mimeMap?.Where(s => s.Value == mimeType)?.FirstOrDefault().Key;
        }
        catch
        {
            return string.Empty;
        }
    }

    /// <summary>
    /// Check File Extension With Content
    /// True = Same
    /// False = Different
    /// </summary>
    /// <param name="extension"></param>
    /// <param name="fileData"></param>
    /// <returns></returns>
    public bool IsTrustedFile(string extension, byte[] fileData)
    {
        try
        {
            if (fileData == null || fileData.Length == 0 || string.IsNullOrWhiteSpace(extension))
                return false;

            extension = extension.StartsWith(".") ? extension.ToLowerInvariant() : "." + extension.ToLowerInvariant();

            if (!_mimeMap.TryGetValue(extension, out var expectedMime))
                return false;

            var inspector = new ContentInspectorBuilder
            {
                Definitions = MimeDetective.Definitions.DefaultDefinitions.All()
            }.Build();

            var result = inspector.Inspect(fileData);
            if (result == null || result.Count() == 0)
                return false;

            var detectedMime = result[0]?.Definition?.File?.MimeType;
            if (string.IsNullOrWhiteSpace(detectedMime))
                return false;

            return detectedMime.Equals(expectedMime, StringComparison.OrdinalIgnoreCase);
        }
        catch
        {
            return false;
        }
    }

}