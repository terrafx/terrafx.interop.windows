// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedPhotoControl.xml' path='doc/member[@name="IAdvancedPhotoControl"]/*' />
[Guid("C5B15486-9001-4682-9309-68EAE0080EEC")]
[NativeTypeName("struct IAdvancedPhotoControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedPhotoControl : IAdvancedPhotoControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdvancedPhotoControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, uint>)(lpVtbl[1]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, uint>)(lpVtbl[2]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedPhotoControl.xml' path='doc/member[@name="IAdvancedPhotoControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, byte*, int>)(lpVtbl[6]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedPhotoControl.xml' path='doc/member[@name="IAdvancedPhotoControl.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAdvancedPhotoMode_t **")] IVectorView<AdvancedPhotoMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, IVectorView<AdvancedPhotoMode>**, int>)(lpVtbl[7]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedPhotoControl.xml' path='doc/member[@name="IAdvancedPhotoControl.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::AdvancedPhotoMode *")] AdvancedPhotoMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, AdvancedPhotoMode*, int>)(lpVtbl[8]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedPhotoControl.xml' path='doc/member[@name="IAdvancedPhotoControl.Configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::IAdvancedPhotoCaptureSettings *")] IAdvancedPhotoCaptureSettings* settings)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoControl*, IAdvancedPhotoCaptureSettings*, int>)(lpVtbl[9]))((IAdvancedPhotoControl*)Unsafe.AsPointer(ref this), settings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAdvancedPhotoMode_t **")] IVectorView<AdvancedPhotoMode>** value);

        [VtblIndex(8)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::AdvancedPhotoMode *")] AdvancedPhotoMode* value);

        [VtblIndex(9)]
        HRESULT Configure([NativeTypeName("ABI::Windows::Media::Devices::IAdvancedPhotoCaptureSettings *")] IAdvancedPhotoCaptureSettings* settings);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAdvancedPhotoMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<AdvancedPhotoMode>**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AdvancedPhotoMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdvancedPhotoMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IAdvancedPhotoCaptureSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdvancedPhotoCaptureSettings*, int> Configure;
    }
}
