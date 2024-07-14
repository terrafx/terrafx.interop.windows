// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MseAppendMode.xml' path='doc/member[@name="MseAppendMode"]/*' />
public enum MseAppendMode
{
    /// <include file='MseAppendMode.xml' path='doc/member[@name="MseAppendMode.MseAppendMode_Segments"]/*' />
    MseAppendMode_Segments = 0,

    /// <include file='MseAppendMode.xml' path='doc/member[@name="MseAppendMode.MseAppendMode_Sequence"]/*' />
    MseAppendMode_Sequence = 1,
}
