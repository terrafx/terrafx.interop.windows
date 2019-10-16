// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int FACILITY_NULL = 0;

        public const int FACILITY_WIN32 = 7;

        public const int FACILITY_DXGI = 2170;

        public const int FACILITY_DIRECT3D12 = 2174;

        public const int FACILITY_DIRECT3D12_DEBUG = 2175;

        public const int FACILITY_WINCODEC_DWRITE_DWM = 2200;

        public const int FACILITY_DIRECT2D = 2201;

        public const int ERROR_FILE_NOT_FOUND = 2;

        public const int ERROR_ACCESS_DENIED = 5;

        public const int ERROR_INVALID_HANDLE = 6;

        public const int ERROR_OUTOFMEMORY = 14;

        public const int ERROR_INVALID_PARAMETER = 87;

        public const int ERROR_INSUFFICIENT_BUFFER = 122;

        public const int ERROR_ARITHMETIC_OVERFLOW = 534;

        public const int SEVERITY_SUCCESS = 0;

        public const int SEVERITY_ERROR = 1;

        public const int E_UNEXPECTED = unchecked((int)0x8000FFFF);

        public const int E_NOTIMPL = unchecked((int)0x80004001);

        public const int E_OUTOFMEMORY = unchecked((int)0x8007000E);

        public const int E_INVALIDARG = unchecked((int)0x80070057);

        public const int E_NOINTERFACE = unchecked((int)0x80004002);

        public const int E_POINTER = unchecked((int)0x80004003);

        public const int E_HANDLE = unchecked((int)0x80070006);

        public const int E_ABORT = unchecked((int)0x80004004);

        public const int E_FAIL = unchecked((int)0x80004005);

        public const int E_ACCESSDENIED = unchecked((int)0x80070005);

        public const int DXGI_STATUS_OCCLUDED = 0x087A0001;

        public const int DXGI_STATUS_CLIPPED = 0x087A0002;

        public const int DXGI_STATUS_NO_REDIRECTION = 0x087A0004;

        public const int DXGI_STATUS_NO_DESKTOP_ACCESS = 0x087A0005;

        public const int DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = 0x087A0006;

        public const int DXGI_STATUS_MODE_CHANGED = 0x087A0007;

        public const int DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = 0x087A0008;

        public const int DXGI_STATUS_UNOCCLUDED = 0x087A0009;

        public const int DXGI_STATUS_DDA_WAS_STILL_DRAWING = 0x087A000A;

        public const int DXGI_STATUS_PRESENT_REQUIRED = 0x087A002F;

        public const int DXGI_ERROR_INVALID_CALL = unchecked((int)0x887A0001);

        public const int DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002);

        public const int DXGI_ERROR_MORE_DATA = unchecked((int)0x887A0003);

        public const int DXGI_ERROR_UNSUPPORTED = unchecked((int)0x887A0004);

        public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)0x887A0005);

        public const int DXGI_ERROR_DEVICE_HUNG = unchecked((int)0x887A0006);

        public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)0x887A0007);

        public const int DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)0x887A000A);

        public const int DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)0x887A000B);

        public const int DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0x887A000C);

        public const int DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)0x887A0020);

        public const int DXGI_ERROR_NONEXCLUSIVE = unchecked((int)0x887A0021);

        public const int DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)0x887A0022);

        public const int DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)0x887A0023);

        public const int DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)0x887A0024);

        public const int DXGI_ERROR_ACCESS_LOST = unchecked((int)0x887A0026);

        public const int DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)0x887A0027);

        public const int DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)0x887A0028);

        public const int DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)0x887A0029);

        public const int DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)0x887A002A);

        public const int DXGI_ERROR_ACCESS_DENIED = unchecked((int)0x887A002B);

        public const int DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)0x887A002C);

        public const int DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)0x887A002D);

        public const int DXGI_ERROR_NOT_CURRENT = unchecked((int)0x887A002E);

        public const int DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)0x887A0030);

        public const int DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)0x887A0031);

        public const int DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)0x887A0032);

        public const int DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)0x887A0025);

        public const int DXGI_ERROR_CACHE_CORRUPT = unchecked((int)0x887A0033);

        public const int DXGI_ERROR_CACHE_FULL = unchecked((int)0x887A0034);

        public const int DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)0x887A0035);

        public const int DXGI_ERROR_ALREADY_EXISTS = unchecked((int)0x887A0036);

        public const int D3D12_ERROR_ADAPTER_NOT_FOUND = unchecked((int)0x887E0001);

        public const int D3D12_ERROR_DRIVER_VERSION_MISMATCH = unchecked((int)0x887E0002);

        public const int D2DERR_WRONG_STATE = unchecked((int)0x88990001);

        public const int D2DERR_NOT_INITIALIZED = unchecked((int)0x88990002);

        public const int D2DERR_UNSUPPORTED_OPERATION = unchecked((int)0x88990003);

        public const int D2DERR_SCANNER_FAILED = unchecked((int)0x88990004);

        public const int D2DERR_SCREEN_ACCESS_DENIED = unchecked((int)0x88990005);

        public const int D2DERR_DISPLAY_STATE_INVALID = unchecked((int)0x88990006);

        public const int D2DERR_ZERO_VECTOR = unchecked((int)0x88990007);

        public const int D2DERR_INTERNAL_ERROR = unchecked((int)0x88990008);

        public const int D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = unchecked((int)0x88990009);

        public const int D2DERR_INVALID_CALL = unchecked((int)0x8899000A);

        public const int D2DERR_NO_HARDWARE_DEVICE = unchecked((int)0x8899000B);

        public const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

        public const int D2DERR_TOO_MANY_SHADER_ELEMENTS = unchecked((int)0x8899000D);

        public const int D2DERR_SHADER_COMPILE_FAILED = unchecked((int)0x8899000E);

        public const int D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)0x8899000F);

        public const int D2DERR_UNSUPPORTED_VERSION = unchecked((int)0x88990010);

        public const int D2DERR_BAD_NUMBER = unchecked((int)0x88990011);

        public const int D2DERR_WRONG_FACTORY = unchecked((int)0x88990012);

        public const int D2DERR_LAYER_ALREADY_IN_USE = unchecked((int)0x88990013);

        public const int D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = unchecked((int)0x88990014);

        public const int D2DERR_WRONG_RESOURCE_DOMAIN = unchecked((int)0x88990015);

        public const int D2DERR_PUSH_POP_UNBALANCED = unchecked((int)0x88990016);

        public const int D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = unchecked((int)0x88990017);

        public const int D2DERR_INCOMPATIBLE_BRUSH_TYPES = unchecked((int)0x88990018);

        public const int D2DERR_WIN32_ERROR = unchecked((int)0x88990019);

        public const int D2DERR_TARGET_NOT_GDI_COMPATIBLE = unchecked((int)0x8899001A);

        public const int D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = unchecked((int)0x8899001B);

        public const int D2DERR_TEXT_RENDERER_NOT_RELEASED = unchecked((int)0x8899001C);

        public const int D2DERR_EXCEEDS_MAX_BITMAP_SIZE = unchecked((int)0x8899001D);

        public const int D2DERR_INVALID_GRAPH_CONFIGURATION = unchecked((int)0x8899001E);

        public const int D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = unchecked((int)0x8899001F);

        public const int D2DERR_CYCLIC_GRAPH = unchecked((int)0x88990020);

        public const int D2DERR_BITMAP_CANNOT_DRAW = unchecked((int)0x88990021);

        public const int D2DERR_OUTSTANDING_BITMAP_REFERENCES = unchecked((int)0x88990022);

        public const int D2DERR_ORIGINAL_TARGET_NOT_BOUND = unchecked((int)0x88990023);

        public const int D2DERR_INVALID_TARGET = unchecked((int)0x88990024);

        public const int D2DERR_BITMAP_BOUND_AS_TARGET = unchecked((int)0x88990025);

        public const int D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = unchecked((int)0x88990026);

        public const int D2DERR_INTERMEDIATE_TOO_LARGE = unchecked((int)0x88990027);

        public const int D2DERR_EFFECT_IS_NOT_REGISTERED = unchecked((int)0x88990028);

        public const int D2DERR_INVALID_PROPERTY = unchecked((int)0x88990029);

        public const int D2DERR_NO_SUBPROPERTIES = unchecked((int)0x8899002A);

        public const int D2DERR_PRINT_JOB_CLOSED = unchecked((int)0x8899002B);

        public const int D2DERR_PRINT_FORMAT_NOT_SUPPORTED = unchecked((int)0x8899002C);

        public const int D2DERR_TOO_MANY_TRANSFORM_INPUTS = unchecked((int)0x8899002D);

        public const int D2DERR_INVALID_GLYPH_IMAGE = unchecked((int)0x8899002E);

        public const int WINCODEC_ERR_WRONGSTATE = unchecked((int)0x88982F04);

        public const int WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)0x88982F05);

        public const int WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)0x88982F07);

        public const int WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)0x88982F0B);

        public const int WINCODEC_ERR_NOTINITIALIZED = unchecked((int)0x88982F0C);

        public const int WINCODEC_ERR_ALREADYLOCKED = unchecked((int)0x88982F0D);

        public const int WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)0x88982F40);

        public const int WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)0x88982F41);

        public const int WINCODEC_ERR_PROPERTYSIZE = unchecked((int)0x88982F42);

        public const int WINCODEC_ERR_CODECPRESENT = unchecked((int)0x88982F43);

        public const int WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)0x88982F44);

        public const int WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)0x88982F45);

        public const int WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)0x88982F46);

        public const int WINCODEC_ERR_INTERNALERROR = unchecked((int)0x88982F48);

        public const int WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)0x88982F49);

        public const int WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)0x88982F50);

        public const int WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)0x88982F51);

        public const int WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)0x88982F52);

        public const int WINCODEC_ERR_BADIMAGE = unchecked((int)0x88982F60);

        public const int WINCODEC_ERR_BADHEADER = unchecked((int)0x88982F61);

        public const int WINCODEC_ERR_FRAMEMISSING = unchecked((int)0x88982F62);

        public const int WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)0x88982F63);

        public const int WINCODEC_ERR_BADSTREAMDATA = unchecked((int)0x88982F70);

        public const int WINCODEC_ERR_STREAMWRITE = unchecked((int)0x88982F71);

        public const int WINCODEC_ERR_STREAMREAD = unchecked((int)0x88982F72);

        public const int WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)0x88982F73);

        public const int WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)0x88982F80);

        public const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982F81);

        public const int WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)0x88982F8A);

        public const int WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)0x88982F8B);

        public const int WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)0x88982F8C);

        public const int WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)0x88982F8D);

        public const int WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)0x88982F8E);

        public const int WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)0x88982F8F);

        public const int WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)0x88982F90);

        public const int WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)0x88982F91);

        public const int WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)0x88982F92);

        public const int WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)0x88982F93);

        public const int WINCODEC_ERR_WIN32ERROR = unchecked((int)0x88982F94);

        public const int WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)0x88982F95);

        public const int WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)0x88982F96);

        public static bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        public static bool FAILED(int hr)
        {
            return hr < 0;
        }

        public static bool IS_ERROR(int Status)
        {
            return ((uint)Status >> 31) == SEVERITY_ERROR;
        }

        public static int HRESULT_CODE(int hr)
        {
            return hr & 0xFFFF;
        }

        public static int SCODE_CODE(int sc)
        {
            return sc & 0xFFFF;
        }

        public static int HRESULT_FACILITY(int hr)
        {
            return (hr >> 16) & 0x1FFF;
        }

        public static int SCODE_FACILITY(int sc)
        {
            return (sc >> 16) & 0x1FFF;
        }

        public static int HRESULT_SEVERITY(int hr)
        {
            return (hr >> 31) & 0x1;
        }

        public static int SCODE_SEVERITY(int sc)
        {
            return (sc >> 31) & 0x1;
        }

        public static int MAKE_HRESULT(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int MAKE_SCODE(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int __HRESULT_FROM_WIN32(int x)
        {
            return (x <= 0) ? x : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
        }

        public static int HRESULT_FROM_WIN32(int x)
        {
            return __HRESULT_FROM_WIN32(x);
        }
    }
}
