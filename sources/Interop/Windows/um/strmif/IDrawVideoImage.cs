// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("48EFB120-AB49-11D2-AED2-00A0C995E8D5")]
    public unsafe partial struct IDrawVideoImage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDrawVideoImage*, Guid*, void**, int>)(lpVtbl[0]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDrawVideoImage*, uint>)(lpVtbl[1]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDrawVideoImage*, uint>)(lpVtbl[2]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageBegin()
        {
            return ((delegate* stdcall<IDrawVideoImage*, int>)(lpVtbl[3]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageEnd()
        {
            return ((delegate* stdcall<IDrawVideoImage*, int>)(lpVtbl[4]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawVideoImageDraw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprcSrc, [NativeTypeName("LPRECT")] RECT* lprcDst)
        {
            return ((delegate* stdcall<IDrawVideoImage*, IntPtr, RECT*, RECT*, int>)(lpVtbl[5]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), hdc, lprcSrc, lprcDst);
        }
    }
}
