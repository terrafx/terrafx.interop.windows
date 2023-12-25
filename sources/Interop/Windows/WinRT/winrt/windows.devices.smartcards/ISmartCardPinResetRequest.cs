// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardPinResetRequest.xml' path='doc/member[@name="ISmartCardPinResetRequest"]/*' />
[Guid("12FE3C4D-5FB9-4E8E-9FF6-61F475124FEF")]
[NativeTypeName("struct ISmartCardPinResetRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardPinResetRequest : ISmartCardPinResetRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardPinResetRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, uint>)(lpVtbl[1]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, uint>)(lpVtbl[2]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardPinResetRequest.xml' path='doc/member[@name="ISmartCardPinResetRequest.get_Challenge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Challenge([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, IBuffer**, int>)(lpVtbl[6]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinResetRequest.xml' path='doc/member[@name="ISmartCardPinResetRequest.get_Deadline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, DateTime*, int>)(lpVtbl[7]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinResetRequest.xml' path='doc/member[@name="ISmartCardPinResetRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetDeferral **")] ISmartCardPinResetDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, ISmartCardPinResetDeferral**, int>)(lpVtbl[8]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardPinResetRequest.xml' path='doc/member[@name="ISmartCardPinResetRequest.SetResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetResponse([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinResetRequest*, IBuffer*, int>)(lpVtbl[9]))((ISmartCardPinResetRequest*)Unsafe.AsPointer(ref this), response);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Challenge([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetDeferral **")] ISmartCardPinResetDeferral** result);

        [VtblIndex(9)]
        HRESULT SetResponse([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Challenge;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_Deadline;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardPinResetDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardPinResetDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> SetResponse;
    }
}
