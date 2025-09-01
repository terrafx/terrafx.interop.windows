// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteLauncherStatics.xml' path='doc/member[@name="IRemoteLauncherStatics"]/*' />
[Guid("D7DB7A93-A30C-48B7-9F21-051026A4E517")]
[NativeTypeName("struct IRemoteLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteLauncherStatics : IRemoteLauncherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteLauncherStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, uint>)(lpVtbl[1]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, uint>)(lpVtbl[2]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, HSTRING*, int>)(lpVtbl[4]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteLauncherStatics.xml' path='doc/member[@name="IRemoteLauncherStatics.LaunchUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchUriAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[6]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, operation);
    }

    /// <include file='IRemoteLauncherStatics.xml' path='doc/member[@name="IRemoteLauncherStatics.LaunchUriWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchUriWithOptionsAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IRemoteLauncherOptions*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[7]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, options, operation);
    }

    /// <include file='IRemoteLauncherStatics.xml' path='doc/member[@name="IRemoteLauncherStatics.LaunchUriWithDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteLauncherStatics*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IRemoteLauncherOptions*, IPropertySet*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[8]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, options, inputData, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchUriAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation);

        [VtblIndex(7)]
        HRESULT LaunchUriWithOptionsAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation);

        [VtblIndex(8)]
        HRESULT LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IRemoteSystemConnectionRequest* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IAsyncOperation<RemoteLaunchUriStatus>**, int> LaunchUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::IRemoteLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IRemoteLauncherOptions*, IAsyncOperation<RemoteLaunchUriStatus>**, int> LaunchUriWithOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::IRemoteLauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemConnectionRequest*, IUriRuntimeClass*, IRemoteLauncherOptions*, IPropertySet*, IAsyncOperation<RemoteLaunchUriStatus>**, int> LaunchUriWithDataAsync;
    }
}
