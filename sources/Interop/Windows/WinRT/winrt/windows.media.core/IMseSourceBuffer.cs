// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer"]/*' />
[Guid("0C1AA3E3-DF8D-4079-A3FE-6849184B4E2F")]
[NativeTypeName("struct IMseSourceBuffer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMseSourceBuffer : IMseSourceBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMseSourceBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, uint>)(lpVtbl[1]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, uint>)(lpVtbl[2]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, uint*, Guid**, int>)(lpVtbl[3]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, HSTRING*, int>)(lpVtbl[4]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TrustLevel*, int>)(lpVtbl[5]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.add_UpdateStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_UpdateStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.remove_UpdateStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_UpdateStarting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, EventRegistrationToken, int>)(lpVtbl[7]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.add_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.remove_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Updated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, EventRegistrationToken, int>)(lpVtbl[9]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.add_UpdateEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_UpdateEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.remove_UpdateEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_UpdateEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, EventRegistrationToken, int>)(lpVtbl[11]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.add_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.remove_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_ErrorOccurred(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, EventRegistrationToken, int>)(lpVtbl[13]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.add_Aborted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_Aborted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.remove_Aborted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_Aborted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, EventRegistrationToken, int>)(lpVtbl[15]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Core::MseAppendMode *")] MseAppendMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, MseAppendMode*, int>)(lpVtbl[16]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Core::MseAppendMode")] MseAppendMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, MseAppendMode, int>)(lpVtbl[17]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_IsUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsUpdating([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, byte*, int>)(lpVtbl[18]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_Buffered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Buffered([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseTimeRange_t **")] IVectorView<MseTimeRange>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IVectorView<MseTimeRange>**, int>)(lpVtbl[19]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_TimestampOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TimestampOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TimeSpan*, int>)(lpVtbl[20]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.put_TimestampOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TimestampOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TimeSpan, int>)(lpVtbl[21]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_AppendWindowStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_AppendWindowStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TimeSpan*, int>)(lpVtbl[22]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.put_AppendWindowStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_AppendWindowStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TimeSpan, int>)(lpVtbl[23]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.get_AppendWindowEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_AppendWindowEnd([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IReference<TimeSpan>**, int>)(lpVtbl[24]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.put_AppendWindowEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_AppendWindowEnd([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IReference<TimeSpan>*, int>)(lpVtbl[25]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.AppendBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT AppendBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IBuffer*, int>)(lpVtbl[26]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.AppendStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT AppendStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IInputStream*, int>)(lpVtbl[27]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), stream);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.AppendStreamMaxSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT AppendStreamMaxSize([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("UINT64")] ulong maxSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, IInputStream*, ulong, int>)(lpVtbl[28]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), stream, maxSize);
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.Abort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, int>)(lpVtbl[29]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMseSourceBuffer.xml' path='doc/member[@name="IMseSourceBuffer.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan start, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* end)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseSourceBuffer*, TimeSpan, IReference<TimeSpan>*, int>)(lpVtbl[30]))((IMseSourceBuffer*)Unsafe.AsPointer(ref this), start, end);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_UpdateStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_UpdateStarting(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Updated(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_UpdateEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_UpdateEnded(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_ErrorOccurred(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_Aborted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_Aborted(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Core::MseAppendMode *")] MseAppendMode* value);

        [VtblIndex(17)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Core::MseAppendMode")] MseAppendMode value);

        [VtblIndex(18)]
        HRESULT get_IsUpdating([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_Buffered([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseTimeRange_t **")] IVectorView<MseTimeRange>** value);

        [VtblIndex(20)]
        HRESULT get_TimestampOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(21)]
        HRESULT put_TimestampOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(22)]
        HRESULT get_AppendWindowStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(23)]
        HRESULT put_AppendWindowStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(24)]
        HRESULT get_AppendWindowEnd([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(25)]
        HRESULT put_AppendWindowEnd([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(26)]
        HRESULT AppendBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer);

        [VtblIndex(27)]
        HRESULT AppendStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream);

        [VtblIndex(28)]
        HRESULT AppendStreamMaxSize([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("UINT64")] ulong maxSize);

        [VtblIndex(29)]
        HRESULT Abort();

        [VtblIndex(30)]
        HRESULT Remove([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan start, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* end);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_UpdateStarting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_UpdateStarting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Updated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Updated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_UpdateEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_UpdateEnded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ErrorOccurred;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseSourceBuffer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Aborted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Aborted;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MseAppendMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MseAppendMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MseAppendMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MseAppendMode, int> put_Mode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUpdating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CMseTimeRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<MseTimeRange>**, int> get_Buffered;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TimestampOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TimestampOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_AppendWindowStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_AppendWindowStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_AppendWindowEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_AppendWindowEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> AppendBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, int> AppendStream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, ulong, int> AppendStreamMaxSize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Abort;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, IReference<TimeSpan>*, int> Remove;
    }
}
