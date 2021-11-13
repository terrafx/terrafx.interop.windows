// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("41B68150-904C-4E17-A0BA-A438182E359D")]
    [NativeTypeName("struct IZoomEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IZoomEvents : IZoomEvents.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IZoomEvents*, Guid*, void**, int>)(lpVtbl[0]))((IZoomEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IZoomEvents*, uint>)(lpVtbl[1]))((IZoomEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IZoomEvents*, uint>)(lpVtbl[2]))((IZoomEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnZoomPercentChanged([NativeTypeName("ULONG")] uint ulZoomPercent)
        {
            return ((delegate* unmanaged<IZoomEvents*, uint, int>)(lpVtbl[3]))((IZoomEvents*)Unsafe.AsPointer(ref this), ulZoomPercent);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnZoomPercentChanged([NativeTypeName("ULONG")] uint ulZoomPercent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IZoomEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IZoomEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IZoomEvents*, uint> Release;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IZoomEvents*, uint, int> OnZoomPercentChanged;
        }
    }
}
