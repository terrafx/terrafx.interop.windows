// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD1EC3B3-8391-4FDB-A9E6-347C3CAAA7DD")]
    [NativeTypeName("struct IWinInetCacheHints : IUnknown")]
    public unsafe partial struct IWinInetCacheHints
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWinInetCacheHints*, Guid*, void**, int>)(lpVtbl[0]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWinInetCacheHints*, uint>)(lpVtbl[1]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWinInetCacheHints*, uint>)(lpVtbl[2]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* stdcall<IWinInetCacheHints*, ushort*, void*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
        }
    }
}
