// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70BDDE00-C18E-11D0-A9CE-006097942311")]
    [NativeTypeName("struct IEncodingFilterFactory : IUnknown")]
    public unsafe partial struct IEncodingFilterFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEncodingFilterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEncodingFilterFactory*, uint>)(lpVtbl[1]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEncodingFilterFactory*, uint>)(lpVtbl[2]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindBestFilter([NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, DATAINFO info, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF)
        {
            return ((delegate* stdcall<IEncodingFilterFactory*, ushort*, ushort*, DATAINFO, IDataFilter**, int>)(lpVtbl[3]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, info, ppDF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFilter([NativeTypeName("LPCWSTR")] ushort* pwzCodeIn, [NativeTypeName("LPCWSTR")] ushort* pwzCodeOut, [NativeTypeName("IDataFilter **")] IDataFilter** ppDF)
        {
            return ((delegate* stdcall<IEncodingFilterFactory*, ushort*, ushort*, IDataFilter**, int>)(lpVtbl[4]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, ppDF);
        }
    }
}
