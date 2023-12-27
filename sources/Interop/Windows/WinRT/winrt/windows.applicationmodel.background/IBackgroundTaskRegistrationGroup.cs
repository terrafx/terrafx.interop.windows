// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup"]/*' />
[Guid("2AB1919A-871B-4167-8A76-055CD67B5B23")]
[NativeTypeName("struct IBackgroundTaskRegistrationGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistrationGroup : IBackgroundTaskRegistrationGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskRegistrationGroup));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, uint>)(lpVtbl[1]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, uint>)(lpVtbl[2]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, HSTRING*, int>)(lpVtbl[6]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, HSTRING*, int>)(lpVtbl[7]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup.add_BackgroundActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_BackgroundActivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *")] ITypedEventHandler<Pointer<IBackgroundTaskRegistrationGroup>, Pointer<IBackgroundActivatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, ITypedEventHandler<Pointer<IBackgroundTaskRegistrationGroup>, Pointer<IBackgroundActivatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup.remove_BackgroundActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_BackgroundActivated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, EventRegistrationToken, int>)(lpVtbl[9]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBackgroundTaskRegistrationGroup.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroup.get_AllTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllTasks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistration_t **")] IMapView<Guid, Pointer<IBackgroundTaskRegistration>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroup*, IMapView<Guid, Pointer<IBackgroundTaskRegistration>>**, int>)(lpVtbl[10]))((IBackgroundTaskRegistrationGroup*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        HRESULT add_BackgroundActivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *")] ITypedEventHandler<Pointer<IBackgroundTaskRegistrationGroup>, Pointer<IBackgroundActivatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_BackgroundActivated(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_AllTasks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistration_t **")] IMapView<Guid, Pointer<IBackgroundTaskRegistration>>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBackgroundTaskRegistrationGroup>, Pointer<IBackgroundActivatedEventArgs>>*, EventRegistrationToken*, int> add_BackgroundActivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BackgroundActivated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistration_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<Guid, Pointer<IBackgroundTaskRegistration>>**, int> get_AllTasks;
    }
}
