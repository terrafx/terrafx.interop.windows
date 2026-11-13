// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES"]/*' />
public partial struct WIA_PATCH_CODES
{
    /// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES.Tag"]/*' />
    [NativeTypeName("DWORD")]
    public uint Tag;

    /// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='WIA_PATCH_CODES.xml' path='doc/member[@name="WIA_PATCH_CODES.PatchCodes"]/*' />
    [NativeTypeName("WIA_PATCH_CODE_INFO[1]")]
    public _PatchCodes_e__FixedBuffer PatchCodes;

    /// <include file='_PatchCodes_e__FixedBuffer.xml' path='doc/member[@name="_PatchCodes_e__FixedBuffer"]/*' />
    public partial struct _PatchCodes_e__FixedBuffer
    {
        public WIA_PATCH_CODE_INFO e0;

        [UnscopedRef]
        public ref WIA_PATCH_CODE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WIA_PATCH_CODE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
