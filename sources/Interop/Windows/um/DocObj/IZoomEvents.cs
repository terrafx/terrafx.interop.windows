// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41B68150-904C-4E17-A0BA-A438182E359D")]
    [NativeTypeName("struct IZoomEvents : IUnknown")]
    public unsafe partial struct IZoomEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IZoomEvents*, Guid*, void**, int>)(lpVtbl[0]))((IZoomEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IZoomEvents*, uint>)(lpVtbl[1]))((IZoomEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IZoomEvents*, uint>)(lpVtbl[2]))((IZoomEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnZoomPercentChanged([NativeTypeName("ULONG")] uint ulZoomPercent)
        {
            return ((delegate* unmanaged<IZoomEvents*, uint, int>)(lpVtbl[3]))((IZoomEvents*)Unsafe.AsPointer(ref this), ulZoomPercent);
        }
    }
}
