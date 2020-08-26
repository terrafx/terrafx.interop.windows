// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B8E8BD60-0BFE-11D0-AF91-00AA00B67A42")]
    [NativeTypeName("struct IIPDVDec : IUnknown")]
    public unsafe partial struct IIPDVDec
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IIPDVDec*, Guid*, void**, int>)(lpVtbl[0]))((IIPDVDec*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IIPDVDec*, uint>)(lpVtbl[1]))((IIPDVDec*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IIPDVDec*, uint>)(lpVtbl[2]))((IIPDVDec*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IPDisplay([NativeTypeName("int *")] int* displayPix)
        {
            return ((delegate* stdcall<IIPDVDec*, int*, int>)(lpVtbl[3]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IPDisplay(int displayPix)
        {
            return ((delegate* stdcall<IIPDVDec*, int, int>)(lpVtbl[4]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
        }
    }
}
