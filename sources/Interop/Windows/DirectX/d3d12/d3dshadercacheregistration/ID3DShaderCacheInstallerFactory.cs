// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheInstallerFactory.xml' path='doc/member[@name="ID3DShaderCacheInstallerFactory"]/*' />
[Guid("09B2DFE4-840F-401A-804C-0DD8AADC9E9F")]
[NativeTypeName("struct ID3DShaderCacheInstallerFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DShaderCacheInstallerFactory : ID3DShaderCacheInstallerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheInstallerFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerFactory*, Guid*, void**, int>)(lpVtbl[0]))((ID3DShaderCacheInstallerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerFactory*, uint>)(lpVtbl[1]))((ID3DShaderCacheInstallerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerFactory*, uint>)(lpVtbl[2]))((ID3DShaderCacheInstallerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheInstallerFactory.xml' path='doc/member[@name="ID3DShaderCacheInstallerFactory.CreateInstaller"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstaller(ID3DShaderCacheInstallerClient* pClient, [NativeTypeName("const IID &")] Guid* riid, void** ppvInstaller)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)(lpVtbl[3]))((ID3DShaderCacheInstallerFactory*)Unsafe.AsPointer(ref this), pClient, riid, ppvInstaller);
    }

    /// <include file='ID3DShaderCacheInstallerFactory.xml' path='doc/member[@name="ID3DShaderCacheInstallerFactory.CreateExplorer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateExplorer(IUnknown* pUnknown, [NativeTypeName("const IID &")] Guid* riid, void** ppvExplorer)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheInstallerFactory*, IUnknown*, Guid*, void**, int>)(lpVtbl[4]))((ID3DShaderCacheInstallerFactory*)Unsafe.AsPointer(ref this), pUnknown, riid, ppvExplorer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstaller(ID3DShaderCacheInstallerClient* pClient, [NativeTypeName("const IID &")] Guid* riid, void** ppvInstaller);

        [VtblIndex(4)]
        HRESULT CreateExplorer(IUnknown* pUnknown, [NativeTypeName("const IID &")] Guid* riid, void** ppvExplorer);
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

        [NativeTypeName("HRESULT (ID3DShaderCacheInstallerClient *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3DShaderCacheInstallerClient*, Guid*, void**, int> CreateInstaller;

        [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, Guid*, void**, int> CreateExplorer;
    }
}
