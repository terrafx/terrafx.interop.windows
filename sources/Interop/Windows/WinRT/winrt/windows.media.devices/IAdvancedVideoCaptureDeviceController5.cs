// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5"]/*' />
[Guid("33512B17-B9CB-4A23-B875-F9EAAB535492")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController5 : IAdvancedVideoCaptureDeviceController5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, HSTRING*, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5.GetDevicePropertyById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevicePropertyById(HSTRING propertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **")] IVideoDeviceControllerGetDevicePropertyResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, HSTRING, IReference<uint>*, IVideoDeviceControllerGetDevicePropertyResult**, int>)(lpVtbl[7]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), propertyId, maxPropertyValueSize, value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5.SetDevicePropertyById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDevicePropertyById(HSTRING propertyId, IInspectable* propertyValue, [NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *")] VideoDeviceControllerSetDevicePropertyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, HSTRING, IInspectable*, VideoDeviceControllerSetDevicePropertyStatus*, int>)(lpVtbl[8]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), propertyId, propertyValue, value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5.GetDevicePropertyByExtendedId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDevicePropertyByExtendedId([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **")] IVideoDeviceControllerGetDevicePropertyResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, uint, byte*, IReference<uint>*, IVideoDeviceControllerGetDevicePropertyResult**, int>)(lpVtbl[9]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), extendedPropertyIdLength, extendedPropertyId, maxPropertyValueSize, value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController5.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController5.SetDevicePropertyByExtendedId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDevicePropertyByExtendedId([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("UINT32")] uint propertyValueLength, byte* propertyValue, [NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *")] VideoDeviceControllerSetDevicePropertyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController5*, uint, byte*, uint, byte*, VideoDeviceControllerSetDevicePropertyStatus*, int>)(lpVtbl[10]))((IAdvancedVideoCaptureDeviceController5*)Unsafe.AsPointer(ref this), extendedPropertyIdLength, extendedPropertyId, propertyValueLength, propertyValue, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetDevicePropertyById(HSTRING propertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **")] IVideoDeviceControllerGetDevicePropertyResult** value);

        [VtblIndex(8)]
        HRESULT SetDevicePropertyById(HSTRING propertyId, IInspectable* propertyValue, [NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *")] VideoDeviceControllerSetDevicePropertyStatus* value);

        [VtblIndex(9)]
        HRESULT GetDevicePropertyByExtendedId([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **")] IVideoDeviceControllerGetDevicePropertyResult** value);

        [VtblIndex(10)]
        HRESULT SetDevicePropertyByExtendedId([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("UINT32")] uint propertyValueLength, byte* propertyValue, [NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *")] VideoDeviceControllerSetDevicePropertyStatus* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IReference<uint>*, IVideoDeviceControllerGetDevicePropertyResult**, int> GetDevicePropertyById;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *, ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable*, VideoDeviceControllerSetDevicePropertyStatus*, int> SetDevicePropertyById;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IReference<uint>*, IVideoDeviceControllerGetDevicePropertyResult**, int> GetDevicePropertyByExtendedId;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, VideoDeviceControllerSetDevicePropertyStatus*, int> SetDevicePropertyByExtendedId;
    }
}
