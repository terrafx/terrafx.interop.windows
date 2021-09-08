// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E1-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetBindInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetBindInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetBindInfo*, Guid*, void**, int>)(lpVtbl[0]))((IInternetBindInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetBindInfo*, uint>)(lpVtbl[1]))((IInternetBindInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetBindInfo*, uint>)(lpVtbl[2]))((IInternetBindInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
        {
            return ((delegate* unmanaged<IInternetBindInfo*, uint*, BINDINFO*, int>)(lpVtbl[3]))((IInternetBindInfo*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] ushort** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched)
        {
            return ((delegate* unmanaged<IInternetBindInfo*, uint, ushort**, uint, uint*, int>)(lpVtbl[4]))((IInternetBindInfo*)Unsafe.AsPointer(ref this), ulStringType, ppwzStr, cEl, pcElFetched);
        }
    }
}
