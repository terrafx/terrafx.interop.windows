// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MouseDelta.xml' path='doc/member[@name="MouseDelta"]/*' />
public partial struct MouseDelta
{
    /// <include file='MouseDelta.xml' path='doc/member[@name="MouseDelta.X"]/*' />
    [NativeTypeName("INT32")]
    public int X;

    /// <include file='MouseDelta.xml' path='doc/member[@name="MouseDelta.Y"]/*' />
    [NativeTypeName("INT32")]
    public int Y;
}
