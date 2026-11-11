// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.BrowserNavConstants;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.navUserInitiatedAction"]/*' />
    [NativeTypeName("#define navUserInitiatedAction navReserved1")]
    public const BrowserNavConstants navUserInitiatedAction = navReserved1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navDisableDownloadSave"]/*' />
    [NativeTypeName("#define navDisableDownloadSave navReserved2")]
    public const BrowserNavConstants navDisableDownloadSave = navReserved2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navServerRedirectedVtabSwitch"]/*' />
    [NativeTypeName("#define navServerRedirectedVtabSwitch navReserved3")]
    public const BrowserNavConstants navServerRedirectedVtabSwitch = navReserved3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navVtabSwitchNotUserInitiatedAction"]/*' />
    [NativeTypeName("#define navVtabSwitchNotUserInitiatedAction navReserved4")]
    public const BrowserNavConstants navVtabSwitchNotUserInitiatedAction = navReserved4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navCheckDontShowNeedIE"]/*' />
    [NativeTypeName("#define navCheckDontShowNeedIE navReserved5")]
    public const BrowserNavConstants navCheckDontShowNeedIE = navReserved5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navCheckDontShowNeedHVSI"]/*' />
    [NativeTypeName("#define navCheckDontShowNeedHVSI navReserved6")]
    public const BrowserNavConstants navCheckDontShowNeedHVSI = navReserved6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.navCheckDontShowHVSINeedHost"]/*' />
    [NativeTypeName("#define navCheckDontShowHVSINeedHost navReserved7")]
    public const BrowserNavConstants navCheckDontShowHVSINeedHost = navReserved7;
}
