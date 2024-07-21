// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StereoscopicVideoPackingMode.xml' path='doc/member[@name="StereoscopicVideoPackingMode"]/*' />
public enum StereoscopicVideoPackingMode
{
    /// <include file='StereoscopicVideoPackingMode.xml' path='doc/member[@name="StereoscopicVideoPackingMode.StereoscopicVideoPackingMode_None"]/*' />
    StereoscopicVideoPackingMode_None = 0,

    /// <include file='StereoscopicVideoPackingMode.xml' path='doc/member[@name="StereoscopicVideoPackingMode.StereoscopicVideoPackingMode_SideBySide"]/*' />
    StereoscopicVideoPackingMode_SideBySide = 1,

    /// <include file='StereoscopicVideoPackingMode.xml' path='doc/member[@name="StereoscopicVideoPackingMode.StereoscopicVideoPackingMode_TopBottom"]/*' />
    StereoscopicVideoPackingMode_TopBottom = 2,
}
