// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22320CB2-D41A-11D2-BF7C-D7CB9DF0BF93")]
    [NativeTypeName("struct IAMAudioRendererStats : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMAudioRendererStats
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAudioRendererStats*, Guid*, void**, int>)(lpVtbl[0]))((IAMAudioRendererStats*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAudioRendererStats*, uint>)(lpVtbl[1]))((IAMAudioRendererStats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAudioRendererStats*, uint>)(lpVtbl[2]))((IAMAudioRendererStats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStatParam([NativeTypeName("DWORD")] uint dwParam, [NativeTypeName("DWORD *")] uint* pdwParam1, [NativeTypeName("DWORD *")] uint* pdwParam2)
        {
            return ((delegate* unmanaged<IAMAudioRendererStats*, uint, uint*, uint*, int>)(lpVtbl[3]))((IAMAudioRendererStats*)Unsafe.AsPointer(ref this), dwParam, pdwParam1, pdwParam2);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAudioRendererStats*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAudioRendererStats*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAudioRendererStats*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAudioRendererStats*, uint, uint*, uint*, int> GetStatParam;
        }
    }
}
