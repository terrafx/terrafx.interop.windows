// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B8E8BD60-0BFE-11D0-AF91-00AA00B67A42")]
    [NativeTypeName("struct IIPDVDec : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IIPDVDec
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IIPDVDec*, Guid*, void**, int>)(lpVtbl[0]))((IIPDVDec*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIPDVDec*, uint>)(lpVtbl[1]))((IIPDVDec*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIPDVDec*, uint>)(lpVtbl[2]))((IIPDVDec*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_IPDisplay(int* displayPix)
        {
            return ((delegate* unmanaged<IIPDVDec*, int*, int>)(lpVtbl[3]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_IPDisplay(int displayPix)
        {
            return ((delegate* unmanaged<IIPDVDec*, int, int>)(lpVtbl[4]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
        }
    }
}
