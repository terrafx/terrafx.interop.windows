// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CFSTR
{
    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_NULL"]/*' />
    [NativeTypeName("#define CFSTR_MIME_NULL NULL")]
    public const int CFSTR_MIME_NULL = 0;

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_TEXT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_TEXT (TEXT(\"text/plain\"))")]
    public const string CFSTR_MIME_TEXT = ("text/plain");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_RICHTEXT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_RICHTEXT (TEXT(\"text/richtext\"))")]
    public const string CFSTR_MIME_RICHTEXT = ("text/richtext");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_MANIFEST"]/*' />
    [NativeTypeName("#define CFSTR_MIME_MANIFEST (TEXT(\"text/cache-manifest\"))")]
    public const string CFSTR_MIME_MANIFEST = ("text/cache-manifest");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_WEBVTT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_WEBVTT (TEXT(\"text/vtt\"))")]
    public const string CFSTR_MIME_WEBVTT = ("text/vtt");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_BITMAP"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_BITMAP (TEXT(\"image/x-xbitmap\"))")]
    public const string CFSTR_MIME_X_BITMAP = ("image/x-xbitmap");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_POSTSCRIPT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_POSTSCRIPT (TEXT(\"application/postscript\"))")]
    public const string CFSTR_MIME_POSTSCRIPT = ("application/postscript");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_AIFF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_AIFF (TEXT(\"audio/aiff\"))")]
    public const string CFSTR_MIME_AIFF = ("audio/aiff");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_BASICAUDIO"]/*' />
    [NativeTypeName("#define CFSTR_MIME_BASICAUDIO (TEXT(\"audio/basic\"))")]
    public const string CFSTR_MIME_BASICAUDIO = ("audio/basic");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_WAV"]/*' />
    [NativeTypeName("#define CFSTR_MIME_WAV (TEXT(\"audio/wav\"))")]
    public const string CFSTR_MIME_WAV = ("audio/wav");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_WAV"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_WAV (TEXT(\"audio/x-wav\"))")]
    public const string CFSTR_MIME_X_WAV = ("audio/x-wav");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_GIF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_GIF (TEXT(\"image/gif\"))")]
    public const string CFSTR_MIME_GIF = ("image/gif");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_PJPEG"]/*' />
    [NativeTypeName("#define CFSTR_MIME_PJPEG (TEXT(\"image/pjpeg\"))")]
    public const string CFSTR_MIME_PJPEG = ("image/pjpeg");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_JPEG"]/*' />
    [NativeTypeName("#define CFSTR_MIME_JPEG (TEXT(\"image/jpeg\"))")]
    public const string CFSTR_MIME_JPEG = ("image/jpeg");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_TIFF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_TIFF (TEXT(\"image/tiff\"))")]
    public const string CFSTR_MIME_TIFF = ("image/tiff");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_JPEG_XR"]/*' />
    [NativeTypeName("#define CFSTR_MIME_JPEG_XR (TEXT(\"image/vnd.ms-photo\"))")]
    public const string CFSTR_MIME_JPEG_XR = ("image/vnd.ms-photo");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_PNG"]/*' />
    [NativeTypeName("#define CFSTR_MIME_PNG (TEXT(\"image/png\"))")]
    public const string CFSTR_MIME_PNG = ("image/png");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_DDS"]/*' />
    [NativeTypeName("#define CFSTR_MIME_DDS (TEXT(\"image/vnd.ms-dds\"))")]
    public const string CFSTR_MIME_DDS = ("image/vnd.ms-dds");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_PNG"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_PNG (TEXT(\"image/x-png\"))")]
    public const string CFSTR_MIME_X_PNG = ("image/x-png");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_ICON"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_ICON (TEXT(\"image/x-icon\"))")]
    public const string CFSTR_MIME_X_ICON = ("image/x-icon");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_SVG_XML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_SVG_XML (TEXT(\"image/svg+xml\"))")]
    public const string CFSTR_MIME_SVG_XML = ("image/svg+xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_BMP"]/*' />
    [NativeTypeName("#define CFSTR_MIME_BMP (TEXT(\"image/bmp\"))")]
    public const string CFSTR_MIME_BMP = ("image/bmp");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_EMF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_EMF (TEXT(\"image/x-emf\"))")]
    public const string CFSTR_MIME_X_EMF = ("image/x-emf");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_WMF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_WMF (TEXT(\"image/x-wmf\"))")]
    public const string CFSTR_MIME_X_WMF = ("image/x-wmf");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_AVI"]/*' />
    [NativeTypeName("#define CFSTR_MIME_AVI (TEXT(\"video/avi\"))")]
    public const string CFSTR_MIME_AVI = ("video/avi");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_MPEG"]/*' />
    [NativeTypeName("#define CFSTR_MIME_MPEG (TEXT(\"video/mpeg\"))")]
    public const string CFSTR_MIME_MPEG = ("video/mpeg");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_FRACTALS"]/*' />
    [NativeTypeName("#define CFSTR_MIME_FRACTALS (TEXT(\"application/fractals\"))")]
    public const string CFSTR_MIME_FRACTALS = ("application/fractals");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_RAWDATA"]/*' />
    [NativeTypeName("#define CFSTR_MIME_RAWDATA (TEXT(\"application/octet-stream\"))")]
    public const string CFSTR_MIME_RAWDATA = ("application/octet-stream");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_RAWDATASTRM"]/*' />
    [NativeTypeName("#define CFSTR_MIME_RAWDATASTRM (TEXT(\"application/octet-stream\"))")]
    public const string CFSTR_MIME_RAWDATASTRM = ("application/octet-stream");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_PDF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_PDF (TEXT(\"application/pdf\"))")]
    public const string CFSTR_MIME_PDF = ("application/pdf");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_HTA"]/*' />
    [NativeTypeName("#define CFSTR_MIME_HTA (TEXT(\"application/hta\"))")]
    public const string CFSTR_MIME_HTA = ("application/hta");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_APP_XML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_APP_XML (TEXT(\"application/xml\"))")]
    public const string CFSTR_MIME_APP_XML = ("application/xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_XHTML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_XHTML (TEXT(\"application/xhtml+xml\"))")]
    public const string CFSTR_MIME_XHTML = ("application/xhtml+xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_AIFF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_AIFF (TEXT(\"audio/x-aiff\"))")]
    public const string CFSTR_MIME_X_AIFF = ("audio/x-aiff");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_REALAUDIO"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_REALAUDIO (TEXT(\"audio/x-pn-realaudio\"))")]
    public const string CFSTR_MIME_X_REALAUDIO = ("audio/x-pn-realaudio");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_XBM"]/*' />
    [NativeTypeName("#define CFSTR_MIME_XBM (TEXT(\"image/xbm\"))")]
    public const string CFSTR_MIME_XBM = ("image/xbm");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_QUICKTIME"]/*' />
    [NativeTypeName("#define CFSTR_MIME_QUICKTIME (TEXT(\"video/quicktime\"))")]
    public const string CFSTR_MIME_QUICKTIME = ("video/quicktime");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_MSVIDEO"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_MSVIDEO (TEXT(\"video/x-msvideo\"))")]
    public const string CFSTR_MIME_X_MSVIDEO = ("video/x-msvideo");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_SGI_MOVIE"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_SGI_MOVIE (TEXT(\"video/x-sgi-movie\"))")]
    public const string CFSTR_MIME_X_SGI_MOVIE = ("video/x-sgi-movie");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_MIXED_REPLACE"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_MIXED_REPLACE (TEXT(\"multipart/x-mixed-replace\"))")]
    public const string CFSTR_MIME_X_MIXED_REPLACE = ("multipart/x-mixed-replace");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_HTML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_HTML (TEXT(\"text/html\"))")]
    public const string CFSTR_MIME_HTML = ("text/html");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_XML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_XML (TEXT(\"text/xml\"))")]
    public const string CFSTR_MIME_XML = ("text/xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_TTML"]/*' />
    [NativeTypeName("#define CFSTR_MIME_TTML (TEXT(\"application/ttml+xml\"))")]
    public const string CFSTR_MIME_TTML = ("application/ttml+xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_TTAF"]/*' />
    [NativeTypeName("#define CFSTR_MIME_TTAF (TEXT(\"application/ttaf+xml\"))")]
    public const string CFSTR_MIME_TTAF = ("application/ttaf+xml");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_X_JAVASCRIPT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_X_JAVASCRIPT (TEXT(\"application/x-javascript\"))")]
    public const string CFSTR_MIME_X_JAVASCRIPT = ("application/x-javascript");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_TEXT_JSON"]/*' />
    [NativeTypeName("#define CFSTR_MIME_TEXT_JSON (TEXT(\"text/json\"))")]
    public const string CFSTR_MIME_TEXT_JSON = ("text/json");

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MIME_APPLICATION_JAVASCRIPT"]/*' />
    [NativeTypeName("#define CFSTR_MIME_APPLICATION_JAVASCRIPT (TEXT(\"application/javascript\"))")]
    public const string CFSTR_MIME_APPLICATION_JAVASCRIPT = ("application/javascript");
}
