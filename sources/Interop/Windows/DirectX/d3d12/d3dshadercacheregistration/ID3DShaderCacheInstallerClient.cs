// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheInstallerClient.xml' path='doc/member[@name="ID3DShaderCacheInstallerClient"]/*' />
[Guid("A16EE930-D9F6-4222-A514-244473E5D266")]
public unsafe partial struct ID3DShaderCacheInstallerClient : ID3DShaderCacheInstallerClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheInstallerClient);

    public void** lpVtbl;

    /// <include file='ID3DShaderCacheInstallerClient.xml' path='doc/member[@name="ID3DShaderCacheInstallerClient.GetInstallerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetInstallerName([NativeTypeName("SIZE_T *")] nuint* pNameLength, [NativeTypeName("wchar_t *")] char* pName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)(lpVtbl[0]))((ID3DShaderCacheInstallerClient*)Unsafe.AsPointer(ref this), pNameLength, pName);
    }

    /// <include file='ID3DShaderCacheInstallerClient.xml' path='doc/member[@name="ID3DShaderCacheInstallerClient.GetInstallerScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE GetInstallerScope()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerClient*, D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE>)(lpVtbl[1]))((ID3DShaderCacheInstallerClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstallerClient.xml' path='doc/member[@name="ID3DShaderCacheInstallerClient.HandleDriverUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT HandleDriverUpdate(ID3DShaderCacheInstaller* pInstaller)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerClient*, ID3DShaderCacheInstaller*, int>)(lpVtbl[2]))((ID3DShaderCacheInstallerClient*)Unsafe.AsPointer(ref this), pInstaller);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetInstallerName([NativeTypeName("SIZE_T *")] nuint* pNameLength, [NativeTypeName("wchar_t *")] char* pName);

        [VtblIndex(1)]
        D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE GetInstallerScope();

        [VtblIndex(2)]
        HRESULT HandleDriverUpdate(ID3DShaderCacheInstaller* pInstaller);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (SIZE_T *, wchar_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, char*, int> GetInstallerName;

        [NativeTypeName("D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE> GetInstallerScope;

        [NativeTypeName("HRESULT (ID3DShaderCacheInstaller *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3DShaderCacheInstaller*, int> HandleDriverUpdate;
    }
}
