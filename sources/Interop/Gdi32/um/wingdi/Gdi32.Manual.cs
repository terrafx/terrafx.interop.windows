// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static unsafe partial class Gdi32
    {
        public const int R2_BLACK = 1;

        public const int R2_NOTMERGEPEN = 2;

        public const int R2_MASKNOTPEN = 3;

        public const int R2_NOTCOPYPEN = 4;

        public const int R2_MASKPENNOT = 5;

        public const int R2_NOT = 6;

        public const int R2_XORPEN = 7;

        public const int R2_NOTMASKPEN = 8;

        public const int R2_MASKPEN = 9;

        public const int R2_NOTXORPEN = 10;

        public const int R2_NOP = 11;

        public const int R2_MERGENOTPEN = 12;

        public const int R2_COPYPEN = 13;

        public const int R2_MERGEPENNOT = 14;

        public const int R2_MERGEPEN = 15;

        public const int R2_WHITE = 16;

        public const int R2_LAST = 16;

        public const uint SRCCOPY = 0x00CC0020;

        public const uint SRCPAINT = 0x00EE0086;

        public const uint SRCAND = 0x008800C6;

        public const uint SRCINVERT = 0x00660046;

        public const uint SRCERASE = 0x00440328;

        public const uint NOTSRCCOPY = 0x00330008;

        public const uint NOTSRCERASE = 0x001100A6;

        public const uint MERGECOPY = 0x00C000CA;

        public const uint MERGEPAINT = 0x00BB0226;

        public const uint PATCOPY = 0x00F00021;

        public const uint PATPAINT = 0x00FB0A09;

        public const uint PATINVERT = 0x005A0049;

        public const uint DSTINVERT = 0x00550009;

        public const uint BLACKNESS = 0x00000042;

        public const uint WHITENESS = 0x00FF0062;

        public const uint NOMIRRORBITMAP = 0x80000000;

        public const uint CAPTUREBLT = 0x40000000;

        public const int GDI_ERROR = unchecked((int)0xFFFFFFFF);

        public const int HGDI_ERROR = -1;

        public const int ERROR = 0;

        public const int NULLREGION = 1;

        public const int SIMPLEREGION = 2;

        public const int COMPLEXREGION = 3;

        public const int RGN_ERROR = ERROR;

        public const int RGN_AND = 1;

        public const int RGN_OR = 2;

        public const int RGN_XOR = 3;

        public const int RGN_DIFF = 4;

        public const int RGN_COPY = 5;

        public const int RGN_MIN = RGN_AND;

        public const int RGN_MAX = RGN_COPY;

        public const int BLACKONWHITE = 1;

        public const int WHITEONBLACK = 2;

        public const int COLORONCOLOR = 3;

        public const int HALFTONE = 4;

        public const int MAXSTRETCHBLTMODE = 4;

        public const int STRETCH_ANDSCANS = BLACKONWHITE;

        public const int STRETCH_ORSCANS = WHITEONBLACK;

        public const int STRETCH_DELETESCANS = COLORONCOLOR;

        public const int STRETCH_HALFTONE = HALFTONE;

        public const int ALTERNATE = 1;

        public const int WINDING = 2;

        public const int POLYFILL_LAST = 2;

        public const int LAYOUT_RTL = 0x00000001;

        public const int LAYOUT_BTT = 0x00000002;

        public const int LAYOUT_VBH = 0x00000004;

        public const int LAYOUT_ORIENTATIONMASK = LAYOUT_RTL | LAYOUT_BTT | LAYOUT_VBH;

        public const int LAYOUT_BITMAPORIENTATIONPRESERVED = 0x00000008;

        public const int TA_NOUPDATECP = 0;

        public const int TA_UPDATECP = 1;

        public const int TA_LEFT = 0;

        public const int TA_RIGHT = 2;

        public const int TA_CENTER = 6;

        public const int TA_TOP = 0;

        public const int TA_BOTTOM = 8;

        public const int TA_BASELINE = 24;

        public const int TA_RTLREADING = 256;

        public const int TA_MASK = TA_BASELINE + TA_CENTER + TA_UPDATECP + TA_RTLREADING;

        public const int VTA_BASELINE = TA_BASELINE;

        public const int VTA_LEFT = TA_BOTTOM;

        public const int VTA_RIGHT = TA_TOP;

        public const int VTA_CENTER = TA_CENTER;

        public const int VTA_BOTTOM = TA_RIGHT;

        public const int VTA_TOP = TA_LEFT;

        public const int ETO_OPAQUE = 0x0002;

        public const int ETO_CLIPPED = 0x0004;

        public const int ETO_GLYPH_INDEX = 0x0010;

        public const int ETO_RTLREADING = 0x0080;

        public const int ETO_NUMERICSLOCAL = 0x0400;

        public const int ETO_NUMERICSLATIN = 0x0800;

        public const int ETO_IGNORELANGUAGE = 0x1000;

        public const int ETO_PDY = 0x2000;

        public const int ETO_REVERSE_INDEX_MAP = 0x10000;

        public const int ASPECT_FILTERING = 0x0001;

        public const int DCB_RESET = 0x0001;

        public const int DCB_ACCUMULATE = 0x0002;

        public const int DCB_DIRTY = DCB_ACCUMULATE;

        public const int DCB_SET = DCB_RESET | DCB_ACCUMULATE;

        public const int DCB_ENABLE = 0x0004;

        public const int DCB_DISABLE = 0x0008;

        public const int META_SETBKCOLOR = 0x0201;

        public const int META_SETBKMODE = 0x0102;

        public const int META_SETMAPMODE = 0x0103;

        public const int META_SETROP2 = 0x0104;

        public const int META_SETRELABS = 0x0105;

        public const int META_SETPOLYFILLMODE = 0x0106;

        public const int META_SETSTRETCHBLTMODE = 0x0107;

        public const int META_SETTEXTCHAREXTRA = 0x0108;

        public const int META_SETTEXTCOLOR = 0x0209;

        public const int META_SETTEXTJUSTIFICATION = 0x020A;

        public const int META_SETWINDOWORG = 0x020B;

        public const int META_SETWINDOWEXT = 0x020C;

        public const int META_SETVIEWPORTORG = 0x020D;

        public const int META_SETVIEWPORTEXT = 0x020E;

        public const int META_OFFSETWINDOWORG = 0x020F;

        public const int META_SCALEWINDOWEXT = 0x0410;

        public const int META_OFFSETVIEWPORTORG = 0x0211;

        public const int META_SCALEVIEWPORTEXT = 0x0412;

        public const int META_LINETO = 0x0213;

        public const int META_MOVETO = 0x0214;

        public const int META_EXCLUDECLIPRECT = 0x0415;

        public const int META_INTERSECTCLIPRECT = 0x0416;

        public const int META_ARC = 0x0817;

        public const int META_ELLIPSE = 0x0418;

        public const int META_FLOODFILL = 0x0419;

        public const int META_PIE = 0x081A;

        public const int META_RECTANGLE = 0x041B;

        public const int META_ROUNDRECT = 0x061C;

        public const int META_PATBLT = 0x061D;

        public const int META_SAVEDC = 0x001E;

        public const int META_SETPIXEL = 0x041F;

        public const int META_OFFSETCLIPRGN = 0x0220;

        public const int META_TEXTOUT = 0x0521;

        public const int META_BITBLT = 0x0922;

        public const int META_STRETCHBLT = 0x0B23;

        public const int META_POLYGON = 0x0324;

        public const int META_POLYLINE = 0x0325;

        public const int META_ESCAPE = 0x0626;

        public const int META_RESTOREDC = 0x0127;

        public const int META_FILLREGION = 0x0228;

        public const int META_FRAMEREGION = 0x0429;

        public const int META_INVERTREGION = 0x012A;

        public const int META_PAINTREGION = 0x012B;

        public const int META_SELECTCLIPREGION = 0x012C;

        public const int META_SELECTOBJECT = 0x012D;

        public const int META_SETTEXTALIGN = 0x012E;

        public const int META_CHORD = 0x0830;

        public const int META_SETMAPPERFLAGS = 0x0231;

        public const int META_EXTTEXTOUT = 0x0A32;

        public const int META_SETDIBTODEV = 0x0D33;

        public const int META_SELECTPALETTE = 0x0234;

        public const int META_REALIZEPALETTE = 0x0035;

        public const int META_ANIMATEPALETTE = 0x0436;

        public const int META_SETPALENTRIES = 0x0037;

        public const int META_POLYPOLYGON = 0x0538;

        public const int META_RESIZEPALETTE = 0x0139;

        public const int META_DIBBITBLT = 0x0940;

        public const int META_DIBSTRETCHBLT = 0x0B41;

        public const int META_DIBCREATEPATTERNBRUSH = 0x0142;

        public const int META_STRETCHDIB = 0x0F43;

        public const int META_EXTFLOODFILL = 0x0548;

        public const int META_SETLAYOUT = 0x0149;

        public const int META_DELETEOBJECT = 0x01F0;

        public const int META_CREATEPALETTE = 0x00F7;

        public const int META_CREATEPATTERNBRUSH = 0x01F9;

        public const int META_CREATEPENINDIRECT = 0x02FA;

        public const int META_CREATEFONTINDIRECT = 0x02FB;

        public const int META_CREATEBRUSHINDIRECT = 0x02FC;

        public const int META_CREATEREGION = 0x06FF;

        public const int NEWFRAME = 1;

        public const int ABORTDOC = 2;

        public const int NEXTBAND = 3;

        public const int SETCOLORTABLE = 4;

        public const int GETCOLORTABLE = 5;

        public const int FLUSHOUTPUT = 6;

        public const int DRAFTMODE = 7;

        public const int QUERYESCSUPPORT = 8;

        public const int SETABORTPROC = 9;

        public const int STARTDOC = 10;

        public const int ENDDOC = 11;

        public const int GETPHYSPAGESIZE = 12;

        public const int GETPRINTINGOFFSET = 13;

        public const int GETSCALINGFACTOR = 14;

        public const int MFCOMMENT = 15;

        public const int GETPENWIDTH = 16;

        public const int SETCOPYCOUNT = 17;

        public const int SELECTPAPERSOURCE = 18;

        public const int DEVICEDATA = 19;

        public const int PASSTHROUGH = 19;

        public const int GETTECHNOLGY = 20;

        public const int GETTECHNOLOGY = 20;

        public const int SETLINECAP = 21;

        public const int SETLINEJOIN = 22;

        public const int SETMITERLIMIT = 23;

        public const int BANDINFO = 24;

        public const int DRAWPATTERNRECT = 25;

        public const int GETVECTORPENSIZE = 26;

        public const int GETVECTORBRUSHSIZE = 27;

        public const int ENABLEDUPLEX = 28;

        public const int GETSETPAPERBINS = 29;

        public const int GETSETPRINTORIENT = 30;

        public const int ENUMPAPERBINS = 31;

        public const int SETDIBSCALING = 32;

        public const int EPSPRINTING = 33;

        public const int ENUMPAPERMETRICS = 34;

        public const int GETSETPAPERMETRICS = 35;

        public const int POSTSCRIPT_DATA = 37;

        public const int POSTSCRIPT_IGNORE = 38;

        public const int MOUSETRAILS = 39;

        public const int GETDEVICEUNITS = 42;

        public const int GETEXTENDEDTEXTMETRICS = 256;

        public const int GETEXTENTTABLE = 257;

        public const int GETPAIRKERNTABLE = 258;

        public const int GETTRACKKERNTABLE = 259;

        public const int EXTTEXTOUT = 512;

        public const int GETFACENAME = 513;

        public const int DOWNLOADFACE = 514;

        public const int ENABLERELATIVEWIDTHS = 768;

        public const int ENABLEPAIRKERNING = 769;

        public const int SETKERNTRACK = 770;

        public const int SETALLJUSTVALUES = 771;

        public const int SETCHARSET = 772;

        public const int STRETCHBLT = 2048;

        public const int METAFILE_DRIVER = 2049;

        public const int GETSETSCREENPARAMS = 3072;

        public const int QUERYDIBSUPPORT = 3073;

        public const int BEGIN_PATH = 4096;

        public const int CLIP_TO_PATH = 4097;

        public const int END_PATH = 4098;

        public const int EXT_DEVICE_CAPS = 4099;

        public const int RESTORE_CTM = 4100;

        public const int SAVE_CTM = 4101;

        public const int SET_ARC_DIRECTION = 4102;

        public const int SET_BACKGROUND_COLOR = 4103;

        public const int SET_POLY_MODE = 4104;

        public const int SET_SCREEN_ANGLE = 4105;

        public const int SET_SPREAD = 4106;

        public const int TRANSFORM_CTM = 4107;

        public const int SET_CLIP_BOX = 4108;

        public const int SET_BOUNDS = 4109;

        public const int SET_MIRROR_MODE = 4110;

        public const int OPENCHANNEL = 4110;

        public const int DOWNLOADHEADER = 4111;

        public const int CLOSECHANNEL = 4112;

        public const int POSTSCRIPT_PASSTHROUGH = 4115;

        public const int ENCAPSULATED_POSTSCRIPT = 4116;

        public const int POSTSCRIPT_IDENTIFY = 4117;

        public const int POSTSCRIPT_INJECTION = 4118;

        public const int CHECKJPEGFORMAT = 4119;

        public const int CHECKPNGFORMAT = 4120;

        public const int GET_PS_FEATURESETTING = 4121;

        public const int GDIPLUS_TS_QUERYVER = 4122;

        public const int GDIPLUS_TS_RECORD = 4123;

        public const int MILCORE_TS_QUERYVER_RESULT_FALSE = 0x0;

        public const int MILCORE_TS_QUERYVER_RESULT_TRUE = 0x7FFFFFFF;

        public const int SPCLPASSTHROUGH2 = 4568;

        public const int PSIDENT_GDICENTRIC = 0;

        public const int PSIDENT_PSCENTRIC = 1;

        public const int PSINJECT_BEGINSTREAM = 1;

        public const int PSINJECT_PSADOBE = 2;

        public const int PSINJECT_PAGESATEND = 3;

        public const int PSINJECT_PAGES = 4;

        public const int PSINJECT_DOCNEEDEDRES = 5;

        public const int PSINJECT_DOCSUPPLIEDRES = 6;

        public const int PSINJECT_PAGEORDER = 7;

        public const int PSINJECT_ORIENTATION = 8;

        public const int PSINJECT_BOUNDINGBOX = 9;

        public const int PSINJECT_DOCUMENTPROCESSCOLORS = 10;

        public const int PSINJECT_COMMENTS = 11;

        public const int PSINJECT_BEGINDEFAULTS = 12;

        public const int PSINJECT_ENDDEFAULTS = 13;

        public const int PSINJECT_BEGINPROLOG = 14;

        public const int PSINJECT_ENDPROLOG = 15;

        public const int PSINJECT_BEGINSETUP = 16;

        public const int PSINJECT_ENDSETUP = 17;

        public const int PSINJECT_TRAILER = 18;

        public const int PSINJECT_EOF = 19;

        public const int PSINJECT_ENDSTREAM = 20;

        public const int PSINJECT_DOCUMENTPROCESSCOLORSATEND = 21;

        public const int PSINJECT_PAGENUMBER = 100;

        public const int PSINJECT_BEGINPAGESETUP = 101;

        public const int PSINJECT_ENDPAGESETUP = 102;

        public const int PSINJECT_PAGETRAILER = 103;

        public const int PSINJECT_PLATECOLOR = 104;

        public const int PSINJECT_SHOWPAGE = 105;

        public const int PSINJECT_PAGEBBOX = 106;

        public const int PSINJECT_ENDPAGECOMMENTS = 107;

        public const int PSINJECT_VMSAVE = 200;

        public const int PSINJECT_VMRESTORE = 201;

        public const uint PSINJECT_DLFONT = 0xDDDDDDDD;

        public const int FEATURESETTING_NUP = 0;

        public const int FEATURESETTING_OUTPUT = 1;

        public const int FEATURESETTING_PSLEVEL = 2;

        public const int FEATURESETTING_CUSTPAPER = 3;

        public const int FEATURESETTING_MIRROR = 4;

        public const int FEATURESETTING_NEGATIVE = 5;

        public const int FEATURESETTING_PROTOCOL = 6;

        public const int FEATURESETTING_PRIVATE_BEGIN = 0x1000;

        public const int FEATURESETTING_PRIVATE_END = 0x1FFF;

        public const int PSPROTOCOL_ASCII = 0;

        public const int PSPROTOCOL_BCP = 1;

        public const int PSPROTOCOL_TBCP = 2;

        public const int PSPROTOCOL_BINARY = 3;

        public const int QDI_SETDIBITS = 1;

        public const int QDI_GETDIBITS = 2;

        public const int QDI_DIBTOSCREEN = 4;

        public const int QDI_STRETCHDIB = 8;

        public const int SP_NOTREPORTED = 0x4000;

        public const int SP_ERROR = -1;

        public const int SP_APPABORT = -2;

        public const int SP_USERABORT = -3;

        public const int SP_OUTOFDISK = -4;

        public const int SP_OUTOFMEMORY = -5;

        public const int PR_JOBSTATUS = 0x0000;

        public const int OBJ_PEN = 1;

        public const int OBJ_BRUSH = 2;

        public const int OBJ_DC = 3;

        public const int OBJ_METADC = 4;

        public const int OBJ_PAL = 5;

        public const int OBJ_FONT = 6;

        public const int OBJ_BITMAP = 7;

        public const int OBJ_REGION = 8;

        public const int OBJ_METAFILE = 9;

        public const int OBJ_MEMDC = 10;

        public const int OBJ_EXTPEN = 11;

        public const int OBJ_ENHMETADC = 12;

        public const int OBJ_ENHMETAFILE = 13;

        public const int OBJ_COLORSPACE = 14;

        public const int GDI_OBJ_LAST = OBJ_COLORSPACE;

        public const int MWT_IDENTITY = 1;

        public const int MWT_LEFTMULTIPLY = 2;

        public const int MWT_RIGHTMULTIPLY = 3;

        public const int MWT_MIN = MWT_IDENTITY;

        public const int MWT_MAX = MWT_RIGHTMULTIPLY;

        public const int CS_ENABLE = 0x00000001;

        public const int CS_DISABLE = 0x00000002;

        public const int CS_DELETE_TRANSFORM = 0x00000003;

        public const int LCS_SIGNATURE = 0x50534F43;

        public const int LCS_sRGB = 0x73524742;

        public const int LCS_WINDOWS_COLOR_SPACE = 0x57696E20;

        public const int LCS_CALIBRATED_RGB = 0x00000000;

        public const int LCS_GM_BUSINESS = 0x00000001;

        public const int LCS_GM_GRAPHICS = 0x00000002;

        public const int LCS_GM_IMAGES = 0x00000004;

        public const int LCS_GM_ABS_COLORIMETRIC = 0x00000008;

        public const int CM_OUT_OF_GAMUT = 255;

        public const int CM_IN_GAMUT = 0;

        public const int ICM_ADDPROFILE = 1;

        public const int ICM_DELETEPROFILE = 2;

        public const int ICM_QUERYPROFILE = 3;

        public const int ICM_SETDEFAULTPROFILE = 4;

        public const int ICM_REGISTERICMATCHER = 5;

        public const int ICM_UNREGISTERICMATCHER = 6;

        public const int ICM_QUERYMATCH = 7;

        public const int PROFILE_LINKED = 0x4C494E4B;

        public const int PROFILE_EMBEDDED = 0x4D424544;

        public const int BI_RGB = 0;

        public const int BI_RLE8 = 1;

        public const int BI_RLE4 = 2;

        public const int BI_BITFIELDS = 3;

        public const int BI_JPEG = 4;

        public const int BI_PNG = 5;

        public const int TCI_SRCCHARSET = 1;

        public const int TCI_SRCCODEPAGE = 2;

        public const int TCI_SRCFONTSIG = 3;

        public const int TCI_SRCLOCALE = 0x1000;

        public const int TMPF_FIXED_PITCH = 0x01;

        public const int TMPF_VECTOR = 0x02;

        public const int TMPF_DEVICE = 0x08;

        public const int TMPF_TRUETYPE = 0x04;

        public const int NTM_REGULAR = 0x00000040;

        public const int NTM_BOLD = 0x00000020;

        public const int NTM_ITALIC = 0x00000001;

        public const int NTM_NONNEGATIVE_AC = 0x00010000;

        public const int NTM_PS_OPENTYPE = 0x00020000;

        public const int NTM_TT_OPENTYPE = 0x00040000;

        public const int NTM_MULTIPLEMASTER = 0x00080000;

        public const int NTM_TYPE1 = 0x00100000;

        public const int NTM_DSIG = 0x00200000;

        public const int LF_FACESIZE = 32;

        public const int LF_FULLFACESIZE = 64;

        public const int OUT_DEFAULT_PRECIS = 0;

        public const int OUT_STRING_PRECIS = 1;

        public const int OUT_CHARACTER_PRECIS = 2;

        public const int OUT_STROKE_PRECIS = 3;

        public const int OUT_TT_PRECIS = 4;

        public const int OUT_DEVICE_PRECIS = 5;

        public const int OUT_RASTER_PRECIS = 6;

        public const int OUT_TT_ONLY_PRECIS = 7;

        public const int OUT_OUTLINE_PRECIS = 8;

        public const int OUT_SCREEN_OUTLINE_PRECIS = 9;

        public const int OUT_PS_ONLY_PRECIS = 10;

        public const int CLIP_DEFAULT_PRECIS = 0;

        public const int CLIP_CHARACTER_PRECIS = 1;

        public const int CLIP_STROKE_PRECIS = 2;

        public const int CLIP_MASK = 0xF;

        public const int CLIP_LH_ANGLES = 1 << 4;

        public const int CLIP_TT_ALWAYS = 2 << 4;

        public const int CLIP_DFA_DISABLE = 4 << 4;

        public const int CLIP_EMBEDDED = 8 << 4;

        public const int DEFAULT_QUALITY = 0;

        public const int DRAFT_QUALITY = 1;

        public const int PROOF_QUALITY = 2;

        public const int NONANTIALIASED_QUALITY = 3;

        public const int ANTIALIASED_QUALITY = 4;

        public const int CLEARTYPE_QUALITY = 5;

        public const int CLEARTYPE_NATURAL_QUALITY = 6;

        public const int DEFAULT_PITCH = 0;

        public const int FIXED_PITCH = 1;

        public const int VARIABLE_PITCH = 2;

        public const int MONO_FONT = 8;

        public const int ANSI_CHARSET = 0;

        public const int DEFAULT_CHARSET = 1;

        public const int SYMBOL_CHARSET = 2;

        public const int SHIFTJIS_CHARSET = 128;

        public const int HANGEUL_CHARSET = 129;

        public const int HANGUL_CHARSET = 129;

        public const int GB2312_CHARSET = 134;

        public const int CHINESEBIG5_CHARSET = 136;

        public const int OEM_CHARSET = 255;

        public const int JOHAB_CHARSET = 130;

        public const int HEBREW_CHARSET = 177;

        public const int ARABIC_CHARSET = 178;

        public const int GREEK_CHARSET = 161;

        public const int TURKISH_CHARSET = 162;

        public const int VIETNAMESE_CHARSET = 163;

        public const int THAI_CHARSET = 222;

        public const int EASTEUROPE_CHARSET = 238;

        public const int RUSSIAN_CHARSET = 204;

        public const int MAC_CHARSET = 77;

        public const int BALTIC_CHARSET = 186;

        public const uint FS_LATIN1 = 0x00000001;

        public const uint FS_LATIN2 = 0x00000002;

        public const uint FS_CYRILLIC = 0x00000004;

        public const uint FS_GREEK = 0x00000008;

        public const uint FS_TURKISH = 0x00000010;

        public const uint FS_HEBREW = 0x00000020;

        public const uint FS_ARABIC = 0x00000040;

        public const uint FS_BALTIC = 0x00000080;

        public const uint FS_VIETNAMESE = 0x00000100;

        public const uint FS_THAI = 0x00010000;

        public const uint FS_JISJAPAN = 0x00020000;

        public const uint FS_CHINESESIMP = 0x00040000;

        public const uint FS_WANSUNG = 0x00080000;

        public const uint FS_CHINESETRAD = 0x00100000;

        public const uint FS_JOHAB = 0x00200000;

        public const uint FS_SYMBOL = 0x80000000;

        public const int FF_DONTCARE = 0 << 4;

        public const int FF_ROMAN = 1 << 4;

        public const int FF_SWISS = 2 << 4;

        public const int FF_MODERN = 3 << 4;

        public const int FF_SCRIPT = 4 << 4;

        public const int FF_DECORATIVE = 5 << 4;

        public const int FW_DONTCARE = 0;

        public const int FW_THIN = 100;

        public const int FW_EXTRALIGHT = 200;

        public const int FW_LIGHT = 300;

        public const int FW_NORMAL = 400;

        public const int FW_MEDIUM = 500;

        public const int FW_SEMIBOLD = 600;

        public const int FW_BOLD = 700;

        public const int FW_EXTRABOLD = 800;

        public const int FW_HEAVY = 900;

        public const int FW_ULTRALIGHT = FW_EXTRALIGHT;

        public const int FW_REGULAR = FW_NORMAL;

        public const int FW_DEMIBOLD = FW_SEMIBOLD;

        public const int FW_ULTRABOLD = FW_EXTRABOLD;

        public const int FW_BLACK = FW_HEAVY;

        public const int PANOSE_COUNT = 10;

        public const int PAN_FAMILYTYPE_INDEX = 0;

        public const int PAN_SERIFSTYLE_INDEX = 1;

        public const int PAN_WEIGHT_INDEX = 2;

        public const int PAN_PROPORTION_INDEX = 3;

        public const int PAN_CONTRAST_INDEX = 4;

        public const int PAN_STROKEVARIATION_INDEX = 5;

        public const int PAN_ARMSTYLE_INDEX = 6;

        public const int PAN_LETTERFORM_INDEX = 7;

        public const int PAN_MIDLINE_INDEX = 8;

        public const int PAN_XHEIGHT_INDEX = 9;

        public const int PAN_CULTURE_LATIN = 0;

        public const int PAN_ANY = 0;

        public const int PAN_NO_FIT = 1;

        public const int PAN_FAMILY_TEXT_DISPLAY = 2;

        public const int PAN_FAMILY_SCRIPT = 3;

        public const int PAN_FAMILY_DECORATIVE = 4;

        public const int PAN_FAMILY_PICTORIAL = 5;

        public const int PAN_SERIF_COVE = 2;

        public const int PAN_SERIF_OBTUSE_COVE = 3;

        public const int PAN_SERIF_SQUARE_COVE = 4;

        public const int PAN_SERIF_OBTUSE_SQUARE_COVE = 5;

        public const int PAN_SERIF_SQUARE = 6;

        public const int PAN_SERIF_THIN = 7;

        public const int PAN_SERIF_BONE = 8;

        public const int PAN_SERIF_EXAGGERATED = 9;

        public const int PAN_SERIF_TRIANGLE = 10;

        public const int PAN_SERIF_NORMAL_SANS = 11;

        public const int PAN_SERIF_OBTUSE_SANS = 12;

        public const int PAN_SERIF_PERP_SANS = 13;

        public const int PAN_SERIF_FLARED = 14;

        public const int PAN_SERIF_ROUNDED = 15;

        public const int PAN_WEIGHT_VERY_LIGHT = 2;

        public const int PAN_WEIGHT_LIGHT = 3;

        public const int PAN_WEIGHT_THIN = 4;

        public const int PAN_WEIGHT_BOOK = 5;

        public const int PAN_WEIGHT_MEDIUM = 6;

        public const int PAN_WEIGHT_DEMI = 7;

        public const int PAN_WEIGHT_BOLD = 8;

        public const int PAN_WEIGHT_HEAVY = 9;

        public const int PAN_WEIGHT_BLACK = 10;

        public const int PAN_WEIGHT_NORD = 11;

        public const int PAN_PROP_OLD_STYLE = 2;

        public const int PAN_PROP_MODERN = 3;

        public const int PAN_PROP_EVEN_WIDTH = 4;

        public const int PAN_PROP_EXPANDED = 5;

        public const int PAN_PROP_CONDENSED = 6;

        public const int PAN_PROP_VERY_EXPANDED = 7;

        public const int PAN_PROP_VERY_CONDENSED = 8;

        public const int PAN_PROP_MONOSPACED = 9;

        public const int PAN_CONTRAST_NONE = 2;

        public const int PAN_CONTRAST_VERY_LOW = 3;

        public const int PAN_CONTRAST_LOW = 4;

        public const int PAN_CONTRAST_MEDIUM_LOW = 5;

        public const int PAN_CONTRAST_MEDIUM = 6;

        public const int PAN_CONTRAST_MEDIUM_HIGH = 7;

        public const int PAN_CONTRAST_HIGH = 8;

        public const int PAN_CONTRAST_VERY_HIGH = 9;

        public const int PAN_STROKE_GRADUAL_DIAG = 2;

        public const int PAN_STROKE_GRADUAL_TRAN = 3;

        public const int PAN_STROKE_GRADUAL_VERT = 4;

        public const int PAN_STROKE_GRADUAL_HORZ = 5;

        public const int PAN_STROKE_RAPID_VERT = 6;

        public const int PAN_STROKE_RAPID_HORZ = 7;

        public const int PAN_STROKE_INSTANT_VERT = 8;

        public const int PAN_STRAIGHT_ARMS_HORZ = 2;

        public const int PAN_STRAIGHT_ARMS_WEDGE = 3;

        public const int PAN_STRAIGHT_ARMS_VERT = 4;

        public const int PAN_STRAIGHT_ARMS_SINGLE_SERIF = 5;

        public const int PAN_STRAIGHT_ARMS_DOUBLE_SERIF = 6;

        public const int PAN_BENT_ARMS_HORZ = 7;

        public const int PAN_BENT_ARMS_WEDGE = 8;

        public const int PAN_BENT_ARMS_VERT = 9;

        public const int PAN_BENT_ARMS_SINGLE_SERIF = 10;

        public const int PAN_BENT_ARMS_DOUBLE_SERIF = 11;

        public const int PAN_LETT_NORMAL_CONTACT = 2;

        public const int PAN_LETT_NORMAL_WEIGHTED = 3;

        public const int PAN_LETT_NORMAL_BOXED = 4;

        public const int PAN_LETT_NORMAL_FLATTENED = 5;

        public const int PAN_LETT_NORMAL_ROUNDED = 6;

        public const int PAN_LETT_NORMAL_OFF_CENTER = 7;

        public const int PAN_LETT_NORMAL_SQUARE = 8;

        public const int PAN_LETT_OBLIQUE_CONTACT = 9;

        public const int PAN_LETT_OBLIQUE_WEIGHTED = 10;

        public const int PAN_LETT_OBLIQUE_BOXED = 11;

        public const int PAN_LETT_OBLIQUE_FLATTENED = 12;

        public const int PAN_LETT_OBLIQUE_ROUNDED = 13;

        public const int PAN_LETT_OBLIQUE_OFF_CENTER = 14;

        public const int PAN_LETT_OBLIQUE_SQUARE = 15;

        public const int PAN_MIDLINE_STANDARD_TRIMMED = 2;

        public const int PAN_MIDLINE_STANDARD_POINTED = 3;

        public const int PAN_MIDLINE_STANDARD_SERIFED = 4;

        public const int PAN_MIDLINE_HIGH_TRIMMED = 5;

        public const int PAN_MIDLINE_HIGH_POINTED = 6;

        public const int PAN_MIDLINE_HIGH_SERIFED = 7;

        public const int PAN_MIDLINE_CONSTANT_TRIMMED = 8;

        public const int PAN_MIDLINE_CONSTANT_POINTED = 9;

        public const int PAN_MIDLINE_CONSTANT_SERIFED = 10;

        public const int PAN_MIDLINE_LOW_TRIMMED = 11;

        public const int PAN_MIDLINE_LOW_POINTED = 12;

        public const int PAN_MIDLINE_LOW_SERIFED = 13;

        public const int PAN_XHEIGHT_CONSTANT_SMALL = 2;

        public const int PAN_XHEIGHT_CONSTANT_STD = 3;

        public const int PAN_XHEIGHT_CONSTANT_LARGE = 4;

        public const int PAN_XHEIGHT_DUCKING_SMALL = 5;

        public const int PAN_XHEIGHT_DUCKING_STD = 6;

        public const int PAN_XHEIGHT_DUCKING_LARGE = 7;

        public const int ELF_VENDOR_SIZE = 4;

        public const int ELF_VERSION = 0;

        public const int ELF_CULTURE_LATIN = 0;

        public const int RASTER_FONTTYPE = 0x0001;

        public const int DEVICE_FONTTYPE = 0x0002;

        public const int TRUETYPE_FONTTYPE = 0x0004;

        public const int PC_RESERVED = 0x01;

        public const int PC_EXPLICIT = 0x02;

        public const int PC_NOCOLLAPSE = 0x04;

        public const int TRANSPARENT = 1;

        public const int OPAQUE = 2;

        public const int BKMODE_LAST = 2;

        public const int GM_COMPATIBLE = 1;

        public const int GM_ADVANCED = 2;

        public const int GM_LAST = 2;

        public const int PT_CLOSEFIGURE = 0x01;

        public const int PT_LINETO = 0x02;

        public const int PT_BEZIERTO = 0x04;

        public const int PT_MOVETO = 0x06;

        public const int MM_TEXT = 1;

        public const int MM_LOMETRIC = 2;

        public const int MM_HIMETRIC = 3;

        public const int MM_LOENGLISH = 4;

        public const int MM_HIENGLISH = 5;

        public const int MM_TWIPS = 6;

        public const int MM_ISOTROPIC = 7;

        public const int MM_ANISOTROPIC = 8;

        public const int MM_MIN = MM_TEXT;

        public const int MM_MAX = MM_ANISOTROPIC;

        public const int MM_MAX_FIXEDSCALE = MM_TWIPS;

        public const int ABSOLUTE = 1;

        public const int RELATIVE = 2;

        public const int WHITE_BRUSH = 0;

        public const int LTGRAY_BRUSH = 1;

        public const int GRAY_BRUSH = 2;

        public const int DKGRAY_BRUSH = 3;

        public const int BLACK_BRUSH = 4;

        public const int NULL_BRUSH = 5;

        public const int HOLLOW_BRUSH = NULL_BRUSH;

        public const int WHITE_PEN = 6;

        public const int BLACK_PEN = 7;

        public const int NULL_PEN = 8;

        public const int OEM_FIXED_FONT = 10;

        public const int ANSI_FIXED_FONT = 11;

        public const int ANSI_VAR_FONT = 12;

        public const int SYSTEM_FONT = 13;

        public const int DEVICE_DEFAULT_FONT = 14;

        public const int DEFAULT_PALETTE = 15;

        public const int SYSTEM_FIXED_FONT = 16;

        public const int DEFAULT_GUI_FONT = 17;

        public const int DC_BRUSH = 18;

        public const int DC_PEN = 19;

        public const int STOCK_LAST = 19;

        public const uint CLR_INVALID = 0xFFFFFFFF;

        public const int BS_SOLID = 0;

        public const int BS_NULL = 1;

        public const int BS_HOLLOW = BS_NULL;

        public const int BS_HATCHED = 2;

        public const int BS_PATTERN = 3;

        public const int BS_INDEXED = 4;

        public const int BS_DIBPATTERN = 5;

        public const int BS_DIBPATTERNPT = 6;

        public const int BS_PATTERN8X8 = 7;

        public const int BS_DIBPATTERN8X8 = 8;

        public const int BS_MONOPATTERN = 9;

        public const int HS_HORIZONTAL = 0;

        public const int HS_VERTICAL = 1;

        public const int HS_FDIAGONAL = 2;

        public const int HS_BDIAGONAL = 3;

        public const int HS_CROSS = 4;

        public const int HS_DIAGCROSS = 5;

        public const int HS_API_MAX = 12;

        public const int PS_SOLID = 0;

        public const int PS_DASH = 1;

        public const int PS_DOT = 2;

        public const int PS_DASHDOT = 3;

        public const int PS_DASHDOTDOT = 4;

        public const int PS_NULL = 5;

        public const int PS_INSIDEFRAME = 6;

        public const int PS_USERSTYLE = 7;

        public const int PS_ALTERNATE = 8;

        public const int PS_STYLE_MASK = 0x0000000F;

        public const int PS_ENDCAP_ROUND = 0x00000000;

        public const int PS_ENDCAP_SQUARE = 0x00000100;

        public const int PS_ENDCAP_FLAT = 0x00000200;

        public const int PS_ENDCAP_MASK = 0x00000F00;

        public const int PS_JOIN_ROUND = 0x00000000;

        public const int PS_JOIN_BEVEL = 0x00001000;

        public const int PS_JOIN_MITER = 0x00002000;

        public const int PS_JOIN_MASK = 0x0000F000;

        public const int PS_COSMETIC = 0x00000000;

        public const int PS_GEOMETRIC = 0x00010000;

        public const int PS_TYPE_MASK = 0x000F0000;

        public const int AD_COUNTERCLOCKWISE = 1;

        public const int AD_CLOCKWISE = 2;

        public const int DRIVERVERSION = 0;

        public const int TECHNOLOGY = 2;

        public const int HORZSIZE = 4;

        public const int VERTSIZE = 6;

        public const int HORZRES = 8;

        public const int VERTRES = 10;

        public const int BITSPIXEL = 12;

        public const int PLANES = 14;

        public const int NUMBRUSHES = 16;

        public const int NUMPENS = 18;

        public const int NUMMARKERS = 20;

        public const int NUMFONTS = 22;

        public const int NUMCOLORS = 24;

        public const int PDEVICESIZE = 26;

        public const int CURVECAPS = 28;

        public const int LINECAPS = 30;

        public const int POLYGONALCAPS = 32;

        public const int TEXTCAPS = 34;

        public const int CLIPCAPS = 36;

        public const int RASTERCAPS = 38;

        public const int ASPECTX = 40;

        public const int ASPECTY = 42;

        public const int ASPECTXY = 44;

        public const int LOGPIXELSX = 88;

        public const int LOGPIXELSY = 90;

        public const int SIZEPALETTE = 104;

        public const int NUMRESERVED = 106;

        public const int COLORRES = 108;

        public const int PHYSICALWIDTH = 110;

        public const int PHYSICALHEIGHT = 111;

        public const int PHYSICALOFFSETX = 112;

        public const int PHYSICALOFFSETY = 113;

        public const int SCALINGFACTORX = 114;

        public const int SCALINGFACTORY = 115;

        public const int VREFRESH = 116;

        public const int DESKTOPVERTRES = 117;

        public const int DESKTOPHORZRES = 118;

        public const int BLTALIGNMENT = 119;

        public const int SHADEBLENDCAPS = 120;

        public const int COLORMGMTCAPS = 121;

        public const int DT_PLOTTER = 0;

        public const int DT_RASDISPLAY = 1;

        public const int DT_RASPRINTER = 2;

        public const int DT_RASCAMERA = 3;

        public const int DT_CHARSTREAM = 4;

        public const int DT_METAFILE = 5;

        public const int DT_DISPFILE = 6;

        public const int CC_NONE = 0;

        public const int CC_CIRCLES = 1;

        public const int CC_PIE = 2;

        public const int CC_CHORD = 4;

        public const int CC_ELLIPSES = 8;

        public const int CC_WIDE = 16;

        public const int CC_STYLED = 32;

        public const int CC_WIDESTYLED = 64;

        public const int CC_INTERIORS = 128;

        public const int CC_ROUNDRECT = 256;

        public const int LC_NONE = 0;

        public const int LC_POLYLINE = 2;

        public const int LC_MARKER = 4;

        public const int LC_POLYMARKER = 8;

        public const int LC_WIDE = 16;

        public const int LC_STYLED = 32;

        public const int LC_WIDESTYLED = 64;

        public const int LC_INTERIORS = 128;

        public const int PC_NONE = 0;

        public const int PC_POLYGON = 1;

        public const int PC_RECTANGLE = 2;

        public const int PC_WINDPOLYGON = 4;

        public const int PC_TRAPEZOID = 4;

        public const int PC_SCANLINE = 8;

        public const int PC_WIDE = 16;

        public const int PC_STYLED = 32;

        public const int PC_WIDESTYLED = 64;

        public const int PC_INTERIORS = 128;

        public const int PC_POLYPOLYGON = 256;

        public const int PC_PATHS = 512;

        public const int CP_NONE = 0;

        public const int CP_RECTANGLE = 1;

        public const int CP_REGION = 2;

        public const int TC_OP_CHARACTER = 0x00000001;

        public const int TC_OP_STROKE = 0x00000002;

        public const int TC_CP_STROKE = 0x00000004;

        public const int TC_CR_90 = 0x00000008;

        public const int TC_CR_ANY = 0x00000010;

        public const int TC_SF_X_YINDEP = 0x00000020;

        public const int TC_SA_DOUBLE = 0x00000040;

        public const int TC_SA_INTEGER = 0x00000080;

        public const int TC_SA_CONTIN = 0x00000100;

        public const int TC_EA_DOUBLE = 0x00000200;

        public const int TC_IA_ABLE = 0x00000400;

        public const int TC_UA_ABLE = 0x00000800;

        public const int TC_SO_ABLE = 0x00001000;

        public const int TC_RA_ABLE = 0x00002000;

        public const int TC_VA_ABLE = 0x00004000;

        public const int TC_RESERVED = 0x00008000;

        public const int TC_SCROLLBLT = 0x00010000;

        public const int RC_BITBLT = 1;

        public const int RC_BANDING = 2;

        public const int RC_SCALING = 4;

        public const int RC_BITMAP64 = 8;

        public const int RC_GDI20_OUTPUT = 0x0010;

        public const int RC_GDI20_STATE = 0x0020;

        public const int RC_SAVEBITMAP = 0x0040;

        public const int RC_DI_BITMAP = 0x0080;

        public const int RC_PALETTE = 0x0100;

        public const int RC_DIBTODEV = 0x0200;

        public const int RC_BIGFONT = 0x0400;

        public const int RC_STRETCHBLT = 0x0800;

        public const int RC_FLOODFILL = 0x1000;

        public const int RC_STRETCHDIB = 0x2000;

        public const int RC_OP_DX_OUTPUT = 0x4000;

        public const int RC_DEVBITS = 0x8000;

        public const int SB_NONE = 0x00000000;

        public const int SB_CONST_ALPHA = 0x00000001;

        public const int SB_PIXEL_ALPHA = 0x00000002;

        public const int SB_PREMULT_ALPHA = 0x00000004;

        public const int SB_GRAD_RECT = 0x00000010;

        public const int SB_GRAD_TRI = 0x00000020;

        public const int CM_NONE = 0x00000000;

        public const int CM_DEVICE_ICM = 0x00000001;

        public const int CM_GAMMA_RAMP = 0x00000002;

        public const int CM_CMYK_COLOR = 0x00000004;

        public const int DIB_RGB_COLORS = 0;

        public const int DIB_PAL_COLORS = 1;

        public const int SYSPAL_ERROR = 0;

        public const int SYSPAL_STATIC = 1;

        public const int SYSPAL_NOSTATIC = 2;

        public const int SYSPAL_NOSTATIC256 = 3;

        public const int CBM_INIT = 0x04;

        public const int FLOODFILLBORDER = 0;

        public const int FLOODFILLSURFACE = 1;

        public const int CCHDEVICENAME = 32;

        public const int CCHFORMNAME = 32;

        public const int DM_SPECVERSION = 0x0401;

        public const int DM_ORIENTATION = 0x00000001;

        public const int DM_PAPERSIZE = 0x00000002;

        public const int DM_PAPERLENGTH = 0x00000004;

        public const int DM_PAPERWIDTH = 0x00000008;

        public const int DM_SCALE = 0x00000010;

        public const int DM_POSITION = 0x00000020;

        public const int DM_NUP = 0x00000040;

        public const int DM_DISPLAYORIENTATION = 0x00000080;

        public const int DM_COPIES = 0x00000100;

        public const int DM_DEFAULTSOURCE = 0x00000200;

        public const int DM_PRINTQUALITY = 0x00000400;

        public const int DM_COLOR = 0x00000800;

        public const int DM_DUPLEX = 0x00001000;

        public const int DM_YRESOLUTION = 0x00002000;

        public const int DM_TTOPTION = 0x00004000;

        public const int DM_COLLATE = 0x00008000;

        public const int DM_FORMNAME = 0x00010000;

        public const int DM_LOGPIXELS = 0x00020000;

        public const int DM_BITSPERPEL = 0x00040000;

        public const int DM_PELSWIDTH = 0x00080000;

        public const int DM_PELSHEIGHT = 0x00100000;

        public const int DM_DISPLAYFLAGS = 0x00200000;

        public const int DM_DISPLAYFREQUENCY = 0x00400000;

        public const int DM_ICMMETHOD = 0x00800000;

        public const int DM_ICMINTENT = 0x01000000;

        public const int DM_MEDIATYPE = 0x02000000;

        public const int DM_DITHERTYPE = 0x04000000;

        public const int DM_PANNINGWIDTH = 0x08000000;

        public const int DM_PANNINGHEIGHT = 0x10000000;

        public const int DM_DISPLAYFIXEDOUTPUT = 0x20000000;

        public const int DMORIENT_PORTRAIT = 1;

        public const int DMORIENT_LANDSCAPE = 2;

        public const int DMPAPER_FIRST = DMPAPER_LETTER;

        public const int DMPAPER_LETTER = 1;

        public const int DMPAPER_LETTERSMALL = 2;

        public const int DMPAPER_TABLOID = 3;

        public const int DMPAPER_LEDGER = 4;

        public const int DMPAPER_LEGAL = 5;

        public const int DMPAPER_STATEMENT = 6;

        public const int DMPAPER_EXECUTIVE = 7;

        public const int DMPAPER_A3 = 8;

        public const int DMPAPER_A4 = 9;

        public const int DMPAPER_A4SMALL = 10;

        public const int DMPAPER_A5 = 11;

        public const int DMPAPER_B4 = 12;

        public const int DMPAPER_B5 = 13;

        public const int DMPAPER_FOLIO = 14;

        public const int DMPAPER_QUARTO = 15;

        public const int DMPAPER_10X14 = 16;

        public const int DMPAPER_11X17 = 17;

        public const int DMPAPER_NOTE = 18;

        public const int DMPAPER_ENV_9 = 19;

        public const int DMPAPER_ENV_10 = 20;

        public const int DMPAPER_ENV_11 = 21;

        public const int DMPAPER_ENV_12 = 22;

        public const int DMPAPER_ENV_14 = 23;

        public const int DMPAPER_CSHEET = 24;

        public const int DMPAPER_DSHEET = 25;

        public const int DMPAPER_ESHEET = 26;

        public const int DMPAPER_ENV_DL = 27;

        public const int DMPAPER_ENV_C5 = 28;

        public const int DMPAPER_ENV_C3 = 29;

        public const int DMPAPER_ENV_C4 = 30;

        public const int DMPAPER_ENV_C6 = 31;

        public const int DMPAPER_ENV_C65 = 32;

        public const int DMPAPER_ENV_B4 = 33;

        public const int DMPAPER_ENV_B5 = 34;

        public const int DMPAPER_ENV_B6 = 35;

        public const int DMPAPER_ENV_ITALY = 36;

        public const int DMPAPER_ENV_MONARCH = 37;

        public const int DMPAPER_ENV_PERSONAL = 38;

        public const int DMPAPER_FANFOLD_US = 39;

        public const int DMPAPER_FANFOLD_STD_GERMAN = 40;

        public const int DMPAPER_FANFOLD_LGL_GERMAN = 41;

        public const int DMPAPER_ISO_B4 = 42;

        public const int DMPAPER_JAPANESE_POSTCARD = 43;

        public const int DMPAPER_9X11 = 44;

        public const int DMPAPER_10X11 = 45;

        public const int DMPAPER_15X11 = 46;

        public const int DMPAPER_ENV_INVITE = 47;

        public const int DMPAPER_RESERVED_48 = 48;

        public const int DMPAPER_RESERVED_49 = 49;

        public const int DMPAPER_LETTER_EXTRA = 50;

        public const int DMPAPER_LEGAL_EXTRA = 51;

        public const int DMPAPER_TABLOID_EXTRA = 52;

        public const int DMPAPER_A4_EXTRA = 53;

        public const int DMPAPER_LETTER_TRANSVERSE = 54;

        public const int DMPAPER_A4_TRANSVERSE = 55;

        public const int DMPAPER_LETTER_EXTRA_TRANSVERSE = 56;

        public const int DMPAPER_A_PLUS = 57;

        public const int DMPAPER_B_PLUS = 58;

        public const int DMPAPER_LETTER_PLUS = 59;

        public const int DMPAPER_A4_PLUS = 60;

        public const int DMPAPER_A5_TRANSVERSE = 61;

        public const int DMPAPER_B5_TRANSVERSE = 62;

        public const int DMPAPER_A3_EXTRA = 63;

        public const int DMPAPER_A5_EXTRA = 64;

        public const int DMPAPER_B5_EXTRA = 65;

        public const int DMPAPER_A2 = 66;

        public const int DMPAPER_A3_TRANSVERSE = 67;

        public const int DMPAPER_A3_EXTRA_TRANSVERSE = 68;

        public const int DMPAPER_DBL_JAPANESE_POSTCARD = 69;

        public const int DMPAPER_A6 = 70;

        public const int DMPAPER_JENV_KAKU2 = 71;

        public const int DMPAPER_JENV_KAKU3 = 72;

        public const int DMPAPER_JENV_CHOU3 = 73;

        public const int DMPAPER_JENV_CHOU4 = 74;

        public const int DMPAPER_LETTER_ROTATED = 75;

        public const int DMPAPER_A3_ROTATED = 76;

        public const int DMPAPER_A4_ROTATED = 77;

        public const int DMPAPER_A5_ROTATED = 78;

        public const int DMPAPER_B4_JIS_ROTATED = 79;

        public const int DMPAPER_B5_JIS_ROTATED = 80;

        public const int DMPAPER_JAPANESE_POSTCARD_ROTATED = 81;

        public const int DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82;

        public const int DMPAPER_A6_ROTATED = 83;

        public const int DMPAPER_JENV_KAKU2_ROTATED = 84;

        public const int DMPAPER_JENV_KAKU3_ROTATED = 85;

        public const int DMPAPER_JENV_CHOU3_ROTATED = 86;

        public const int DMPAPER_JENV_CHOU4_ROTATED = 87;

        public const int DMPAPER_B6_JIS = 88;

        public const int DMPAPER_B6_JIS_ROTATED = 89;

        public const int DMPAPER_12X11 = 90;

        public const int DMPAPER_JENV_YOU4 = 91;

        public const int DMPAPER_JENV_YOU4_ROTATED = 92;

        public const int DMPAPER_P16K = 93;

        public const int DMPAPER_P32K = 94;

        public const int DMPAPER_P32KBIG = 95;

        public const int DMPAPER_PENV_1 = 96;

        public const int DMPAPER_PENV_2 = 97;

        public const int DMPAPER_PENV_3 = 98;

        public const int DMPAPER_PENV_4 = 99;

        public const int DMPAPER_PENV_5 = 100;

        public const int DMPAPER_PENV_6 = 101;

        public const int DMPAPER_PENV_7 = 102;

        public const int DMPAPER_PENV_8 = 103;

        public const int DMPAPER_PENV_9 = 104;

        public const int DMPAPER_PENV_10 = 105;

        public const int DMPAPER_P16K_ROTATED = 106;

        public const int DMPAPER_P32K_ROTATED = 107;

        public const int DMPAPER_P32KBIG_ROTATED = 108;

        public const int DMPAPER_PENV_1_ROTATED = 109;

        public const int DMPAPER_PENV_2_ROTATED = 110;

        public const int DMPAPER_PENV_3_ROTATED = 111;

        public const int DMPAPER_PENV_4_ROTATED = 112;

        public const int DMPAPER_PENV_5_ROTATED = 113;

        public const int DMPAPER_PENV_6_ROTATED = 114;

        public const int DMPAPER_PENV_7_ROTATED = 115;

        public const int DMPAPER_PENV_8_ROTATED = 116;

        public const int DMPAPER_PENV_9_ROTATED = 117;

        public const int DMPAPER_PENV_10_ROTATED = 118;

        public const int DMPAPER_LAST = DMPAPER_PENV_10_ROTATED;

        public const int DMPAPER_USER = 256;

        public const int DMBIN_FIRST = DMBIN_UPPER;

        public const int DMBIN_UPPER = 1;

        public const int DMBIN_ONLYONE = 1;

        public const int DMBIN_LOWER = 2;

        public const int DMBIN_MIDDLE = 3;

        public const int DMBIN_MANUAL = 4;

        public const int DMBIN_ENVELOPE = 5;

        public const int DMBIN_ENVMANUAL = 6;

        public const int DMBIN_AUTO = 7;

        public const int DMBIN_TRACTOR = 8;

        public const int DMBIN_SMALLFMT = 9;

        public const int DMBIN_LARGEFMT = 10;

        public const int DMBIN_LARGECAPACITY = 11;

        public const int DMBIN_CASSETTE = 14;

        public const int DMBIN_FORMSOURCE = 15;

        public const int DMBIN_LAST = DMBIN_FORMSOURCE;

        public const int DMBIN_USER = 256;

        public const int DMRES_DRAFT = -1;

        public const int DMRES_LOW = -2;

        public const int DMRES_MEDIUM = -3;

        public const int DMRES_HIGH = -4;

        public const int DMCOLOR_MONOCHROME = 1;

        public const int DMCOLOR_COLOR = 2;

        public const int DMDUP_SIMPLEX = 1;

        public const int DMDUP_VERTICAL = 2;

        public const int DMDUP_HORIZONTAL = 3;

        public const int DMTT_BITMAP = 1;

        public const int DMTT_DOWNLOAD = 2;

        public const int DMTT_SUBDEV = 3;

        public const int DMTT_DOWNLOAD_OUTLINE = 4;

        public const int DMCOLLATE_FALSE = 0;

        public const int DMCOLLATE_TRUE = 1;

        public const int DMDO_DEFAULT = 0;

        public const int DMDO_90 = 1;

        public const int DMDO_180 = 2;

        public const int DMDO_270 = 3;

        public const int DMDFO_DEFAULT = 0;

        public const int DMDFO_STRETCH = 1;

        public const int DMDFO_CENTER = 2;

        public const int DM_INTERLACED = 0x00000002;

        public const int DMDISPLAYFLAGS_TEXTMODE = 0x00000004;

        public const int DMNUP_SYSTEM = 1;

        public const int DMNUP_ONEUP = 2;

        public const int DMICMMETHOD_NONE = 1;

        public const int DMICMMETHOD_SYSTEM = 2;

        public const int DMICMMETHOD_DRIVER = 3;

        public const int DMICMMETHOD_DEVICE = 4;

        public const int DMICMMETHOD_USER = 256;

        public const int DMICM_SATURATE = 1;

        public const int DMICM_CONTRAST = 2;

        public const int DMICM_COLORIMETRIC = 3;

        public const int DMICM_ABS_COLORIMETRIC = 4;

        public const int DMICM_USER = 256;

        public const int DMMEDIA_STANDARD = 1;

        public const int DMMEDIA_TRANSPARENCY = 2;

        public const int DMMEDIA_GLOSSY = 3;

        public const int DMMEDIA_USER = 256;

        public const int DMDITHER_NONE = 1;

        public const int DMDITHER_COARSE = 2;

        public const int DMDITHER_FINE = 3;

        public const int DMDITHER_LINEART = 4;

        public const int DMDITHER_ERRORDIFFUSION = 5;

        public const int DMDITHER_RESERVED6 = 6;

        public const int DMDITHER_RESERVED7 = 7;

        public const int DMDITHER_RESERVED8 = 8;

        public const int DMDITHER_RESERVED9 = 9;

        public const int DMDITHER_GRAYSCALE = 10;

        public const int DMDITHER_USER = 256;

        public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 0x00000001;

        public const int DISPLAY_DEVICE_MULTI_DRIVER = 0x00000002;

        public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 0x00000004;

        public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 0x00000008;

        public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 0x00000010;

        public const int DISPLAY_DEVICE_REMOVABLE = 0x00000020;

        public const int DISPLAY_DEVICE_ACC_DRIVER = 0x00000040;

        public const int DISPLAY_DEVICE_MODESPRUNED = 0x08000000;

        public const int DISPLAY_DEVICE_RDPUDD = 0x01000000;

        public const int DISPLAY_DEVICE_REMOTE = 0x04000000;

        public const int DISPLAY_DEVICE_DISCONNECT = 0x02000000;

        public const int DISPLAY_DEVICE_TS_COMPATIBLE = 0x00200000;

        public const int DISPLAY_DEVICE_UNSAFE_MODES_ON = 0x00080000;

        public const int DISPLAY_DEVICE_ACTIVE = 0x00000001;

        public const int DISPLAY_DEVICE_ATTACHED = 0x00000002;

        public const int DISPLAYCONFIG_MAXPATH = 1024;

        public const uint DISPLAYCONFIG_PATH_MODE_IDX_INVALID = 0xFFFFFFFF;

        public const uint DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID = 0xFFFF;

        public const uint DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID = 0xFFFF;

        public const uint DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID = 0xFFFF;

        public const uint DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID = 0xFFFF;

        public const int DISPLAYCONFIG_SOURCE_IN_USE = 0x00000001;

        public const int DISPLAYCONFIG_TARGET_IN_USE = 0x00000001;

        public const int DISPLAYCONFIG_TARGET_FORCIBLE = 0x00000002;

        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT = 0x00000004;

        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH = 0x00000008;

        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM = 0x00000010;

        public const int DISPLAYCONFIG_TARGET_IS_HMD = 0x00000020;

        public const int DISPLAYCONFIG_PATH_ACTIVE = 0x00000001;

        public const int DISPLAYCONFIG_PATH_PREFERRED_UNSCALED = 0x00000004;

        public const int DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE = 0x00000008;

        public const int DISPLAYCONFIG_PATH_VALID_FLAGS = 0x0000000D;

        public const int QDC_ALL_PATHS = 0x00000001;

        public const int QDC_ONLY_ACTIVE_PATHS = 0x00000002;

        public const int QDC_DATABASE_CURRENT = 0x00000004;

        public const int QDC_VIRTUAL_MODE_AWARE = 0x00000010;

        public const int QDC_INCLUDE_HMD = 0x00000020;

        public const int SDC_TOPOLOGY_INTERNAL = 0x00000001;

        public const int SDC_TOPOLOGY_CLONE = 0x00000002;

        public const int SDC_TOPOLOGY_EXTEND = 0x00000004;

        public const int SDC_TOPOLOGY_EXTERNAL = 0x00000008;

        public const int SDC_TOPOLOGY_SUPPLIED = 0x00000010;

        public const int SDC_USE_DATABASE_CURRENT = SDC_TOPOLOGY_INTERNAL | SDC_TOPOLOGY_CLONE | SDC_TOPOLOGY_EXTEND | SDC_TOPOLOGY_EXTERNAL;

        public const int SDC_USE_SUPPLIED_DISPLAY_CONFIG = 0x00000020;

        public const int SDC_VALIDATE = 0x00000040;

        public const int SDC_APPLY = 0x00000080;

        public const int SDC_NO_OPTIMIZATION = 0x00000100;

        public const int SDC_SAVE_TO_DATABASE = 0x00000200;

        public const int SDC_ALLOW_CHANGES = 0x00000400;

        public const int SDC_PATH_PERSIST_IF_REQUIRED = 0x00000800;

        public const int SDC_FORCE_MODE_ENUMERATION = 0x00001000;

        public const int SDC_ALLOW_PATH_ORDER_CHANGES = 0x00002000;

        public const int SDC_VIRTUAL_MODE_AWARE = 0x00008000;

        public const int SYSRGN = 4;

        public const int GGO_METRICS = 0;

        public const int GGO_BITMAP = 1;

        public const int GGO_NATIVE = 2;

        public const int GGO_BEZIER = 3;

        public const int GGO_GRAY2_BITMAP = 4;

        public const int GGO_GRAY4_BITMAP = 5;

        public const int GGO_GRAY8_BITMAP = 6;

        public const int GGO_GLYPH_INDEX = 0x0080;

        public const int GGO_UNHINTED = 0x0100;

        public const int TT_POLYGON_TYPE = 24;

        public const int TT_PRIM_LINE = 1;

        public const int TT_PRIM_QSPLINE = 2;

        public const int TT_PRIM_CSPLINE = 3;

        public const int GCP_DBCS = 0x0001;

        public const int GCP_REORDER = 0x0002;

        public const int GCP_USEKERNING = 0x0008;

        public const int GCP_GLYPHSHAPE = 0x0010;

        public const int GCP_LIGATE = 0x0020;

        public const int GCP_DIACRITIC = 0x0100;

        public const int GCP_KASHIDA = 0x0400;

        public const int GCP_ERROR = 0x8000;

        public const int FLI_MASK = 0x103B;

        public const int GCP_JUSTIFY = 0x00010000;

        public const int FLI_GLYPHS = 0x00040000;

        public const int GCP_CLASSIN = 0x00080000;

        public const int GCP_MAXEXTENT = 0x00100000;

        public const int GCP_JUSTIFYIN = 0x00200000;

        public const int GCP_DISPLAYZWG = 0x00400000;

        public const int GCP_SYMSWAPOFF = 0x00800000;

        public const int GCP_NUMERICOVERRIDE = 0x01000000;

        public const int GCP_NEUTRALOVERRIDE = 0x02000000;

        public const int GCP_NUMERICSLATIN = 0x04000000;

        public const int GCP_NUMERICSLOCAL = 0x08000000;

        public const int GCPCLASS_LATIN = 1;

        public const int GCPCLASS_HEBREW = 2;

        public const int GCPCLASS_ARABIC = 2;

        public const int GCPCLASS_NEUTRAL = 3;

        public const int GCPCLASS_LOCALNUMBER = 4;

        public const int GCPCLASS_LATINNUMBER = 5;

        public const int GCPCLASS_LATINNUMERICTERMINATOR = 6;

        public const int GCPCLASS_LATINNUMERICSEPARATOR = 7;

        public const int GCPCLASS_NUMERICSEPARATOR = 8;

        public const int GCPCLASS_PREBOUNDLTR = 0x80;

        public const int GCPCLASS_PREBOUNDRTL = 0x40;

        public const int GCPCLASS_POSTBOUNDLTR = 0x20;

        public const int GCPCLASS_POSTBOUNDRTL = 0x10;

        public const int GCPGLYPH_LINKBEFORE = 0x8000;

        public const int GCPGLYPH_LINKAFTER = 0x4000;

        public const int TT_AVAILABLE = 0x0001;

        public const int TT_ENABLED = 0x0002;

        public const int PFD_TYPE_RGBA = 0;

        public const int PFD_TYPE_COLORINDEX = 1;

        public const int PFD_MAIN_PLANE = 0;

        public const int PFD_OVERLAY_PLANE = 1;

        public const int PFD_UNDERLAY_PLANE = -1;

        public const uint PFD_DOUBLEBUFFER = 0x00000001;

        public const uint PFD_STEREO = 0x00000002;

        public const uint PFD_DRAW_TO_WINDOW = 0x00000004;

        public const uint PFD_DRAW_TO_BITMAP = 0x00000008;

        public const uint PFD_SUPPORT_GDI = 0x00000010;

        public const uint PFD_SUPPORT_OPENGL = 0x00000020;

        public const uint PFD_GENERIC_FORMAT = 0x00000040;

        public const uint PFD_NEED_PALETTE = 0x00000080;

        public const uint PFD_NEED_SYSTEM_PALETTE = 0x00000100;

        public const uint PFD_SWAP_EXCHANGE = 0x00000200;

        public const uint PFD_SWAP_COPY = 0x00000400;

        public const uint PFD_SWAP_LAYER_BUFFERS = 0x00000800;

        public const uint PFD_GENERIC_ACCELERATED = 0x00001000;

        public const uint PFD_SUPPORT_DIRECTDRAW = 0x00002000;

        public const uint PFD_DIRECT3D_ACCELERATED = 0x00004000;

        public const uint PFD_SUPPORT_COMPOSITION = 0x00008000;

        public const uint PFD_DEPTH_DONTCARE = 0x20000000;

        public const uint PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;

        public const uint PFD_STEREO_DONTCARE = 0x80000000;

        public const int DM_UPDATE = 1;

        public const int DM_COPY = 2;

        public const int DM_PROMPT = 4;

        public const int DM_MODIFY = 8;

        public const int DM_IN_BUFFER = DM_MODIFY;

        public const int DM_IN_PROMPT = DM_PROMPT;

        public const int DM_OUT_BUFFER = DM_COPY;

        public const int DM_OUT_DEFAULT = DM_UPDATE;

        public const int DC_FIELDS = 1;

        public const int DC_PAPERS = 2;

        public const int DC_PAPERSIZE = 3;

        public const int DC_MINEXTENT = 4;

        public const int DC_MAXEXTENT = 5;

        public const int DC_BINS = 6;

        public const int DC_DUPLEX = 7;

        public const int DC_SIZE = 8;

        public const int DC_EXTRA = 9;

        public const int DC_VERSION = 10;

        public const int DC_DRIVER = 11;

        public const int DC_BINNAMES = 12;

        public const int DC_ENUMRESOLUTIONS = 13;

        public const int DC_FILEDEPENDENCIES = 14;

        public const int DC_TRUETYPE = 15;

        public const int DC_PAPERNAMES = 16;

        public const int DC_ORIENTATION = 17;

        public const int DC_COPIES = 18;

        public const int DC_BINADJUST = 19;

        public const int DC_EMF_COMPLIANT = 20;

        public const int DC_DATATYPE_PRODUCED = 21;

        public const int DC_COLLATE = 22;

        public const int DC_MANUFACTURER = 23;

        public const int DC_MODEL = 24;

        public const int DC_PERSONALITY = 25;

        public const int DC_PRINTRATE = 26;

        public const int DC_PRINTRATEUNIT = 27;

        public const int PRINTRATEUNIT_PPM = 1;

        public const int PRINTRATEUNIT_CPS = 2;

        public const int PRINTRATEUNIT_LPM = 3;

        public const int PRINTRATEUNIT_IPM = 4;

        public const int DC_PRINTERMEM = 28;

        public const int DC_MEDIAREADY = 29;

        public const int DC_STAPLE = 30;

        public const int DC_PRINTRATEPPM = 31;

        public const int DC_COLORDEVICE = 32;

        public const int DC_NUP = 33;

        public const int DC_MEDIATYPENAMES = 34;

        public const int DC_MEDIATYPES = 35;

        public const int DCTT_BITMAP = 0x0000001;

        public const int DCTT_DOWNLOAD = 0x0000002;

        public const int DCTT_SUBDEV = 0x0000004;

        public const int DCTT_DOWNLOAD_OUTLINE = 0x0000008;

        public const int DCBA_FACEUPNONE = 0x0000;

        public const int DCBA_FACEUPCENTER = 0x0001;

        public const int DCBA_FACEUPLEFT = 0x0002;

        public const int DCBA_FACEUPRIGHT = 0x0003;

        public const int DCBA_FACEDOWNNONE = 0x0100;

        public const int DCBA_FACEDOWNCENTER = 0x0101;

        public const int DCBA_FACEDOWNLEFT = 0x0102;

        public const int DCBA_FACEDOWNRIGHT = 0x0103;

        public const int GS_8BIT_INDICES = 0x00000001;

        public const int GGI_MARK_NONEXISTING_GLYPHS = 0X0001;

        public const int STAMP_DESIGNVECTOR = 0x8000000 + 'd' + ('v' << 8);

        public const int STAMP_AXESLIST = 0x8000000 + 'a' + ('l' << 8);

        public const int STAMP_TRUETYPE_VARIATION = 0x8000000 + 't' + ('v' << 8);

        public const int STAMP_CFF2 = 0x8000000 + 'c' + ('v' << 8);

        public const int MM_MAX_NUMAXES = 16;

        public const int FR_PRIVATE = 0x10;

        public const int FR_NOT_ENUM = 0x20;

        public const int MM_MAX_AXES_NAMELEN = 16;

        public const int GDIREGISTERDDRAWPACKETVERSION = 0x1;

        public const int AC_SRC_OVER = 0x00;

        public const int AC_SRC_ALPHA = 0x01;

        public const int GRADIENT_FILL_RECT_H = 0x00000000;

        public const int GRADIENT_FILL_RECT_V = 0x00000001;

        public const int GRADIENT_FILL_TRIANGLE = 0x00000002;

        public const int GRADIENT_FILL_OP_FLAG = 0x000000FF;

        public const int CA_NEGATIVE = 0x0001;

        public const int CA_LOG_FILTER = 0x0002;

        public const int ILLUMINANT_DEVICE_DEFAULT = 0;

        public const int ILLUMINANT_A = 1;

        public const int ILLUMINANT_B = 2;

        public const int ILLUMINANT_C = 3;

        public const int ILLUMINANT_D50 = 4;

        public const int ILLUMINANT_D55 = 5;

        public const int ILLUMINANT_D65 = 6;

        public const int ILLUMINANT_D75 = 7;

        public const int ILLUMINANT_F2 = 8;

        public const int ILLUMINANT_MAX_INDEX = ILLUMINANT_F2;

        public const int ILLUMINANT_TUNGSTEN = ILLUMINANT_A;

        public const int ILLUMINANT_DAYLIGHT = ILLUMINANT_C;

        public const int ILLUMINANT_FLUORESCENT = ILLUMINANT_F2;

        public const int ILLUMINANT_NTSC = ILLUMINANT_C;

        public const ushort RGB_GAMMA_MIN = 02500;

        public const ushort RGB_GAMMA_MAX = 65000;

        public const ushort REFERENCE_WHITE_MIN = 6000;

        public const ushort REFERENCE_WHITE_MAX = 10000;

        public const ushort REFERENCE_BLACK_MIN = 0;

        public const ushort REFERENCE_BLACK_MAX = 4000;

        public const short COLOR_ADJ_MIN = -100;

        public const short COLOR_ADJ_MAX = 100;

        public const int DI_APPBANDING = 0x00000001;

        public const int DI_ROPS_READ_DESTINATION = 0x00000002;

        public const int ICM_OFF = 1;

        public const int ICM_ON = 2;

        public const int ICM_QUERY = 3;

        public const int ICM_DONE_OUTSIDEDC = 4;

        public const int ENHMETA_SIGNATURE = 0x464D4520;

        public const uint ENHMETA_STOCK_OBJECT = 0x80000000;

        public const int EMR_HEADER = 1;

        public const int EMR_POLYBEZIER = 2;

        public const int EMR_POLYGON = 3;

        public const int EMR_POLYLINE = 4;

        public const int EMR_POLYBEZIERTO = 5;

        public const int EMR_POLYLINETO = 6;

        public const int EMR_POLYPOLYLINE = 7;

        public const int EMR_POLYPOLYGON = 8;

        public const int EMR_SETWINDOWEXTEX = 9;

        public const int EMR_SETWINDOWORGEX = 10;

        public const int EMR_SETVIEWPORTEXTEX = 11;

        public const int EMR_SETVIEWPORTORGEX = 12;

        public const int EMR_SETBRUSHORGEX = 13;

        public const int EMR_EOF = 14;

        public const int EMR_SETPIXELV = 15;

        public const int EMR_SETMAPPERFLAGS = 16;

        public const int EMR_SETMAPMODE = 17;

        public const int EMR_SETBKMODE = 18;

        public const int EMR_SETPOLYFILLMODE = 19;

        public const int EMR_SETROP2 = 20;

        public const int EMR_SETSTRETCHBLTMODE = 21;

        public const int EMR_SETTEXTALIGN = 22;

        public const int EMR_SETCOLORADJUSTMENT = 23;

        public const int EMR_SETTEXTCOLOR = 24;

        public const int EMR_SETBKCOLOR = 25;

        public const int EMR_OFFSETCLIPRGN = 26;

        public const int EMR_MOVETOEX = 27;

        public const int EMR_SETMETARGN = 28;

        public const int EMR_EXCLUDECLIPRECT = 29;

        public const int EMR_INTERSECTCLIPRECT = 30;

        public const int EMR_SCALEVIEWPORTEXTEX = 31;

        public const int EMR_SCALEWINDOWEXTEX = 32;

        public const int EMR_SAVEDC = 33;

        public const int EMR_RESTOREDC = 34;

        public const int EMR_SETWORLDTRANSFORM = 35;

        public const int EMR_MODIFYWORLDTRANSFORM = 36;

        public const int EMR_SELECTOBJECT = 37;

        public const int EMR_CREATEPEN = 38;

        public const int EMR_CREATEBRUSHINDIRECT = 39;

        public const int EMR_DELETEOBJECT = 40;

        public const int EMR_ANGLEARC = 41;

        public const int EMR_ELLIPSE = 42;

        public const int EMR_RECTANGLE = 43;

        public const int EMR_ROUNDRECT = 44;

        public const int EMR_ARC = 45;

        public const int EMR_CHORD = 46;

        public const int EMR_PIE = 47;

        public const int EMR_SELECTPALETTE = 48;

        public const int EMR_CREATEPALETTE = 49;

        public const int EMR_SETPALETTEENTRIES = 50;

        public const int EMR_RESIZEPALETTE = 51;

        public const int EMR_REALIZEPALETTE = 52;

        public const int EMR_EXTFLOODFILL = 53;

        public const int EMR_LINETO = 54;

        public const int EMR_ARCTO = 55;

        public const int EMR_POLYDRAW = 56;

        public const int EMR_SETARCDIRECTION = 57;

        public const int EMR_SETMITERLIMIT = 58;

        public const int EMR_BEGINPATH = 59;

        public const int EMR_ENDPATH = 60;

        public const int EMR_CLOSEFIGURE = 61;

        public const int EMR_FILLPATH = 62;

        public const int EMR_STROKEANDFILLPATH = 63;

        public const int EMR_STROKEPATH = 64;

        public const int EMR_FLATTENPATH = 65;

        public const int EMR_WIDENPATH = 66;

        public const int EMR_SELECTCLIPPATH = 67;

        public const int EMR_ABORTPATH = 68;

        public const int EMR_GDICOMMENT = 70;

        public const int EMR_FILLRGN = 71;

        public const int EMR_FRAMERGN = 72;

        public const int EMR_INVERTRGN = 73;

        public const int EMR_PAINTRGN = 74;

        public const int EMR_EXTSELECTCLIPRGN = 75;

        public const int EMR_BITBLT = 76;

        public const int EMR_STRETCHBLT = 77;

        public const int EMR_MASKBLT = 78;

        public const int EMR_PLGBLT = 79;

        public const int EMR_SETDIBITSTODEVICE = 80;

        public const int EMR_STRETCHDIBITS = 81;

        public const int EMR_EXTCREATEFONTINDIRECTW = 82;

        public const int EMR_EXTTEXTOUTA = 83;

        public const int EMR_EXTTEXTOUTW = 84;

        public const int EMR_POLYBEZIER16 = 85;

        public const int EMR_POLYGON16 = 86;

        public const int EMR_POLYLINE16 = 87;

        public const int EMR_POLYBEZIERTO16 = 88;

        public const int EMR_POLYLINETO16 = 89;

        public const int EMR_POLYPOLYLINE16 = 90;

        public const int EMR_POLYPOLYGON16 = 91;

        public const int EMR_POLYDRAW16 = 92;

        public const int EMR_CREATEMONOBRUSH = 93;

        public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;

        public const int EMR_EXTCREATEPEN = 95;

        public const int EMR_POLYTEXTOUTA = 96;

        public const int EMR_POLYTEXTOUTW = 97;

        public const int EMR_SETICMMODE = 98;

        public const int EMR_CREATECOLORSPACE = 99;

        public const int EMR_SETCOLORSPACE = 100;

        public const int EMR_DELETECOLORSPACE = 101;

        public const int EMR_GLSRECORD = 102;

        public const int EMR_GLSBOUNDEDRECORD = 103;

        public const int EMR_PIXELFORMAT = 104;

        public const int EMR_RESERVED_105 = 105;

        public const int EMR_RESERVED_106 = 106;

        public const int EMR_RESERVED_107 = 107;

        public const int EMR_RESERVED_108 = 108;

        public const int EMR_RESERVED_109 = 109;

        public const int EMR_RESERVED_110 = 110;

        public const int EMR_COLORCORRECTPALETTE = 111;

        public const int EMR_SETICMPROFILEA = 112;

        public const int EMR_SETICMPROFILEW = 113;

        public const int EMR_ALPHABLEND = 114;

        public const int EMR_SETLAYOUT = 115;

        public const int EMR_TRANSPARENTBLT = 116;

        public const int EMR_RESERVED_117 = 117;

        public const int EMR_GRADIENTFILL = 118;

        public const int EMR_RESERVED_119 = 119;

        public const int EMR_RESERVED_120 = 120;

        public const int EMR_COLORMATCHTOTARGETW = 121;

        public const int EMR_CREATECOLORSPACEW = 122;

        public const int EMR_MIN = 1;

        public const int EMR_MAX = 122;

        public const int SETICMPROFILE_EMBEDED = 0x00000001;

        public const int CREATECOLORSPACE_EMBEDED = 0x00000001;

        public const int COLORMATCHTOTARGET_EMBEDED = 0x00000001;

        public const uint GDICOMMENT_IDENTIFIER = 0x43494447;

        public const uint GDICOMMENT_WINDOWS_METAFILE = 0x80000001;

        public const uint GDICOMMENT_BEGINGROUP = 0x00000002;

        public const uint GDICOMMENT_ENDGROUP = 0x00000003;

        public const uint GDICOMMENT_MULTIFORMATS = 0x40000004;

        public const int EPS_SIGNATURE = 0x46535045;

        public const int GDICOMMENT_UNICODE_STRING = 0x00000040;

        public const int GDICOMMENT_UNICODE_END = 0x00000080;

        public const int LPD_DOUBLEBUFFER = 0x00000001;

        public const int LPD_STEREO = 0x00000002;

        public const int LPD_SUPPORT_GDI = 0x00000010;

        public const int LPD_SUPPORT_OPENGL = 0x00000020;

        public const int LPD_SHARE_DEPTH = 0x00000040;

        public const int LPD_SHARE_STENCIL = 0x00000080;

        public const int LPD_SHARE_ACCUM = 0x00000100;

        public const int LPD_SWAP_EXCHANGE = 0x00000200;

        public const int LPD_SWAP_COPY = 0x00000400;

        public const int LPD_TRANSPARENT = 0x00001000;

        public const int LPD_TYPE_RGBA = 0;

        public const int LPD_TYPE_COLORINDEX = 1;

        public const int WGL_SWAP_MAIN_PLANE = 0x00000001;

        public const int WGL_SWAP_OVERLAY1 = 0x00000002;

        public const int WGL_SWAP_OVERLAY2 = 0x00000004;

        public const int WGL_SWAP_OVERLAY3 = 0x00000008;

        public const int WGL_SWAP_OVERLAY4 = 0x00000010;

        public const int WGL_SWAP_OVERLAY5 = 0x00000020;

        public const int WGL_SWAP_OVERLAY6 = 0x00000040;

        public const int WGL_SWAP_OVERLAY7 = 0x00000080;

        public const int WGL_SWAP_OVERLAY8 = 0x00000100;

        public const int WGL_SWAP_OVERLAY9 = 0x00000200;

        public const int WGL_SWAP_OVERLAY10 = 0x00000400;

        public const int WGL_SWAP_OVERLAY11 = 0x00000800;

        public const int WGL_SWAP_OVERLAY12 = 0x00001000;

        public const int WGL_SWAP_OVERLAY13 = 0x00002000;

        public const int WGL_SWAP_OVERLAY14 = 0x00004000;

        public const int WGL_SWAP_OVERLAY15 = 0x00008000;

        public const int WGL_SWAP_UNDERLAY1 = 0x00010000;

        public const int WGL_SWAP_UNDERLAY2 = 0x00020000;

        public const int WGL_SWAP_UNDERLAY3 = 0x00040000;

        public const int WGL_SWAP_UNDERLAY4 = 0x00080000;

        public const int WGL_SWAP_UNDERLAY5 = 0x00100000;

        public const int WGL_SWAP_UNDERLAY6 = 0x00200000;

        public const int WGL_SWAP_UNDERLAY7 = 0x00400000;

        public const int WGL_SWAP_UNDERLAY8 = 0x00800000;

        public const int WGL_SWAP_UNDERLAY9 = 0x01000000;

        public const int WGL_SWAP_UNDERLAY10 = 0x02000000;

        public const int WGL_SWAP_UNDERLAY11 = 0x04000000;

        public const int WGL_SWAP_UNDERLAY12 = 0x08000000;

        public const int WGL_SWAP_UNDERLAY13 = 0x10000000;

        public const int WGL_SWAP_UNDERLAY14 = 0x20000000;

        public const int WGL_SWAP_UNDERLAY15 = 0x40000000;

        public const int WGL_SWAPMULTIPLE_MAX = 16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint MAKEROP4(uint fore, uint back) => ((back << 8) & 0xFF000000) | fore;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetKValue([NativeTypeName("COLORREF")]uint cmyk) => (byte)cmyk;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetYValue([NativeTypeName("COLORREF")]uint cmyk) => (byte)(cmyk >> 8);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetMValue([NativeTypeName("COLORREF")]uint cmyk) => (byte)(cmyk >> 16);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetCValue([NativeTypeName("COLORREF")] uint cmyk) => (byte)(cmyk >> 24);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("COLORREF")]
        public static uint CMYK(byte c, byte m, byte y, byte k) => k | ((uint)y << 8) | (((uint)m) << 16) | (((uint)c) << 24);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static POINTS MAKEPOINTS(int l) => *(POINTS*)&l;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("COLORREF")]
        public static uint RGB(byte r, byte g, byte b) => r | ((uint)g << 8) | (((uint)b) << 16);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("COLORREF")]
        public static uint PALETTERGB(byte r, byte g, byte b) => 0x02000000 | RGB(r, g, b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("COLORREF")]
        public static uint PALETTEINDEX(ushort i) => 0x01000000 | (uint)i;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetRValue([NativeTypeName("COLORREF")] uint rgb) => LOBYTE((ushort)rgb);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetGValue([NativeTypeName("COLORREF")] uint rgb) => LOBYTE((ushort)(rgb >> 8));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte GetBValue([NativeTypeName("COLORREF")] uint rgb) => LOBYTE((ushort)(rgb >> 16));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GDI_WIDTHBYTES(uint bits) => ((bits + 31) & ~31u) / 8;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GDI_DIBWIDTHBYTES(BITMAPINFOHEADER bi) => GDI_WIDTHBYTES((uint)bi.biWidth * bi.biBitCount);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GDI__DIBSIZE(BITMAPINFOHEADER bi) => GDI_DIBWIDTHBYTES(bi) * (uint)bi.biHeight;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GDI_DIBSIZE(BITMAPINFOHEADER bi) => bi.biHeight < 0 ? unchecked((uint)-1) * GDI__DIBSIZE(bi) : GDI__DIBSIZE(bi);
    }
}
