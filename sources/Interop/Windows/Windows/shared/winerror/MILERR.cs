// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MILERR
{
    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_OBJECTBUSY"]/*' />
    [NativeTypeName("#define MILERR_OBJECTBUSY _HRESULT_TYPEDEF_(0x88980001L)")]
    public const int MILERR_OBJECTBUSY = unchecked((int)(0x88980001));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INSUFFICIENTBUFFER"]/*' />
    [NativeTypeName("#define MILERR_INSUFFICIENTBUFFER _HRESULT_TYPEDEF_(0x88980002L)")]
    public const int MILERR_INSUFFICIENTBUFFER = unchecked((int)(0x88980002));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_WIN32ERROR"]/*' />
    [NativeTypeName("#define MILERR_WIN32ERROR _HRESULT_TYPEDEF_(0x88980003L)")]
    public const int MILERR_WIN32ERROR = unchecked((int)(0x88980003));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_SCANNER_FAILED"]/*' />
    [NativeTypeName("#define MILERR_SCANNER_FAILED _HRESULT_TYPEDEF_(0x88980004L)")]
    public const int MILERR_SCANNER_FAILED = unchecked((int)(0x88980004));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_SCREENACCESSDENIED"]/*' />
    [NativeTypeName("#define MILERR_SCREENACCESSDENIED _HRESULT_TYPEDEF_(0x88980005L)")]
    public const int MILERR_SCREENACCESSDENIED = unchecked((int)(0x88980005));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DISPLAYSTATEINVALID"]/*' />
    [NativeTypeName("#define MILERR_DISPLAYSTATEINVALID _HRESULT_TYPEDEF_(0x88980006L)")]
    public const int MILERR_DISPLAYSTATEINVALID = unchecked((int)(0x88980006));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NONINVERTIBLEMATRIX"]/*' />
    [NativeTypeName("#define MILERR_NONINVERTIBLEMATRIX _HRESULT_TYPEDEF_(0x88980007L)")]
    public const int MILERR_NONINVERTIBLEMATRIX = unchecked((int)(0x88980007));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_ZEROVECTOR"]/*' />
    [NativeTypeName("#define MILERR_ZEROVECTOR _HRESULT_TYPEDEF_(0x88980008L)")]
    public const int MILERR_ZEROVECTOR = unchecked((int)(0x88980008));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_TERMINATED"]/*' />
    [NativeTypeName("#define MILERR_TERMINATED _HRESULT_TYPEDEF_(0x88980009L)")]
    public const int MILERR_TERMINATED = unchecked((int)(0x88980009));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_BADNUMBER"]/*' />
    [NativeTypeName("#define MILERR_BADNUMBER _HRESULT_TYPEDEF_(0x8898000AL)")]
    public const int MILERR_BADNUMBER = unchecked((int)(0x8898000A));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INTERNALERROR"]/*' />
    [NativeTypeName("#define MILERR_INTERNALERROR _HRESULT_TYPEDEF_(0x88980080L)")]
    public const int MILERR_INTERNALERROR = unchecked((int)(0x88980080));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DISPLAYFORMATNOTSUPPORTED"]/*' />
    [NativeTypeName("#define MILERR_DISPLAYFORMATNOTSUPPORTED _HRESULT_TYPEDEF_(0x88980084L)")]
    public const int MILERR_DISPLAYFORMATNOTSUPPORTED = unchecked((int)(0x88980084));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INVALIDCALL"]/*' />
    [NativeTypeName("#define MILERR_INVALIDCALL _HRESULT_TYPEDEF_(0x88980085L)")]
    public const int MILERR_INVALIDCALL = unchecked((int)(0x88980085));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_ALREADYLOCKED"]/*' />
    [NativeTypeName("#define MILERR_ALREADYLOCKED _HRESULT_TYPEDEF_(0x88980086L)")]
    public const int MILERR_ALREADYLOCKED = unchecked((int)(0x88980086));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NOTLOCKED"]/*' />
    [NativeTypeName("#define MILERR_NOTLOCKED _HRESULT_TYPEDEF_(0x88980087L)")]
    public const int MILERR_NOTLOCKED = unchecked((int)(0x88980087));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DEVICECANNOTRENDERTEXT"]/*' />
    [NativeTypeName("#define MILERR_DEVICECANNOTRENDERTEXT _HRESULT_TYPEDEF_(0x88980088L)")]
    public const int MILERR_DEVICECANNOTRENDERTEXT = unchecked((int)(0x88980088));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_GLYPHBITMAPMISSED"]/*' />
    [NativeTypeName("#define MILERR_GLYPHBITMAPMISSED _HRESULT_TYPEDEF_(0x88980089L)")]
    public const int MILERR_GLYPHBITMAPMISSED = unchecked((int)(0x88980089));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MALFORMEDGLYPHCACHE"]/*' />
    [NativeTypeName("#define MILERR_MALFORMEDGLYPHCACHE _HRESULT_TYPEDEF_(0x8898008AL)")]
    public const int MILERR_MALFORMEDGLYPHCACHE = unchecked((int)(0x8898008A));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_GENERIC_IGNORE"]/*' />
    [NativeTypeName("#define MILERR_GENERIC_IGNORE _HRESULT_TYPEDEF_(0x8898008BL)")]
    public const int MILERR_GENERIC_IGNORE = unchecked((int)(0x8898008B));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MALFORMED_GUIDELINE_DATA"]/*' />
    [NativeTypeName("#define MILERR_MALFORMED_GUIDELINE_DATA _HRESULT_TYPEDEF_(0x8898008CL)")]
    public const int MILERR_MALFORMED_GUIDELINE_DATA = unchecked((int)(0x8898008C));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NO_HARDWARE_DEVICE"]/*' />
    [NativeTypeName("#define MILERR_NO_HARDWARE_DEVICE _HRESULT_TYPEDEF_(0x8898008DL)")]
    public const int MILERR_NO_HARDWARE_DEVICE = unchecked((int)(0x8898008D));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NEED_RECREATE_AND_PRESENT"]/*' />
    [NativeTypeName("#define MILERR_NEED_RECREATE_AND_PRESENT _HRESULT_TYPEDEF_(0x8898008EL)")]
    public const int MILERR_NEED_RECREATE_AND_PRESENT = unchecked((int)(0x8898008E));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define MILERR_ALREADY_INITIALIZED _HRESULT_TYPEDEF_(0x8898008FL)")]
    public const int MILERR_ALREADY_INITIALIZED = unchecked((int)(0x8898008F));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MISMATCHED_SIZE"]/*' />
    [NativeTypeName("#define MILERR_MISMATCHED_SIZE _HRESULT_TYPEDEF_(0x88980090L)")]
    public const int MILERR_MISMATCHED_SIZE = unchecked((int)(0x88980090));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NO_REDIRECTION_SURFACE_AVAILABLE"]/*' />
    [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_AVAILABLE _HRESULT_TYPEDEF_(0x88980091L)")]
    public const int MILERR_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)(0x88980091));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_REMOTING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MILERR_REMOTING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980092L)")]
    public const int MILERR_REMOTING_NOT_SUPPORTED = unchecked((int)(0x88980092));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_QUEUED_PRESENT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MILERR_QUEUED_PRESENT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980093L)")]
    public const int MILERR_QUEUED_PRESENT_NOT_SUPPORTED = unchecked((int)(0x88980093));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NOT_QUEUING_PRESENTS"]/*' />
    [NativeTypeName("#define MILERR_NOT_QUEUING_PRESENTS _HRESULT_TYPEDEF_(0x88980094L)")]
    public const int MILERR_NOT_QUEUING_PRESENTS = unchecked((int)(0x88980094));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER"]/*' />
    [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER _HRESULT_TYPEDEF_(0x88980095L)")]
    public const int MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER = unchecked((int)(0x88980095));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_TOOMANYSHADERELEMNTS"]/*' />
    [NativeTypeName("#define MILERR_TOOMANYSHADERELEMNTS _HRESULT_TYPEDEF_(0x88980096L)")]
    public const int MILERR_TOOMANYSHADERELEMNTS = unchecked((int)(0x88980096));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MROW_READLOCK_FAILED"]/*' />
    [NativeTypeName("#define MILERR_MROW_READLOCK_FAILED _HRESULT_TYPEDEF_(0x88980097L)")]
    public const int MILERR_MROW_READLOCK_FAILED = unchecked((int)(0x88980097));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MROW_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define MILERR_MROW_UPDATE_FAILED _HRESULT_TYPEDEF_(0x88980098L)")]
    public const int MILERR_MROW_UPDATE_FAILED = unchecked((int)(0x88980098));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_SHADER_COMPILE_FAILED"]/*' />
    [NativeTypeName("#define MILERR_SHADER_COMPILE_FAILED _HRESULT_TYPEDEF_(0x88980099L)")]
    public const int MILERR_SHADER_COMPILE_FAILED = unchecked((int)(0x88980099));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_MAX_TEXTURE_SIZE_EXCEEDED"]/*' />
    [NativeTypeName("#define MILERR_MAX_TEXTURE_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x8898009AL)")]
    public const int MILERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)(0x8898009A));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_QPC_TIME_WENT_BACKWARD"]/*' />
    [NativeTypeName("#define MILERR_QPC_TIME_WENT_BACKWARD _HRESULT_TYPEDEF_(0x8898009BL)")]
    public const int MILERR_QPC_TIME_WENT_BACKWARD = unchecked((int)(0x8898009B));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DXGI_ENUMERATION_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define MILERR_DXGI_ENUMERATION_OUT_OF_SYNC _HRESULT_TYPEDEF_(0x8898009DL)")]
    public const int MILERR_DXGI_ENUMERATION_OUT_OF_SYNC = unchecked((int)(0x8898009D));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_ADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define MILERR_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x8898009EL)")]
    public const int MILERR_ADAPTER_NOT_FOUND = unchecked((int)(0x8898009E));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_COLORSPACE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MILERR_COLORSPACE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8898009FL)")]
    public const int MILERR_COLORSPACE_NOT_SUPPORTED = unchecked((int)(0x8898009F));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_PREFILTER_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MILERR_PREFILTER_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x889800A0L)")]
    public const int MILERR_PREFILTER_NOT_SUPPORTED = unchecked((int)(0x889800A0));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DISPLAYID_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define MILERR_DISPLAYID_ACCESS_DENIED _HRESULT_TYPEDEF_(0x889800A1L)")]
    public const int MILERR_DISPLAYID_ACCESS_DENIED = unchecked((int)(0x889800A1));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_DEVICE_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_DEVICE_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800B0L)")]
    public const int MILERR_DEVICE_CREATION_FAILURE = unchecked((int)(0x889800B0));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INTEL_DEVICE_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_INTEL_DEVICE_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800B1L)")]
    public const int MILERR_INTEL_DEVICE_CREATION_FAILURE = unchecked((int)(0x889800B1));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_AMD_DEVICE_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_AMD_DEVICE_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800B2L)")]
    public const int MILERR_AMD_DEVICE_CREATION_FAILURE = unchecked((int)(0x889800B2));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NVIDIA_DEVICE_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_NVIDIA_DEVICE_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800B3L)")]
    public const int MILERR_NVIDIA_DEVICE_CREATION_FAILURE = unchecked((int)(0x889800B3));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_QC_DEVICE_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_QC_DEVICE_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800B4L)")]
    public const int MILERR_QC_DEVICE_CREATION_FAILURE = unchecked((int)(0x889800B4));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C0L)")]
    public const int MILERR_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C0));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INTEL_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_INTEL_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C1L)")]
    public const int MILERR_INTEL_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C1));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_AMD_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_AMD_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C2L)")]
    public const int MILERR_AMD_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C2));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NVIDIA_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_NVIDIA_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C3L)")]
    public const int MILERR_NVIDIA_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C3));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_QC_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_QC_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C4L)")]
    public const int MILERR_QC_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C4));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_IDD_SWAPCHAIN_CREATION_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_IDD_SWAPCHAIN_CREATION_FAILURE _HRESULT_TYPEDEF_(0x889800C5L)")]
    public const int MILERR_IDD_SWAPCHAIN_CREATION_FAILURE = unchecked((int)(0x889800C5));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D0L)")]
    public const int MILERR_PRESENT_FAILURE = unchecked((int)(0x889800D0));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_INTEL_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_INTEL_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D1L)")]
    public const int MILERR_INTEL_PRESENT_FAILURE = unchecked((int)(0x889800D1));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_AMD_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_AMD_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D2L)")]
    public const int MILERR_AMD_PRESENT_FAILURE = unchecked((int)(0x889800D2));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_NVIDIA_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_NVIDIA_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D3L)")]
    public const int MILERR_NVIDIA_PRESENT_FAILURE = unchecked((int)(0x889800D3));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_QC_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_QC_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D4L)")]
    public const int MILERR_QC_PRESENT_FAILURE = unchecked((int)(0x889800D4));

    /// <include file='MILERR.xml' path='doc/member[@name="MILERR.MILERR_IDD_PRESENT_FAILURE"]/*' />
    [NativeTypeName("#define MILERR_IDD_PRESENT_FAILURE _HRESULT_TYPEDEF_(0x889800D5L)")]
    public const int MILERR_IDD_PRESENT_FAILURE = unchecked((int)(0x889800D5));
}
