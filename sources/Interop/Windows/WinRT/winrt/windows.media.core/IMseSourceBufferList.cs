// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList"]/*' />
[Guid("95FAE8E7-A8E7-4EBF-8927-145E940BA511")]
[NativeTypeName("struct IMseSourceBufferList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMseSourceBufferList : IMseSourceBufferList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMseSourceBufferList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, Guid*, void**, int>)(lpVtbl[0]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, uint>)(lpVtbl[1]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, uint>)(lpVtbl[2]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, uint*, Guid**, int>)(lpVtbl[3]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, HSTRING*, int>)(lpVtbl[4]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, TrustLevel*, int>)(lpVtbl[5]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList.add_SourceBufferAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SourceBufferAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *")] ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList.remove_SourceBufferAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SourceBufferAdded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, EventRegistrationToken, int>)(lpVtbl[7]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList.add_SourceBufferRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_SourceBufferRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *")] ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList.remove_SourceBufferRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_SourceBufferRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, EventRegistrationToken, int>)(lpVtbl[9]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBufferList.xml' path='doc/member[@name="IMseSourceBufferList.get_Buffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Buffers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseSourceBuffer_t **")] IVectorView<Pointer<IMseSourceBuffer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBufferList*, IVectorView<Pointer<IMseSourceBuffer>>**, int>)(lpVtbl[10]))((IMseSourceBufferList*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SourceBufferAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *")] ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SourceBufferAdded(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_SourceBufferRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *")] ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_SourceBufferRemoved(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_Buffers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseSourceBuffer_t **")] IVectorView<Pointer<IMseSourceBuffer>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SourceBufferAdded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SourceBufferAdded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBufferList_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMseSourceBufferList>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SourceBufferRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SourceBufferRemoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseSourceBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMseSourceBuffer>>**, int> get_Buffers;
    }
}
