// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SizeInt32.xml' path='doc/member[@name="SizeInt32"]/*' />
public partial struct SizeInt32
{
    /// <include file='SizeInt32.xml' path='doc/member[@name="SizeInt32.Width"]/*' />
    [NativeTypeName("INT32")]
    public int Width;

    /// <include file='SizeInt32.xml' path='doc/member[@name="SizeInt32.Height"]/*' />
    [NativeTypeName("INT32")]
    public int Height;
}
