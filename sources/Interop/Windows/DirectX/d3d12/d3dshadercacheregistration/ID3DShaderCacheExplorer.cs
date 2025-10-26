// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DShaderCacheExplorer.xml' path='doc/member[@name="ID3DShaderCacheExplorer"]/*' />
[Guid("90432322-32F5-487F-9264-E9390FA58B2A")]
[NativeTypeName("struct ID3DShaderCacheExplorer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DShaderCacheExplorer : ID3DShaderCacheExplorer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3DShaderCacheExplorer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheExplorer*, Guid*, void**, int>)(lpVtbl[0]))((ID3DShaderCacheExplorer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheExplorer*, uint>)(lpVtbl[1]))((ID3DShaderCacheExplorer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheExplorer*, uint>)(lpVtbl[2]))((ID3DShaderCacheExplorer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DShaderCacheExplorer.xml' path='doc/member[@name="ID3DShaderCacheExplorer.GetApplicationFromExePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetApplicationFromExePath([NativeTypeName("const wchar_t *")] char* pFullExePath, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)(lpVtbl[3]))((ID3DShaderCacheExplorer*)Unsafe.AsPointer(ref this), pFullExePath, riid, ppvApp);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetApplicationFromExePath([NativeTypeName("const wchar_t *")] char* pFullExePath, [NativeTypeName("const IID &")] Guid* riid, void** ppvApp);
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

        [NativeTypeName("HRESULT (const wchar_t *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, void**, int> GetApplicationFromExePath;
    }
}
