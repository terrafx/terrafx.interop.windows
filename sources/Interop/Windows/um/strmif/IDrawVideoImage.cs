// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("48EFB120-AB49-11D2-AED2-00A0C995E8D5")]
    [NativeTypeName("struct IDrawVideoImage : IUnknown")]
    public unsafe partial struct IDrawVideoImage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, Guid*, void**, int>)(lpVtbl[0]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, uint>)(lpVtbl[1]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, uint>)(lpVtbl[2]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageBegin()
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, int>)(lpVtbl[3]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageEnd()
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, int>)(lpVtbl[4]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageDraw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprcSrc, [NativeTypeName("LPRECT")] RECT* lprcDst)
        {
            return ((delegate* unmanaged[Stdcall]<IDrawVideoImage*, IntPtr, RECT*, RECT*, int>)(lpVtbl[5]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), hdc, lprcSrc, lprcDst);
        }
    }
}
