// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl"]/*' />
[Guid("1CBA2C83-6CB6-5A04-A6FC-3BE7B33FF056")]
[NativeTypeName("struct IInfraredTorchControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInfraredTorchControl : IInfraredTorchControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInfraredTorchControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, Guid*, void**, int>)(lpVtbl[0]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, uint>)(lpVtbl[1]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, uint>)(lpVtbl[2]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, uint*, Guid**, int>)(lpVtbl[3]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, HSTRING*, int>)(lpVtbl[4]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, TrustLevel*, int>)(lpVtbl[5]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, byte*, int>)(lpVtbl[6]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **")] IVectorView<InfraredTorchMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, IVectorView<InfraredTorchMode>**, int>)(lpVtbl[7]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_CurrentMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode *")] InfraredTorchMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, InfraredTorchMode*, int>)(lpVtbl[8]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.put_CurrentMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode")] InfraredTorchMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, InfraredTorchMode, int>)(lpVtbl[9]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_MinPower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinPower([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, int*, int>)(lpVtbl[10]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_MaxPower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxPower([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, int*, int>)(lpVtbl[11]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_PowerStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PowerStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, int*, int>)(lpVtbl[12]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.get_Power"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Power([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, int*, int>)(lpVtbl[13]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInfraredTorchControl.xml' path='doc/member[@name="IInfraredTorchControl.put_Power"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Power([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInfraredTorchControl*, int, int>)(lpVtbl[14]))((IInfraredTorchControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **")] IVectorView<InfraredTorchMode>** value);

        [VtblIndex(8)]
        HRESULT get_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode *")] InfraredTorchMode* value);

        [VtblIndex(9)]
        HRESULT put_CurrentMode([NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode")] InfraredTorchMode value);

        [VtblIndex(10)]
        HRESULT get_MinPower([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_MaxPower([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_PowerStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_Power([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT put_Power([NativeTypeName("INT32")] int value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<InfraredTorchMode>**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::InfraredTorchMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InfraredTorchMode*, int> get_CurrentMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::InfraredTorchMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InfraredTorchMode, int> put_CurrentMode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MinPower;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxPower;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PowerStep;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Power;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_Power;
    }
}
