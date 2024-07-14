// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebProviderErrorFactory.xml' path='doc/member[@name="IWebProviderErrorFactory"]/*' />
[Guid("E3C40A2D-89EF-4E37-847F-A8B9D5A32910")]
[NativeTypeName("struct IWebProviderErrorFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebProviderErrorFactory : IWebProviderErrorFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebProviderErrorFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, uint>)(lpVtbl[1]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, uint>)(lpVtbl[2]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebProviderErrorFactory.xml' path='doc/member[@name="IWebProviderErrorFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("UINT32")] uint errorCode, HSTRING errorMessage, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** webProviderError)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderErrorFactory*, uint, HSTRING, IWebProviderError**, int>)(lpVtbl[6]))((IWebProviderErrorFactory*)Unsafe.AsPointer(ref this), errorCode, errorMessage, webProviderError);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("UINT32")] uint errorCode, HSTRING errorMessage, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** webProviderError);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING, IWebProviderError**, int> Create;
    }
}
