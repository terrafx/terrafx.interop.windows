// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INotificationDataFactory.xml' path='doc/member[@name="INotificationDataFactory"]/*' />
[Guid("23C1E33A-1C10-46FB-8040-DEC384621CF8")]
[NativeTypeName("struct INotificationDataFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INotificationDataFactory : INotificationDataFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INotificationDataFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, Guid*, void**, int>)(lpVtbl[0]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, uint>)(lpVtbl[1]))((INotificationDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, uint>)(lpVtbl[2]))((INotificationDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, uint*, Guid**, int>)(lpVtbl[3]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, HSTRING*, int>)(lpVtbl[4]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, TrustLevel*, int>)(lpVtbl[5]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INotificationDataFactory.xml' path='doc/member[@name="INotificationDataFactory.CreateNotificationDataWithValuesAndSequenceNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNotificationDataWithValuesAndSequenceNumber([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>* initialValues, [NativeTypeName("UINT32")] uint sequenceNumber, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>*, uint, INotificationData**, int>)(lpVtbl[6]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), initialValues, sequenceNumber, value);
    }

    /// <include file='INotificationDataFactory.xml' path='doc/member[@name="INotificationDataFactory.CreateNotificationDataWithValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateNotificationDataWithValues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>* initialValues, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationDataFactory*, IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>*, INotificationData**, int>)(lpVtbl[7]))((INotificationDataFactory*)Unsafe.AsPointer(ref this), initialValues, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateNotificationDataWithValuesAndSequenceNumber([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>* initialValues, [NativeTypeName("UINT32")] uint sequenceNumber, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value);

        [VtblIndex(7)]
        HRESULT CreateNotificationDataWithValues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>* initialValues, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")] INotificationData** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *, UINT32, ABI::Windows::UI::Notifications::INotificationData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>*, uint, INotificationData**, int> CreateNotificationDataWithValuesAndSequenceNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_HSTRING_t *, ABI::Windows::UI::Notifications::INotificationData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, HSTRING>>>*, INotificationData**, int> CreateNotificationDataWithValues;
    }
}
