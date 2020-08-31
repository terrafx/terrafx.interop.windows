// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D2-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHttpNegotiate : IUnknown")]
    public unsafe partial struct IHttpNegotiate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IHttpNegotiate*, Guid*, void**, int>)(lpVtbl[0]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IHttpNegotiate*, uint>)(lpVtbl[1]))((IHttpNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IHttpNegotiate*, uint>)(lpVtbl[2]))((IHttpNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginningTransaction([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPCWSTR")] ushort* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalHeaders)
        {
            return ((delegate* stdcall<IHttpNegotiate*, ushort*, ushort*, uint, ushort**, int>)(lpVtbl[3]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] ushort* szResponseHeaders, [NativeTypeName("LPCWSTR")] ushort* szRequestHeaders, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalRequestHeaders)
        {
            return ((delegate* stdcall<IHttpNegotiate*, uint, ushort*, ushort*, ushort**, int>)(lpVtbl[4]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
        }
    }
}
