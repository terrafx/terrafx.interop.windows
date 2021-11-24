// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("45E2B4AE-B1C3-11D0-B92F-00A0C90312E1")]
[NativeTypeName("struct IShellLinkDataList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellLinkDataList : IShellLinkDataList.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint>)(lpVtbl[1]))((IShellLinkDataList*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint>)(lpVtbl[2]))((IShellLinkDataList*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddDataBlock(void* pDataBlock)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, void*, int>)(lpVtbl[3]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), pDataBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CopyDataBlock([NativeTypeName("DWORD")] uint dwSig, void** ppDataBlock)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint, void**, int>)(lpVtbl[4]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwSig, ppDataBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveDataBlock([NativeTypeName("DWORD")] uint dwSig)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint, int>)(lpVtbl[5]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint*, int>)(lpVtbl[6]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellLinkDataList*, uint, int>)(lpVtbl[7]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddDataBlock(void* pDataBlock);

        [VtblIndex(4)]
        HRESULT CopyDataBlock([NativeTypeName("DWORD")] uint dwSig, void** ppDataBlock);

        [VtblIndex(5)]
        HRESULT RemoveDataBlock([NativeTypeName("DWORD")] uint dwSig);

        [VtblIndex(6)]
        HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(7)]
        HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint> Release;

        [NativeTypeName("HRESULT (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, void*, int> AddDataBlock;

        [NativeTypeName("HRESULT (DWORD, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint, void**, int> CopyDataBlock;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint, int> RemoveDataBlock;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IShellLinkDataList*, uint, int> SetFlags;
    }
}
