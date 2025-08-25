// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController3.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController3"]/*' />
[Guid("A98B8F34-EE0D-470C-B9F0-4229C4BBD089")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController3 : IAdvancedVideoCaptureDeviceController3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdvancedVideoCaptureDeviceController3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController3.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController3.get_VariablePhotoSequenceController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VariablePhotoSequenceController([NativeTypeName("ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **")] IVariablePhotoSequenceController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, IVariablePhotoSequenceController**, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController3.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController3.get_PhotoConfirmationControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PhotoConfirmationControl([NativeTypeName("ABI::Windows::Media::Devices::IPhotoConfirmationControl **")] IPhotoConfirmationControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, IPhotoConfirmationControl**, int>)(lpVtbl[7]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController3.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController3.get_ZoomControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ZoomControl([NativeTypeName("ABI::Windows::Media::Devices::IZoomControl **")] IZoomControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController3*, IZoomControl**, int>)(lpVtbl[8]))((IAdvancedVideoCaptureDeviceController3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VariablePhotoSequenceController([NativeTypeName("ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **")] IVariablePhotoSequenceController** value);

        [VtblIndex(7)]
        HRESULT get_PhotoConfirmationControl([NativeTypeName("ABI::Windows::Media::Devices::IPhotoConfirmationControl **")] IPhotoConfirmationControl** value);

        [VtblIndex(8)]
        HRESULT get_ZoomControl([NativeTypeName("ABI::Windows::Media::Devices::IZoomControl **")] IZoomControl** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IVariablePhotoSequenceController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVariablePhotoSequenceController**, int> get_VariablePhotoSequenceController;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IPhotoConfirmationControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhotoConfirmationControl**, int> get_PhotoConfirmationControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IZoomControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IZoomControl**, int> get_ZoomControl;
    }
}
