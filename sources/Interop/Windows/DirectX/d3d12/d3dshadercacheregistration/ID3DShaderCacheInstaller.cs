// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller"]/*' />
[Guid("BBE30DE1-6318-4526-AE17-776693191BB4")]
[NativeTypeName("struct ID3DShaderCacheInstaller : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DShaderCacheInstaller : ID3DShaderCacheInstaller.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheInstaller);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, Guid*, void**, int>)(lpVtbl[0]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, uint>)(lpVtbl[1]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, uint>)(lpVtbl[2]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.RegisterDriverUpdateListener"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterDriverUpdateListener()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, int>)(lpVtbl[3]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.UnregisterDriverUpdateListener"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterDriverUpdateListener()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, int>)(lpVtbl[4]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.RegisterServiceDriverUpdateTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, SC_HANDLE, int>)(lpVtbl[5]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), hServiceHandle);
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.UnregisterServiceDriverUpdateTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, SC_HANDLE, int>)(lpVtbl[6]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), hServiceHandle);
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.RegisterApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterApplication([NativeTypeName("const wchar_t *")] char* pExePath, [NativeTypeName("const D3D_SHADER_CACHE_APPLICATION_DESC *")] D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, char*, D3D_SHADER_CACHE_APPLICATION_DESC*, Guid*, void**, int>)(lpVtbl[7]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), pExePath, pApplicationDesc, riid, ppvApp);
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.RemoveApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveApplication(ID3DShaderCacheApplication* pApplication)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, ID3DShaderCacheApplication*, int>)(lpVtbl[8]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), pApplication);
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.GetApplicationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetApplicationCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, uint>)(lpVtbl[9]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.GetApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetApplication(uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, uint, Guid*, void**, int>)(lpVtbl[10]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), index, riid, ppvApp);
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.ClearAllState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ClearAllState()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, int>)(lpVtbl[11]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.GetMaxPrecompileTargetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetMaxPrecompileTargetCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, uint>)(lpVtbl[12]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstaller.xml' path='doc/member[@name="ID3DShaderCacheInstaller.GetPrecompileTargets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPrecompileTargets([NativeTypeName("const D3D_SHADER_CACHE_APPLICATION_DESC *")] D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc, uint* pArraySize, D3D_SHADER_CACHE_COMPILER_PROPERTIES* pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstaller*, D3D_SHADER_CACHE_APPLICATION_DESC*, uint*, D3D_SHADER_CACHE_COMPILER_PROPERTIES*, D3D_SHADER_CACHE_TARGET_FLAGS, int>)(lpVtbl[13]))((ID3DShaderCacheInstaller*)Unsafe.AsPointer(ref this), pApplicationDesc, pArraySize, pArray, flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterDriverUpdateListener();

        [VtblIndex(4)]
        HRESULT UnregisterDriverUpdateListener();

        [VtblIndex(5)]
        HRESULT RegisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle);

        [VtblIndex(6)]
        HRESULT UnregisterServiceDriverUpdateTrigger(SC_HANDLE hServiceHandle);

        [VtblIndex(7)]
        HRESULT RegisterApplication([NativeTypeName("const wchar_t *")] char* pExePath, [NativeTypeName("const D3D_SHADER_CACHE_APPLICATION_DESC *")] D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp);

        [VtblIndex(8)]
        HRESULT RemoveApplication(ID3DShaderCacheApplication* pApplication);

        [VtblIndex(9)]
        uint GetApplicationCount();

        [VtblIndex(10)]
        HRESULT GetApplication(uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp);

        [VtblIndex(11)]
        HRESULT ClearAllState();

        [VtblIndex(12)]
        uint GetMaxPrecompileTargetCount();

        [VtblIndex(13)]
        HRESULT GetPrecompileTargets([NativeTypeName("const D3D_SHADER_CACHE_APPLICATION_DESC *")] D3D_SHADER_CACHE_APPLICATION_DESC* pApplicationDesc, uint* pArraySize, D3D_SHADER_CACHE_COMPILER_PROPERTIES* pArray, D3D_SHADER_CACHE_TARGET_FLAGS flags);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RegisterDriverUpdateListener;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnregisterDriverUpdateListener;

        [NativeTypeName("HRESULT (SC_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SC_HANDLE, int> RegisterServiceDriverUpdateTrigger;

        [NativeTypeName("HRESULT (SC_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SC_HANDLE, int> UnregisterServiceDriverUpdateTrigger;

        [NativeTypeName("HRESULT (const wchar_t *, const D3D_SHADER_CACHE_APPLICATION_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D3D_SHADER_CACHE_APPLICATION_DESC*, Guid*, void**, int> RegisterApplication;

        [NativeTypeName("HRESULT (ID3DShaderCacheApplication *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3DShaderCacheApplication*, int> RemoveApplication;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetApplicationCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, void**, int> GetApplication;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAllState;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetMaxPrecompileTargetCount;

        [NativeTypeName("HRESULT (const D3D_SHADER_CACHE_APPLICATION_DESC *, UINT *, D3D_SHADER_CACHE_COMPILER_PROPERTIES *, D3D_SHADER_CACHE_TARGET_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D_SHADER_CACHE_APPLICATION_DESC*, uint*, D3D_SHADER_CACHE_COMPILER_PROPERTIES*, D3D_SHADER_CACHE_TARGET_FLAGS, int> GetPrecompileTargets;
    }
}
