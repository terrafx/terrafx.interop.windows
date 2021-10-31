// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6E0F9881-42A8-4F2A-97F8-8AF4E026D92D")]
    [NativeTypeName("struct IInitializeNetworkFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInitializeNetworkFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeNetworkFolder*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeNetworkFolder*, uint>)(lpVtbl[1]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeNetworkFolder*, uint>)(lpVtbl[2]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlTarget, uint uDisplayType, [NativeTypeName("LPCWSTR")] ushort* pszResName, [NativeTypeName("LPCWSTR")] ushort* pszProvider)
        {
            return ((delegate* unmanaged<IInitializeNetworkFolder*, ITEMIDLIST*, ITEMIDLIST*, uint, ushort*, ushort*, int>)(lpVtbl[3]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this), pidl, pidlTarget, uDisplayType, pszResName, pszProvider);
        }
    }
}
