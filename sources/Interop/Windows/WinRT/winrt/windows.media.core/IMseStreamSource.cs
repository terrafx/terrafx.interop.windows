// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource"]/*' />
[Guid("B0B4198D-02F4-4923-88DD-81BC3F360FFA")]
[NativeTypeName("struct IMseStreamSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMseStreamSource : IMseStreamSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMseStreamSource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, Guid*, void**, int>)(lpVtbl[0]))((IMseStreamSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, uint>)(lpVtbl[1]))((IMseStreamSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, uint>)(lpVtbl[2]))((IMseStreamSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, uint*, Guid**, int>)(lpVtbl[3]))((IMseStreamSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, HSTRING*, int>)(lpVtbl[4]))((IMseStreamSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, TrustLevel*, int>)(lpVtbl[5]))((IMseStreamSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.add_Opened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Opened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMseStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.remove_Opened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Opened(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, EventRegistrationToken, int>)(lpVtbl[7]))((IMseStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.add_Ended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Ended([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMseStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.remove_Ended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Ended(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, EventRegistrationToken, int>)(lpVtbl[9]))((IMseStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMseStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, EventRegistrationToken, int>)(lpVtbl[11]))((IMseStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.get_SourceBuffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SourceBuffers([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")] IMseSourceBufferList** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, IMseSourceBufferList**, int>)(lpVtbl[12]))((IMseStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.get_ActiveSourceBuffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ActiveSourceBuffers([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")] IMseSourceBufferList** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, IMseSourceBufferList**, int>)(lpVtbl[13]))((IMseStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.get_ReadyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ReadyState([NativeTypeName("ABI::Windows::Media::Core::MseReadyState *")] MseReadyState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, MseReadyState*, int>)(lpVtbl[14]))((IMseStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, IReference<TimeSpan>**, int>)(lpVtbl[15]))((IMseStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, IReference<TimeSpan>*, int>)(lpVtbl[16]))((IMseStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.AddSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddSourceBuffer(HSTRING mimeType, [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer **")] IMseSourceBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, HSTRING, IMseSourceBuffer**, int>)(lpVtbl[17]))((IMseStreamSource*)Unsafe.AsPointer(ref this), mimeType, buffer);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.RemoveSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveSourceBuffer([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer *")] IMseSourceBuffer* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, IMseSourceBuffer*, int>)(lpVtbl[18]))((IMseStreamSource*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='IMseStreamSource.xml' path='doc/member[@name="IMseStreamSource.EndOfStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EndOfStream([NativeTypeName("ABI::Windows::Media::Core::MseEndOfStreamStatus")] MseEndOfStreamStatus status)
    {
        return ((delegate* unmanaged[MemberFunction]<IMseStreamSource*, MseEndOfStreamStatus, int>)(lpVtbl[19]))((IMseStreamSource*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Opened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Opened(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Ended([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Ended(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_SourceBuffers([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")] IMseSourceBufferList** value);

        [VtblIndex(13)]
        HRESULT get_ActiveSourceBuffers([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")] IMseSourceBufferList** value);

        [VtblIndex(14)]
        HRESULT get_ReadyState([NativeTypeName("ABI::Windows::Media::Core::MseReadyState *")] MseReadyState* value);

        [VtblIndex(15)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(16)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(17)]
        HRESULT AddSourceBuffer(HSTRING mimeType, [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer **")] IMseSourceBuffer** buffer);

        [VtblIndex(18)]
        HRESULT RemoveSourceBuffer([NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer *")] IMseSourceBuffer* buffer);

        [VtblIndex(19)]
        HRESULT EndOfStream([NativeTypeName("ABI::Windows::Media::Core::MseEndOfStreamStatus")] MseEndOfStreamStatus status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Opened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Opened;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Ended;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Ended;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMseStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMseSourceBufferList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMseSourceBufferList**, int> get_SourceBuffers;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMseSourceBufferList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMseSourceBufferList**, int> get_ActiveSourceBuffers;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MseReadyState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MseReadyState*, int> get_ReadyState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_Duration;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Core::IMseSourceBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IMseSourceBuffer**, int> AddSourceBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMseSourceBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMseSourceBuffer*, int> RemoveSourceBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MseEndOfStreamStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MseEndOfStreamStatus, int> EndOfStream;
    }
}
