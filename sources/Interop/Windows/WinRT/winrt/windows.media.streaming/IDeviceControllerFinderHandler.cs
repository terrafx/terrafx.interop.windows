// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceControllerFinderHandler.xml' path='doc/member[@name="IDeviceControllerFinderHandler"]/*' />
[Guid("A88A7D06-988C-4403-9D8A-015BED140B34")]
[NativeTypeName("struct IDeviceControllerFinderHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceControllerFinderHandler : IDeviceControllerFinderHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceControllerFinderHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceControllerFinderHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceControllerFinderHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceControllerFinderHandler*, uint>)(lpVtbl[1]))((IDeviceControllerFinderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceControllerFinderHandler*, uint>)(lpVtbl[2]))((IDeviceControllerFinderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDeviceControllerFinderHandler.xml' path='doc/member[@name="IDeviceControllerFinderHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceController *")] IDeviceController* sender, HSTRING uniqueDeviceName, [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* device)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceControllerFinderHandler*, IDeviceController*, HSTRING, IBasicDevice*, int>)(lpVtbl[3]))((IDeviceControllerFinderHandler*)Unsafe.AsPointer(ref this), sender, uniqueDeviceName, device);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceController *")] IDeviceController* sender, HSTRING uniqueDeviceName, [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* device);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IDeviceController *, HSTRING, ABI::Windows::Media::Streaming::IBasicDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceController*, HSTRING, IBasicDevice*, int> Invoke;
    }
}
