// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2DD74950-A890-11D1-ABE8-00A0C905F375")]
    [NativeTypeName("struct IAMFilterMiscFlags : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMFilterMiscFlags : IAMFilterMiscFlags.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMFilterMiscFlags*, Guid*, void**, int>)(lpVtbl[0]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMFilterMiscFlags*, uint>)(lpVtbl[1]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMFilterMiscFlags*, uint>)(lpVtbl[2]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("ULONG")]
        public uint GetMiscFlags()
        {
            return ((delegate* unmanaged<IAMFilterMiscFlags*, uint>)(lpVtbl[3]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("ULONG")]
            uint GetMiscFlags();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMFilterMiscFlags*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMFilterMiscFlags*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMFilterMiscFlags*, uint> Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMFilterMiscFlags*, uint> GetMiscFlags;
        }
    }
}
