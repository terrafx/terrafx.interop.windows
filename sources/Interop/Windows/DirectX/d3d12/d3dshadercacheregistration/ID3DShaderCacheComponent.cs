// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent"]/*' />
[Guid("EED1BF00-F5C7-4CF7-885C-D0F9C0CB4828")]
[NativeTypeName("struct ID3DShaderCacheComponent : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DShaderCacheComponent : ID3DShaderCacheComponent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheComponent);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, Guid*, void**, int>)(lpVtbl[0]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, uint>)(lpVtbl[1]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, uint>)(lpVtbl[2]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent.GetComponentName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentName([NativeTypeName("const wchar_t **")] char** pName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, char**, int>)(lpVtbl[3]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this), pName);
    }

    /// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent.GetStateObjectDatabasePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStateObjectDatabasePath([NativeTypeName("const wchar_t **")] char** pPath)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, char**, int>)(lpVtbl[4]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this), pPath);
    }

    /// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent.GetPrecompiledCachePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrecompiledCachePath([NativeTypeName("const wchar_t *")] char* pAdapterFamily, [NativeTypeName("const wchar_t **")] char** pPath)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, char*, char**, int>)(lpVtbl[5]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this), pAdapterFamily, pPath);
    }

    /// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent.GetPrecompiledShaderDatabaseCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetPrecompiledShaderDatabaseCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, uint>)(lpVtbl[6]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheComponent.xml' path='doc/member[@name="ID3DShaderCacheComponent.GetPrecompiledShaderDatabases"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPrecompiledShaderDatabases(uint ArraySize, D3D_SHADER_CACHE_PSDB_PROPERTIES* pPSDBs)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheComponent*, uint, D3D_SHADER_CACHE_PSDB_PROPERTIES*, int>)(lpVtbl[7]))((ID3DShaderCacheComponent*)Unsafe.AsPointer(ref this), ArraySize, pPSDBs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetComponentName([NativeTypeName("const wchar_t **")] char** pName);

        [VtblIndex(4)]
        HRESULT GetStateObjectDatabasePath([NativeTypeName("const wchar_t **")] char** pPath);

        [VtblIndex(5)]
        HRESULT GetPrecompiledCachePath([NativeTypeName("const wchar_t *")] char* pAdapterFamily, [NativeTypeName("const wchar_t **")] char** pPath);

        [VtblIndex(6)]
        uint GetPrecompiledShaderDatabaseCount();

        [VtblIndex(7)]
        HRESULT GetPrecompiledShaderDatabases(uint ArraySize, D3D_SHADER_CACHE_PSDB_PROPERTIES* pPSDBs);
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

        [NativeTypeName("HRESULT (const wchar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetComponentName;

        [NativeTypeName("HRESULT (const wchar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetStateObjectDatabasePath;

        [NativeTypeName("HRESULT (const wchar_t *, const wchar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetPrecompiledCachePath;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPrecompiledShaderDatabaseCount;

        [NativeTypeName("HRESULT (UINT, D3D_SHADER_CACHE_PSDB_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D_SHADER_CACHE_PSDB_PROPERTIES*, int> GetPrecompiledShaderDatabases;
    }
}
