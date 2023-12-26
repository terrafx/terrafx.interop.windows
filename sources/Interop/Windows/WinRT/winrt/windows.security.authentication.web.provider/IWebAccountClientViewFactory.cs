// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountClientViewFactory.xml' path='doc/member[@name="IWebAccountClientViewFactory"]/*' />
[Guid("616D16A4-DE22-4855-A326-06CEBF2A3F23")]
[NativeTypeName("struct IWebAccountClientViewFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountClientViewFactory : IWebAccountClientViewFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountClientViewFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, uint>)(lpVtbl[1]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, uint>)(lpVtbl[2]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountClientViewFactory.xml' path='doc/member[@name="IWebAccountClientViewFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType")] WebAccountClientViewType viewType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **")] IWebAccountClientView** view)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, WebAccountClientViewType, IUriRuntimeClass*, IWebAccountClientView**, int>)(lpVtbl[6]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), viewType, applicationCallbackUri, view);
    }

    /// <include file='IWebAccountClientViewFactory.xml' path='doc/member[@name="IWebAccountClientViewFactory.CreateWithPairwiseId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithPairwiseId([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType")] WebAccountClientViewType viewType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, HSTRING accountPairwiseId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **")] IWebAccountClientView** view)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientViewFactory*, WebAccountClientViewType, IUriRuntimeClass*, HSTRING, IWebAccountClientView**, int>)(lpVtbl[7]))((IWebAccountClientViewFactory*)Unsafe.AsPointer(ref this), viewType, applicationCallbackUri, accountPairwiseId, view);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType")] WebAccountClientViewType viewType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **")] IWebAccountClientView** view);

        [VtblIndex(7)]
        HRESULT CreateWithPairwiseId([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType")] WebAccountClientViewType viewType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, HSTRING accountPairwiseId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **")] IWebAccountClientView** view);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAccountClientViewType, IUriRuntimeClass*, IWebAccountClientView**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAccountClientViewType, IUriRuntimeClass*, HSTRING, IWebAccountClientView**, int> CreateWithPairwiseId;
    }
}
