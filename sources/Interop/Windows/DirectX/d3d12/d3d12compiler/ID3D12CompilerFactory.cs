// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory"]/*' />
[Guid("C1EE4B59-3F59-47A5-9B4E-A855C858A878")]
[NativeTypeName("struct ID3D12CompilerFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CompilerFactory : ID3D12CompilerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12CompilerFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, uint>)(lpVtbl[1]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, uint>)(lpVtbl[2]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.EnumerateAdapterFamilies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumerateAdapterFamilies(uint AdapterFamilyIndex, D3D12_ADAPTER_FAMILY* pAdapterFamily)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, uint, D3D12_ADAPTER_FAMILY*, int>)(lpVtbl[3]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), AdapterFamilyIndex, pAdapterFamily);
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.EnumerateAdapterFamilyABIVersions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, [NativeTypeName("UINT32 *")] uint* pNumABIVersions, [NativeTypeName("UINT64 *")] ulong* pABIVersions)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)(lpVtbl[4]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), AdapterFamilyIndex, pNumABIVersions, pABIVersions);
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.EnumerateAdapterFamilyCompilerVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumerateAdapterFamilyCompilerVersion(uint AdapterFamilyIndex, D3D12_VERSION_NUMBER* pCompilerVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, uint, D3D12_VERSION_NUMBER*, int>)(lpVtbl[5]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), AdapterFamilyIndex, pCompilerVersion);
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.GetApplicationProfileVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetApplicationProfileVersion([NativeTypeName("const D3D12_COMPILER_TARGET *")] D3D12_COMPILER_TARGET* pTarget, [NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, D3D12_VERSION_NUMBER* pApplicationProfileVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, D3D12_COMPILER_TARGET*, D3D12_APPLICATION_DESC*, D3D12_VERSION_NUMBER*, int>)(lpVtbl[6]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), pTarget, pApplicationDesc, pApplicationProfileVersion);
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.CreateCompilerCacheSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCompilerCacheSession([NativeTypeName("const D3D12_COMPILER_DATABASE_PATH *")] D3D12_COMPILER_DATABASE_PATH* pPaths, uint NumPaths, [NativeTypeName("const D3D12_COMPILER_TARGET *")] D3D12_COMPILER_TARGET* pTarget, [NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCompilerCacheSession)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, D3D12_COMPILER_DATABASE_PATH*, uint, D3D12_COMPILER_TARGET*, D3D12_APPLICATION_DESC*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), pPaths, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
    }

    /// <include file='ID3D12CompilerFactory.xml' path='doc/member[@name="ID3D12CompilerFactory.CreateCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, [NativeTypeName("const IID &")] Guid* riid, void** ppCompiler)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12CompilerFactory*)Unsafe.AsPointer(ref this), pCompilerCacheSession, riid, ppCompiler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumerateAdapterFamilies(uint AdapterFamilyIndex, D3D12_ADAPTER_FAMILY* pAdapterFamily);

        [VtblIndex(4)]
        HRESULT EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, [NativeTypeName("UINT32 *")] uint* pNumABIVersions, [NativeTypeName("UINT64 *")] ulong* pABIVersions);

        [VtblIndex(5)]
        HRESULT EnumerateAdapterFamilyCompilerVersion(uint AdapterFamilyIndex, D3D12_VERSION_NUMBER* pCompilerVersion);

        [VtblIndex(6)]
        HRESULT GetApplicationProfileVersion([NativeTypeName("const D3D12_COMPILER_TARGET *")] D3D12_COMPILER_TARGET* pTarget, [NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, D3D12_VERSION_NUMBER* pApplicationProfileVersion);

        [VtblIndex(7)]
        HRESULT CreateCompilerCacheSession([NativeTypeName("const D3D12_COMPILER_DATABASE_PATH *")] D3D12_COMPILER_DATABASE_PATH* pPaths, uint NumPaths, [NativeTypeName("const D3D12_COMPILER_TARGET *")] D3D12_COMPILER_TARGET* pTarget, [NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCompilerCacheSession);

        [VtblIndex(8)]
        HRESULT CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, [NativeTypeName("const IID &")] Guid* riid, void** ppCompiler);
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

        [NativeTypeName("HRESULT (UINT, D3D12_ADAPTER_FAMILY *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_ADAPTER_FAMILY*, int> EnumerateAdapterFamilies;

        [NativeTypeName("HRESULT (UINT, UINT32 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, ulong*, int> EnumerateAdapterFamilyABIVersions;

        [NativeTypeName("HRESULT (UINT, D3D12_VERSION_NUMBER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_VERSION_NUMBER*, int> EnumerateAdapterFamilyCompilerVersion;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_TARGET *, const D3D12_APPLICATION_DESC *, D3D12_VERSION_NUMBER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_TARGET*, D3D12_APPLICATION_DESC*, D3D12_VERSION_NUMBER*, int> GetApplicationProfileVersion;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_DATABASE_PATH *, UINT, const D3D12_COMPILER_TARGET *, const D3D12_APPLICATION_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_DATABASE_PATH*, uint, D3D12_COMPILER_TARGET*, D3D12_APPLICATION_DESC*, Guid*, void**, int> CreateCompilerCacheSession;

        [NativeTypeName("HRESULT (ID3D12CompilerCacheSession *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12CompilerCacheSession*, Guid*, void**, int> CreateCompiler;
    }
}
