// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D8-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IWinInetHttpInfo : IWinInetInfo")]
    public unsafe partial struct IWinInetHttpInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWinInetHttpInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWinInetHttpInfo*, uint>)(lpVtbl[1]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWinInetHttpInfo*, uint>)(lpVtbl[2]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf)
        {
            return ((delegate* stdcall<IWinInetHttpInfo*, uint, void*, uint*, int>)(lpVtbl[3]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInfo([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* stdcall<IWinInetHttpInfo*, uint, void*, uint*, uint*, uint*, int>)(lpVtbl[4]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf, pdwFlags, pdwReserved);
        }
    }
}
