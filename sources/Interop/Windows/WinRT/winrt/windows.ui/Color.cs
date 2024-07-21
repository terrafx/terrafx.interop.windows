// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Color.xml' path='doc/member[@name="Color"]/*' />
public partial struct Color
{
    /// <include file='Color.xml' path='doc/member[@name="Color.A"]/*' />
    public byte A;

    /// <include file='Color.xml' path='doc/member[@name="Color.R"]/*' />
    public byte R;

    /// <include file='Color.xml' path='doc/member[@name="Color.G"]/*' />
    public byte G;

    /// <include file='Color.xml' path='doc/member[@name="Color.B"]/*' />
    public byte B;
}
