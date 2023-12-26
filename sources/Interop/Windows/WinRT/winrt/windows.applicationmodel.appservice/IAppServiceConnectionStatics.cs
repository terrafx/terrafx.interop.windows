// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppServiceConnectionStatics.xml' path='doc/member[@name="IAppServiceConnectionStatics"]/*' />
[Guid("ADC56CE9-D408-5673-8637-827A4B274168")]
[NativeTypeName("struct IAppServiceConnectionStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceConnectionStatics : IAppServiceConnectionStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppServiceConnectionStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, uint>)(lpVtbl[1]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, uint>)(lpVtbl[2]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppServiceConnectionStatics.xml' path='doc/member[@name="IAppServiceConnectionStatics.SendStatelessMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendStatelessMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")] IAppServiceConnection* connection, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* connectionRequest, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CStatelessAppServiceResponse_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnectionStatics*, IAppServiceConnection*, IRemoteSystemConnectionRequest*, IPropertySet*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAppServiceConnectionStatics*)Unsafe.AsPointer(ref this), connection, connectionRequest, message, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SendStatelessMessageAsync([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")] IAppServiceConnection* connection, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* connectionRequest, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CStatelessAppServiceResponse_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CStatelessAppServiceResponse_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppServiceConnection*, IRemoteSystemConnectionRequest*, IPropertySet*, IAsyncOperation<IntPtr>**, int> SendStatelessMessageAsync;
    }
}
