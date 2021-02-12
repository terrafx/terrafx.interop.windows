// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B15B8DC1-C7E1-11D0-8680-00AA00BDCB71")]
    [NativeTypeName("struct ISoftDistExt : IUnknown")]
    public unsafe partial struct ISoftDistExt
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISoftDistExt*, Guid*, void**, int>)(lpVtbl[0]))((ISoftDistExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISoftDistExt*, uint>)(lpVtbl[1]))((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISoftDistExt*, uint>)(lpVtbl[2]))((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessSoftDist([NativeTypeName("LPCWSTR")] ushort* szCDFURL, [NativeTypeName("IXMLElement *")] IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort*, IXMLElement*, SOFTDISTINFO*, int>)(lpVtbl[3]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCDFURL, pSoftDistElement, lpsdi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFirstCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int>)(lpVtbl[4]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int>)(lpVtbl[5]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AsyncInstallDistributionUnit([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh)
        {
            return ((delegate* unmanaged<ISoftDistExt*, IBindCtx*, void*, uint, CODEBASEHOLD*, int>)(lpVtbl[6]))((ISoftDistExt*)Unsafe.AsPointer(ref this), pbc, pvReserved, flags, lpcbh);
        }
    }
}
