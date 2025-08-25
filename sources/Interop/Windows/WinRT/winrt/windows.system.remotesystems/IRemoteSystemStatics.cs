// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemStatics.xml' path='doc/member[@name="IRemoteSystemStatics"]/*' />
[Guid("A485B392-FF2B-4B47-BE62-743F2F140F30")]
[NativeTypeName("struct IRemoteSystemStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemStatics : IRemoteSystemStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, uint>)(lpVtbl[1]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, uint>)(lpVtbl[2]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemStatics.xml' path='doc/member[@name="IRemoteSystemStatics.FindByHostNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindByHostNameAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **")] IAsyncOperation<Pointer<IRemoteSystem>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, IHostName*, IAsyncOperation<Pointer<IRemoteSystem>>**, int>)(lpVtbl[6]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), hostName, operation);
    }

    /// <include file='IRemoteSystemStatics.xml' path='doc/member[@name="IRemoteSystemStatics.CreateWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, IRemoteSystemWatcher**, int>)(lpVtbl[7]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IRemoteSystemStatics.xml' path='doc/member[@name="IRemoteSystemStatics.CreateWatcherWithFilters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWatcherWithFilters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *")] IIterable<Pointer<IRemoteSystemFilter>>* filters, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, IIterable<Pointer<IRemoteSystemFilter>>*, IRemoteSystemWatcher**, int>)(lpVtbl[8]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), filters, result);
    }

    /// <include file='IRemoteSystemStatics.xml' path='doc/member[@name="IRemoteSystemStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **")] IAsyncOperation<RemoteSystemAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics*, IAsyncOperation<RemoteSystemAccessStatus>**, int>)(lpVtbl[9]))((IRemoteSystemStatics*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindByHostNameAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **")] IAsyncOperation<Pointer<IRemoteSystem>>** operation);

        [VtblIndex(7)]
        HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result);

        [VtblIndex(8)]
        HRESULT CreateWatcherWithFilters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *")] IIterable<Pointer<IRemoteSystemFilter>>* filters, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result);

        [VtblIndex(9)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **")] IAsyncOperation<RemoteSystemAccessStatus>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, IAsyncOperation<Pointer<IRemoteSystem>>**, int> FindByHostNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemWatcher**, int> CreateWatcher;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *, ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IRemoteSystemFilter>>*, IRemoteSystemWatcher**, int> CreateWatcherWithFilters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<RemoteSystemAccessStatus>**, int> RequestAccessAsync;
    }
}
