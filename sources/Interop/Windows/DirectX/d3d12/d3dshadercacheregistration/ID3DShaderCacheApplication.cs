// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication"]/*' />
[Guid("FC688EE2-1B35-4913-93BE-1CA3FA7DF39E")]
[NativeTypeName("struct ID3DShaderCacheApplication : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DShaderCacheApplication : ID3DShaderCacheApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheApplication);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, Guid*, void**, int>)(lpVtbl[0]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, uint>)(lpVtbl[1]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, uint>)(lpVtbl[2]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetExePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetExePath([NativeTypeName("const wchar_t **")] char** pExePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, char**, int>)(lpVtbl[3]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), pExePath);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDesc(D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, D3D_SHADER_CACHE_APPLICATION_DESC*, int>)(lpVtbl[4]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), pApplicationDesc);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.RegisterComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterComponent([NativeTypeName("const wchar_t *")] char* pName, [NativeTypeName("const wchar_t *")] char* pStateObjectDBPath, uint NumPSDB, [NativeTypeName("const D3D_SHADER_CACHE_PSDB_PROPERTIES *")] D3D_SHADER_CACHE_PSDB_PROPERTIES* pPSDBs, [NativeTypeName("const IID &")] Guid* riid, void** ppvComponent)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, char*, char*, uint, D3D_SHADER_CACHE_PSDB_PROPERTIES*, Guid*, void**, int>)(lpVtbl[5]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), pName, pStateObjectDBPath, NumPSDB, pPSDBs, riid, ppvComponent);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.RemoveComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveComponent(ID3DShaderCacheComponent* pComponent)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, ID3DShaderCacheComponent*, int>)(lpVtbl[6]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), pComponent);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetComponentCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetComponentCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, uint>)(lpVtbl[7]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetComponent(uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvComponent)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, uint, Guid*, void**, int>)(lpVtbl[8]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), index, riid, ppvComponent);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetPrecompileTargetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetPrecompileTargetCount(D3D_SHADER_CACHE_TARGET_FLAGS flags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, D3D_SHADER_CACHE_TARGET_FLAGS, uint>)(lpVtbl[9]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), flags);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetPrecompileTargets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPrecompileTargets(uint ArraySize, D3D_SHADER_CACHE_COMPILER_PROPERTIES* pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, uint, D3D_SHADER_CACHE_COMPILER_PROPERTIES*, D3D_SHADER_CACHE_TARGET_FLAGS, int>)(lpVtbl[10]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), ArraySize, pArray, flags);
    }

    /// <include file='ID3DShaderCacheApplication.xml' path='doc/member[@name="ID3DShaderCacheApplication.GetInstallerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInstallerName([NativeTypeName("const wchar_t **")] char** pInstallerName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheApplication*, char**, int>)(lpVtbl[11]))((ID3DShaderCacheApplication*)Unsafe.AsPointer(ref this), pInstallerName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetExePath([NativeTypeName("const wchar_t **")] char** pExePath);

        [VtblIndex(4)]
        HRESULT GetDesc(D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc);

        [VtblIndex(5)]
        HRESULT RegisterComponent([NativeTypeName("const wchar_t *")] char* pName, [NativeTypeName("const wchar_t *")] char* pStateObjectDBPath, uint NumPSDB, [NativeTypeName("const D3D_SHADER_CACHE_PSDB_PROPERTIES *")] D3D_SHADER_CACHE_PSDB_PROPERTIES* pPSDBs, [NativeTypeName("const IID &")] Guid* riid, void** ppvComponent);

        [VtblIndex(6)]
        HRESULT RemoveComponent(ID3DShaderCacheComponent* pComponent);

        [VtblIndex(7)]
        uint GetComponentCount();

        [VtblIndex(8)]
        HRESULT GetComponent(uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvComponent);

        [VtblIndex(9)]
        uint GetPrecompileTargetCount(D3D_SHADER_CACHE_TARGET_FLAGS flags);

        [VtblIndex(10)]
        HRESULT GetPrecompileTargets(uint ArraySize, D3D_SHADER_CACHE_COMPILER_PROPERTIES* pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags);

        [VtblIndex(11)]
        HRESULT GetInstallerName([NativeTypeName("const wchar_t **")] char** pInstallerName);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetExePath;

        [NativeTypeName("HRESULT (D3D_SHADER_CACHE_APPLICATION_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D_SHADER_CACHE_APPLICATION_DESC*, int> GetDesc;

        [NativeTypeName("HRESULT (const wchar_t *, const wchar_t *, UINT, const D3D_SHADER_CACHE_PSDB_PROPERTIES *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, D3D_SHADER_CACHE_PSDB_PROPERTIES*, Guid*, void**, int> RegisterComponent;

        [NativeTypeName("HRESULT (ID3DShaderCacheComponent *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3DShaderCacheComponent*, int> RemoveComponent;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetComponentCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, void**, int> GetComponent;

        [NativeTypeName("UINT (D3D_SHADER_CACHE_TARGET_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D_SHADER_CACHE_TARGET_FLAGS, uint> GetPrecompileTargetCount;

        [NativeTypeName("HRESULT (UINT, D3D_SHADER_CACHE_COMPILER_PROPERTIES *, D3D_SHADER_CACHE_TARGET_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D_SHADER_CACHE_COMPILER_PROPERTIES*, D3D_SHADER_CACHE_TARGET_FLAGS, int> GetPrecompileTargets;

        [NativeTypeName("HRESULT (const wchar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetInstallerName;
    }
}
