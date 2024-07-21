// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WhiteBalanceGain.xml' path='doc/member[@name="WhiteBalanceGain"]/*' />
public partial struct WhiteBalanceGain
{
    /// <include file='WhiteBalanceGain.xml' path='doc/member[@name="WhiteBalanceGain.R"]/*' />
    public double R;

    /// <include file='WhiteBalanceGain.xml' path='doc/member[@name="WhiteBalanceGain.G"]/*' />
    public double G;

    /// <include file='WhiteBalanceGain.xml' path='doc/member[@name="WhiteBalanceGain.B"]/*' />
    public double B;
}
