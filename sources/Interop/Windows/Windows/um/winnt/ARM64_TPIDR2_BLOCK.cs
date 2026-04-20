// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ARM64_TPIDR2_BLOCK.xml' path='doc/member[@name="ARM64_TPIDR2_BLOCK"]/*' />
public unsafe partial struct ARM64_TPIDR2_BLOCK
{
    /// <include file='ARM64_TPIDR2_BLOCK.xml' path='doc/member[@name="ARM64_TPIDR2_BLOCK.ZaSaveBuffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* ZaSaveBuffer;

    /// <include file='ARM64_TPIDR2_BLOCK.xml' path='doc/member[@name="ARM64_TPIDR2_BLOCK.NumZaSaveSlices"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumZaSaveSlices;

    /// <include file='ARM64_TPIDR2_BLOCK.xml' path='doc/member[@name="ARM64_TPIDR2_BLOCK.Reserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved1;

    /// <include file='ARM64_TPIDR2_BLOCK.xml' path='doc/member[@name="ARM64_TPIDR2_BLOCK.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;
}
