// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher"]/*' />
[Guid("2F85CA29-0100-5D09-907C-FE554D2FCD1A")]
[NativeTypeName("struct ITransferTargetWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITransferTargetWatcher : ITransferTargetWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITransferTargetWatcher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, Guid*, void**, int>)(lpVtbl[0]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, uint>)(lpVtbl[1]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, uint>)(lpVtbl[2]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, HSTRING*, int>)(lpVtbl[4]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, TrustLevel*, int>)(lpVtbl[5]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, int>)(lpVtbl[6]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, int>)(lpVtbl[7]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.TransferToAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TransferToAsync([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ITransferTarget *")] ITransferTarget* target, [NativeTypeName("ABI::Windows::UI::WindowId")] WindowId parentWindowHandle, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetInvokeResult_double_t **")] IAsyncOperationWithProgress<Pointer<ITransferTargetInvokeResult>, double>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITransferTarget*, WindowId, IAsyncOperationWithProgress<Pointer<ITransferTargetInvokeResult>, double>**, int>)(lpVtbl[8]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), target, parentWindowHandle, operation);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, EventRegistrationToken, int>)(lpVtbl[10]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, EventRegistrationToken, int>)(lpVtbl[12]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.add_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.remove_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_Updated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, EventRegistrationToken, int>)(lpVtbl[14]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, EventRegistrationToken, int>)(lpVtbl[16]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITransferTargetWatcher.xml' path='doc/member[@name="ITransferTargetWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcher*, EventRegistrationToken, int>)(lpVtbl[18]))((ITransferTargetWatcher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT Stop();

        [VtblIndex(8)]
        HRESULT TransferToAsync([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ITransferTarget *")] ITransferTarget* target, [NativeTypeName("ABI::Windows::UI::WindowId")] WindowId parentWindowHandle, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetInvokeResult_double_t **")] IAsyncOperationWithProgress<Pointer<ITransferTargetInvokeResult>, double>** operation);

        [VtblIndex(9)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_Updated(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_Stopped(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ITransferTarget *, ABI::Windows::UI::WindowId, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetInvokeResult_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITransferTarget*, WindowId, IAsyncOperationWithProgress<Pointer<ITransferTargetInvokeResult>, double>**, int> TransferToAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_Windows__CApplicationModel__CDataTransfer__CTransferTargetChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<ITransferTargetChangedEventArgs>>*, EventRegistrationToken*, int> add_Updated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Updated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CTransferTargetWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITransferTargetWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;
    }
}
