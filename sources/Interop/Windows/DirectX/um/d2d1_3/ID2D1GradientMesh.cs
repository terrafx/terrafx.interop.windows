// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID2D1GradientMesh.xml' path='doc/member[@name="ID2D1GradientMesh"]/*' />
[Guid("F292E401-C050-4CDE-83D7-04962D3B23C2")]
[NativeTypeName("struct ID2D1GradientMesh : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ID2D1GradientMesh : ID2D1GradientMesh.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID2D1GradientMesh);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, uint>)(lpVtbl[1]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, uint>)(lpVtbl[2]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public readonly void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientMesh*)Unsafe.AsPointer(in this), factory);
    }

    /// <include file='ID2D1GradientMesh.xml' path='doc/member[@name="ID2D1GradientMesh.GetPatchCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public readonly uint GetPatchCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, uint>)(lpVtbl[4]))((ID2D1GradientMesh*)Unsafe.AsPointer(in this));
    }

    /// <include file='ID2D1GradientMesh.xml' path='doc/member[@name="ID2D1GradientMesh.GetPatches"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public readonly HRESULT GetPatches([NativeTypeName("UINT32")] uint startIndex, D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1GradientMesh*, uint, D2D1_GRADIENT_MESH_PATCH*, uint, int>)(lpVtbl[5]))((ID2D1GradientMesh*)Unsafe.AsPointer(in this), startIndex, patches, patchesCount);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        uint GetPatchCount();

        [VtblIndex(5)]
        HRESULT GetPatches([NativeTypeName("UINT32")] uint startIndex, D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPatchCount;

        [NativeTypeName("HRESULT (UINT32, D2D1_GRADIENT_MESH_PATCH *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D2D1_GRADIENT_MESH_PATCH*, uint, int> GetPatches;
    }
}
