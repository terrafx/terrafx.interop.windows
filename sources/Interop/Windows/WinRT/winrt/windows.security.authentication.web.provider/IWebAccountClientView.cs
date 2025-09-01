// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountClientView.xml' path='doc/member[@name="IWebAccountClientView"]/*' />
[Guid("E7BD66BA-0BC7-4C66-BFD4-65D3082CBCA8")]
[NativeTypeName("struct IWebAccountClientView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountClientView : IWebAccountClientView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAccountClientView);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, uint>)(lpVtbl[1]))((IWebAccountClientView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, uint>)(lpVtbl[2]))((IWebAccountClientView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountClientView.xml' path='doc/member[@name="IWebAccountClientView.get_ApplicationCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, IUriRuntimeClass**, int>)(lpVtbl[6]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccountClientView.xml' path='doc/member[@name="IWebAccountClientView.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType *")] WebAccountClientViewType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, WebAccountClientViewType*, int>)(lpVtbl[7]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccountClientView.xml' path='doc/member[@name="IWebAccountClientView.get_AccountPairwiseId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AccountPairwiseId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountClientView*, HSTRING*, int>)(lpVtbl[8]))((IWebAccountClientView*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(7)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType *")] WebAccountClientViewType* value);

        [VtblIndex(8)]
        HRESULT get_AccountPairwiseId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ApplicationCallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAccountClientViewType*, int> get_Type;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccountPairwiseId;
    }
}
