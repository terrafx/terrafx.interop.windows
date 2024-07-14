// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PointInt32.xml' path='doc/member[@name="PointInt32"]/*' />
public partial struct PointInt32
{
    /// <include file='PointInt32.xml' path='doc/member[@name="PointInt32.X"]/*' />
    [NativeTypeName("INT32")]
    public int X;

    /// <include file='PointInt32.xml' path='doc/member[@name="PointInt32.Y"]/*' />
    [NativeTypeName("INT32")]
    public int Y;
}
