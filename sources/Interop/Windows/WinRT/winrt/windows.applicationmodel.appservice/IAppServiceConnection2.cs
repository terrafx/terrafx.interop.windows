// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppServiceConnection2.xml' path='doc/member[@name="IAppServiceConnection2"]/*' />
[Guid("8BDFCD5F-2302-4FBD-8061-52511C2F8BF9")]
[NativeTypeName("struct IAppServiceConnection2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceConnection2 : IAppServiceConnection2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppServiceConnection2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, uint>)(lpVtbl[1]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, uint>)(lpVtbl[2]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, HSTRING*, int>)(lpVtbl[4]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, TrustLevel*, int>)(lpVtbl[5]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppServiceConnection2.xml' path='doc/member[@name="IAppServiceConnection2.OpenRemoteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenRemoteAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **")] IAsyncOperation<AppServiceConnectionStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, IRemoteSystemConnectionRequest*, IAsyncOperation<AppServiceConnectionStatus>**, int>)(lpVtbl[6]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, operation);
    }

    /// <include file='IAppServiceConnection2.xml' path='doc/member[@name="IAppServiceConnection2.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, IUser**, int>)(lpVtbl[7]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceConnection2.xml' path='doc/member[@name="IAppServiceConnection2.put_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_User([NativeTypeName("ABI::Windows::System::IUser *")] IUser* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection2*, IUser*, int>)(lpVtbl[8]))((IAppServiceConnection2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenRemoteAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **")] IAsyncOperation<AppServiceConnectionStatus>** operation);

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(8)]
        HRESULT put_User([NativeTypeName("ABI::Windows::System::IUser *")] IUser* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemConnectionRequest*, IAsyncOperation<AppServiceConnectionStatus>**, int> OpenRemoteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, int> put_User;
    }
}
