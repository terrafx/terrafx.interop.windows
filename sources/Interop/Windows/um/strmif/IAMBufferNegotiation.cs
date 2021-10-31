// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56ED71A0-AF5F-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMBufferNegotiation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMBufferNegotiation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMBufferNegotiation*, Guid*, void**, int>)(lpVtbl[0]))((IAMBufferNegotiation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMBufferNegotiation*, uint>)(lpVtbl[1]))((IAMBufferNegotiation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMBufferNegotiation*, uint>)(lpVtbl[2]))((IAMBufferNegotiation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SuggestAllocatorProperties([NativeTypeName("const ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pprop)
        {
            return ((delegate* unmanaged<IAMBufferNegotiation*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IAMBufferNegotiation*)Unsafe.AsPointer(ref this), pprop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAllocatorProperties(ALLOCATOR_PROPERTIES* pprop)
        {
            return ((delegate* unmanaged<IAMBufferNegotiation*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IAMBufferNegotiation*)Unsafe.AsPointer(ref this), pprop);
        }
    }
}
