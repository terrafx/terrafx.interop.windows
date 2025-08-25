// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppUriHandlerRegistration.xml' path='doc/member[@name="IAppUriHandlerRegistration"]/*' />
[Guid("6F73AEB1-4569-5C3F-9BA0-99123EEA32C3")]
[NativeTypeName("struct IAppUriHandlerRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppUriHandlerRegistration : IAppUriHandlerRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppUriHandlerRegistration);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, HSTRING*, int>)(lpVtbl[4]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppUriHandlerRegistration.xml' path='doc/member[@name="IAppUriHandlerRegistration.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, HSTRING*, int>)(lpVtbl[6]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppUriHandlerRegistration.xml' path='doc/member[@name="IAppUriHandlerRegistration.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, IUser**, int>)(lpVtbl[7]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppUriHandlerRegistration.xml' path='doc/member[@name="IAppUriHandlerRegistration.GetAppAddedHostsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppUriHandlerHost>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, IAsyncOperation<Pointer<IVector<Pointer<IAppUriHandlerHost>>>>**, int>)(lpVtbl[8]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppUriHandlerRegistration.xml' path='doc/member[@name="IAppUriHandlerRegistration.SetAppAddedHostsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *")] IIterable<Pointer<IAppUriHandlerHost>>* hosts, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration*, IIterable<Pointer<IAppUriHandlerHost>>*, IAsyncAction**, int>)(lpVtbl[9]))((IAppUriHandlerRegistration*)Unsafe.AsPointer(ref this), hosts, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(8)]
        HRESULT GetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **")] IAsyncOperation<Pointer<IVector<Pointer<IAppUriHandlerHost>>>>** operation);

        [VtblIndex(9)]
        HRESULT SetAppAddedHostsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *")] IIterable<Pointer<IAppUriHandlerHost>>* hosts, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVector<Pointer<IAppUriHandlerHost>>>>**, int> GetAppAddedHostsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IAppUriHandlerHost>>*, IAsyncAction**, int> SetAppAddedHostsAsync;
    }
}
