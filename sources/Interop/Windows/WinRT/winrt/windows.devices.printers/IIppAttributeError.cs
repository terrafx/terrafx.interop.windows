// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppAttributeError.xml' path='doc/member[@name="IIppAttributeError"]/*' />
[Guid("750FEDA1-9EEF-5C39-93E4-46149BBCEF27")]
[NativeTypeName("struct IIppAttributeError : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeError : IIppAttributeError.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppAttributeError));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, Guid*, void**, int>)(lpVtbl[0]))((IIppAttributeError*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, uint>)(lpVtbl[1]))((IIppAttributeError*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, uint>)(lpVtbl[2]))((IIppAttributeError*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, uint*, Guid**, int>)(lpVtbl[3]))((IIppAttributeError*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, HSTRING*, int>)(lpVtbl[4]))((IIppAttributeError*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, TrustLevel*, int>)(lpVtbl[5]))((IIppAttributeError*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppAttributeError.xml' path='doc/member[@name="IIppAttributeError.get_Reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Reason([NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeErrorReason *")] IppAttributeErrorReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, IppAttributeErrorReason*, int>)(lpVtbl[6]))((IIppAttributeError*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppAttributeError.xml' path='doc/member[@name="IIppAttributeError.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, HRESULT*, int>)(lpVtbl[7]))((IIppAttributeError*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppAttributeError.xml' path='doc/member[@name="IIppAttributeError.GetUnsupportedValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUnsupportedValues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IVectorView<Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeError*, IVectorView<Pointer<IIppAttributeValue>>**, int>)(lpVtbl[8]))((IIppAttributeError*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Reason([NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeErrorReason *")] IppAttributeErrorReason* value);

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(8)]
        HRESULT GetUnsupportedValues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IVectorView<Pointer<IIppAttributeValue>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IppAttributeErrorReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IppAttributeErrorReason*, int> get_Reason;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IIppAttributeValue>>**, int> GetUnsupportedValues;
    }
}
