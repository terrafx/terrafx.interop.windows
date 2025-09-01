// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4"]/*' />
[Guid("EBA66290-AD6D-5899-BDDA-81BFE9F999A1")]
[NativeTypeName("struct IVoipPhoneCall4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipPhoneCall4 : IVoipPhoneCall4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVoipPhoneCall4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, Guid*, void**, int>)(lpVtbl[0]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, uint>)(lpVtbl[1]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, uint>)(lpVtbl[2]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, HSTRING*, int>)(lpVtbl[4]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, TrustLevel*, int>)(lpVtbl[5]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.get_IsUsingAssociatedDevicesList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsUsingAssociatedDevicesList([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, byte*, int>)(lpVtbl[6]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.NotifyCallActiveOnDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NotifyCallActiveOnDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, IIterable<HSTRING>*, int>)(lpVtbl[7]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), associatedDeviceIds);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.AddAssociatedCallControlDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddAssociatedCallControlDevice(HSTRING deviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, HSTRING, int>)(lpVtbl[8]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), deviceId);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.RemoveAssociatedCallControlDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAssociatedCallControlDevice(HSTRING deviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, HSTRING, int>)(lpVtbl[9]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), deviceId);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.SetAssociatedCallControlDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAssociatedCallControlDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, IIterable<HSTRING>*, int>)(lpVtbl[10]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), associatedDeviceIds);
    }

    /// <include file='IVoipPhoneCall4.xml' path='doc/member[@name="IVoipPhoneCall4.GetAssociatedCallControlDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAssociatedCallControlDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall4*, IVectorView<HSTRING>**, int>)(lpVtbl[11]))((IVoipPhoneCall4*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsUsingAssociatedDevicesList([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT NotifyCallActiveOnDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds);

        [VtblIndex(8)]
        HRESULT AddAssociatedCallControlDevice(HSTRING deviceId);

        [VtblIndex(9)]
        HRESULT RemoveAssociatedCallControlDevice(HSTRING deviceId);

        [VtblIndex(10)]
        HRESULT SetAssociatedCallControlDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds);

        [VtblIndex(11)]
        HRESULT GetAssociatedCallControlDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUsingAssociatedDevicesList;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, int> NotifyCallActiveOnDevices;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AddAssociatedCallControlDevice;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveAssociatedCallControlDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, int> SetAssociatedCallControlDevices;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> GetAssociatedCallControlDevices;
    }
}
