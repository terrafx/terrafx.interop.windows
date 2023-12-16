// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9"]/*' />
[Guid("2518526C-E789-4111-A7B9-47EF328D13E6")]
[NativeTypeName("struct IDirect3DVolumeTexture9 : IDirect3DBaseTexture9")]
[NativeInheritance("IDirect3DBaseTexture9")]
public unsafe partial struct IDirect3DVolumeTexture9 : IDirect3DVolumeTexture9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DVolumeTexture9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint>)(lpVtbl[1]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint>)(lpVtbl[2]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="IDirect3DResource9.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
    }

    /// <inheritdoc cref="IDirect3DResource9.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
    }

    /// <inheritdoc cref="IDirect3DResource9.FreePrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, Guid*, int>)(lpVtbl[6]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid);
    }

    /// <inheritdoc cref="IDirect3DResource9.SetPriority" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, uint>)(lpVtbl[7]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), PriorityNew);
    }

    /// <inheritdoc cref="IDirect3DResource9.GetPriority" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetPriority()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint>)(lpVtbl[8]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.PreLoad" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PreLoad()
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, void>)(lpVtbl[9]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3DRESOURCETYPE GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.SetLOD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("DWORD")]
    public uint SetLOD([NativeTypeName("DWORD")] uint LODNew)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, uint>)(lpVtbl[11]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), LODNew);
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.GetLOD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("DWORD")]
    public uint GetLOD()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint>)(lpVtbl[12]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.GetLevelCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("DWORD")]
    public uint GetLevelCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint>)(lpVtbl[13]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.SetAutoGenFilterType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAutoGenFilterType(D3DTEXTUREFILTERTYPE FilterType)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[14]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), FilterType);
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.GetAutoGenFilterType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public D3DTEXTUREFILTERTYPE GetAutoGenFilterType()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, D3DTEXTUREFILTERTYPE>)(lpVtbl[15]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DBaseTexture9.GenerateMipSubLevels" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void GenerateMipSubLevels()
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, void>)(lpVtbl[16]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9.GetLevelDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLevelDesc(uint Level, D3DVOLUME_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, D3DVOLUME_DESC*, int>)(lpVtbl[17]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, pDesc);
    }

    /// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9.GetVolumeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetVolumeLevel(uint Level, IDirect3DVolume9** ppVolumeLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)(lpVtbl[18]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, ppVolumeLevel);
    }

    /// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9.LockBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT LockBox(uint Level, D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, D3DLOCKED_BOX*, D3DBOX*, uint, int>)(lpVtbl[19]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, pLockedVolume, pBox, Flags);
    }

    /// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9.UnlockBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT UnlockBox(uint Level)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, uint, int>)(lpVtbl[20]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level);
    }

    /// <include file='IDirect3DVolumeTexture9.xml' path='doc/member[@name="IDirect3DVolumeTexture9.AddDirtyBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddDirtyBox([NativeTypeName("const D3DBOX *")] D3DBOX* pDirtyBox)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolumeTexture9*, D3DBOX*, int>)(lpVtbl[21]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), pDirtyBox);
    }

    public interface Interface : IDirect3DBaseTexture9.Interface
    {
        [VtblIndex(17)]
        HRESULT GetLevelDesc(uint Level, D3DVOLUME_DESC* pDesc);

        [VtblIndex(18)]
        HRESULT GetVolumeLevel(uint Level, IDirect3DVolume9** ppVolumeLevel);

        [VtblIndex(19)]
        HRESULT LockBox(uint Level, D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(20)]
        HRESULT UnlockBox(uint Level);

        [VtblIndex(21)]
        HRESULT AddDirtyBox([NativeTypeName("const D3DBOX *")] D3DBOX* pDirtyBox);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DDevice9**, int> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void*, uint, uint, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void*, uint*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> FreePrivateData;

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> SetPriority;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPriority;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> PreLoad;

        [NativeTypeName("D3DRESOURCETYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, D3DRESOURCETYPE> GetType;

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> SetLOD;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetLOD;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetLevelCount;

        [NativeTypeName("HRESULT (D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DTEXTUREFILTERTYPE, int> SetAutoGenFilterType;

        [NativeTypeName("D3DTEXTUREFILTERTYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DTEXTUREFILTERTYPE> GetAutoGenFilterType;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> GenerateMipSubLevels;

        [NativeTypeName("HRESULT (UINT, D3DVOLUME_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DVOLUME_DESC*, int> GetLevelDesc;

        [NativeTypeName("HRESULT (UINT, IDirect3DVolume9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DVolume9**, int> GetVolumeLevel;

        [NativeTypeName("HRESULT (UINT, D3DLOCKED_BOX *, const D3DBOX *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DLOCKED_BOX*, D3DBOX*, uint, int> LockBox;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> UnlockBox;

        [NativeTypeName("HRESULT (const D3DBOX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DBOX*, int> AddDirtyBox;
    }
}
