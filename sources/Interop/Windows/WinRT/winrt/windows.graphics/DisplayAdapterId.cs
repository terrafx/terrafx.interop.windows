// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DisplayAdapterId.xml' path='doc/member[@name="DisplayAdapterId"]/*' />
public partial struct DisplayAdapterId
{
    /// <include file='DisplayAdapterId.xml' path='doc/member[@name="DisplayAdapterId.LowPart"]/*' />
    [NativeTypeName("UINT32")]
    public uint LowPart;

    /// <include file='DisplayAdapterId.xml' path='doc/member[@name="DisplayAdapterId.HighPart"]/*' />
    [NativeTypeName("INT32")]
    public int HighPart;
}
