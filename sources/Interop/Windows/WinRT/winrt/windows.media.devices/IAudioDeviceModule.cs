// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule"]/*' />
[Guid("86CFAC36-47C1-4B33-9852-8773EC4BE123")]
[NativeTypeName("struct IAudioDeviceModule : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioDeviceModule : IAudioDeviceModule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioDeviceModule));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, Guid*, void**, int>)(lpVtbl[0]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint>)(lpVtbl[1]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint>)(lpVtbl[2]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, HSTRING*, int>)(lpVtbl[4]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, TrustLevel*, int>)(lpVtbl[5]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.get_ClassId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ClassId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, HSTRING*, int>)(lpVtbl[6]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, HSTRING*, int>)(lpVtbl[7]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.get_InstanceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InstanceId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint*, int>)(lpVtbl[8]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.get_MajorVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MajorVersion([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint*, int>)(lpVtbl[9]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.get_MinorVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinorVersion([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, uint*, int>)(lpVtbl[10]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioDeviceModule.xml' path='doc/member[@name="IAudioDeviceModule.SendCommandAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SendCommandAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* Command, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CDevices__CModuleCommandResult_t **")] IAsyncOperation<Pointer<IModuleCommandResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModule*, IBuffer*, IAsyncOperation<Pointer<IModuleCommandResult>>**, int>)(lpVtbl[11]))((IAudioDeviceModule*)Unsafe.AsPointer(ref this), Command, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ClassId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_InstanceId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_MajorVersion([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_MinorVersion([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT SendCommandAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* Command, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CDevices__CModuleCommandResult_t **")] IAsyncOperation<Pointer<IModuleCommandResult>>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ClassId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_InstanceId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MajorVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinorVersion;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CDevices__CModuleCommandResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IModuleCommandResult>>**, int> SendCommandAsync;
    }
}
