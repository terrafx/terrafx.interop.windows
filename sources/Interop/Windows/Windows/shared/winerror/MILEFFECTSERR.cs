// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MILEFFECTSERR
{
    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_UNKNOWNPROPERTY"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_UNKNOWNPROPERTY _HRESULT_TYPEDEF_(0x8898060EL)")]
    public const int MILEFFECTSERR_UNKNOWNPROPERTY = unchecked((int)(0x8898060E));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_EFFECTNOTPARTOFGROUP"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_EFFECTNOTPARTOFGROUP _HRESULT_TYPEDEF_(0x8898060FL)")]
    public const int MILEFFECTSERR_EFFECTNOTPARTOFGROUP = unchecked((int)(0x8898060F));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_NOINPUTSOURCEATTACHED"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_NOINPUTSOURCEATTACHED _HRESULT_TYPEDEF_(0x88980610L)")]
    public const int MILEFFECTSERR_NOINPUTSOURCEATTACHED = unchecked((int)(0x88980610));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_CONNECTORNOTCONNECTED"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_CONNECTORNOTCONNECTED _HRESULT_TYPEDEF_(0x88980611L)")]
    public const int MILEFFECTSERR_CONNECTORNOTCONNECTED = unchecked((int)(0x88980611));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT _HRESULT_TYPEDEF_(0x88980612L)")]
    public const int MILEFFECTSERR_CONNECTORNOTASSOCIATEDWITHEFFECT = unchecked((int)(0x88980612));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_RESERVED"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_RESERVED _HRESULT_TYPEDEF_(0x88980613L)")]
    public const int MILEFFECTSERR_RESERVED = unchecked((int)(0x88980613));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_CYCLEDETECTED"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_CYCLEDETECTED _HRESULT_TYPEDEF_(0x88980614L)")]
    public const int MILEFFECTSERR_CYCLEDETECTED = unchecked((int)(0x88980614));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_EFFECTINMORETHANONEGRAPH"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_EFFECTINMORETHANONEGRAPH _HRESULT_TYPEDEF_(0x88980615L)")]
    public const int MILEFFECTSERR_EFFECTINMORETHANONEGRAPH = unchecked((int)(0x88980615));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_EFFECTALREADYINAGRAPH"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_EFFECTALREADYINAGRAPH _HRESULT_TYPEDEF_(0x88980616L)")]
    public const int MILEFFECTSERR_EFFECTALREADYINAGRAPH = unchecked((int)(0x88980616));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_EFFECTHASNOCHILDREN"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_EFFECTHASNOCHILDREN _HRESULT_TYPEDEF_(0x88980617L)")]
    public const int MILEFFECTSERR_EFFECTHASNOCHILDREN = unchecked((int)(0x88980617));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_ALREADYATTACHEDTOLISTENER"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_ALREADYATTACHEDTOLISTENER _HRESULT_TYPEDEF_(0x88980618L)")]
    public const int MILEFFECTSERR_ALREADYATTACHEDTOLISTENER = unchecked((int)(0x88980618));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_NOTAFFINETRANSFORM"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_NOTAFFINETRANSFORM _HRESULT_TYPEDEF_(0x88980619L)")]
    public const int MILEFFECTSERR_NOTAFFINETRANSFORM = unchecked((int)(0x88980619));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_EMPTYBOUNDS"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_EMPTYBOUNDS _HRESULT_TYPEDEF_(0x8898061AL)")]
    public const int MILEFFECTSERR_EMPTYBOUNDS = unchecked((int)(0x8898061A));

    /// <include file='MILEFFECTSERR.xml' path='doc/member[@name="MILEFFECTSERR.MILEFFECTSERR_OUTPUTSIZETOOLARGE"]/*' />
    [NativeTypeName("#define MILEFFECTSERR_OUTPUTSIZETOOLARGE _HRESULT_TYPEDEF_(0x8898061BL)")]
    public const int MILEFFECTSERR_OUTPUTSIZETOOLARGE = unchecked((int)(0x8898061B));
}
