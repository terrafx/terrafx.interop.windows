// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource"]/*' />
[Guid("3712D543-45EB-4138-AA62-C01E26F3843F")]
[NativeTypeName("struct IMediaStreamSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSource : IMediaStreamSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaStreamSource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, uint>)(lpVtbl[1]))((IMediaStreamSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, uint>)(lpVtbl[2]))((IMediaStreamSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceClosedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceClosedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.add_Starting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Starting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceStartingEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceStartingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceStartingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.remove_Starting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Starting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.add_Paused"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Paused([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.remove_Paused"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Paused(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.add_SampleRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_SampleRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSampleRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSampleRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSampleRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.remove_SampleRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_SampleRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, EventRegistrationToken, int>)(lpVtbl[13]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.add_SwitchStreamsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_SwitchStreamsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSwitchStreamsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSwitchStreamsRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSwitchStreamsRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.remove_SwitchStreamsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_SwitchStreamsRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, EventRegistrationToken, int>)(lpVtbl[15]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.NotifyError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT NotifyError([NativeTypeName("ABI::Windows::Media::Core::MediaStreamSourceErrorStatus")] MediaStreamSourceErrorStatus errorStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, MediaStreamSourceErrorStatus, int>)(lpVtbl[16]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), errorStatus);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.AddStreamDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IMediaStreamDescriptor*, int>)(lpVtbl[17]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), descriptor);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.put_MediaProtectionManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_MediaProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IMediaProtectionManager*, int>)(lpVtbl[18]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_MediaProtectionManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MediaProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")] IMediaProtectionManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IMediaProtectionManager**, int>)(lpVtbl[19]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TimeSpan, int>)(lpVtbl[20]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TimeSpan*, int>)(lpVtbl[21]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.put_CanSeek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_CanSeek([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, byte, int>)(lpVtbl[22]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_CanSeek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, byte*, int>)(lpVtbl[23]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.put_BufferTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_BufferTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TimeSpan, int>)(lpVtbl[24]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_BufferTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_BufferTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TimeSpan*, int>)(lpVtbl[25]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.SetBufferedRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBufferedRange([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startOffset, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan endOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, TimeSpan, TimeSpan, int>)(lpVtbl[26]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), startOffset, endOffset);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_MusicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Storage::FileProperties::IMusicProperties **")] IMusicProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IMusicProperties**, int>)(lpVtbl[27]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_VideoProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Storage::FileProperties::IVideoProperties **")] IVideoProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IVideoProperties**, int>)(lpVtbl[28]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.put_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IRandomAccessStreamReference*, int>)(lpVtbl[29]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IRandomAccessStreamReference**, int>)(lpVtbl[30]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSource.xml' path='doc/member[@name="IMediaStreamSource.AddProtectionKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT AddProtectionKey([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* streamDescriptor, [NativeTypeName("UINT32")] uint keyIdentifierLength, byte* keyIdentifier, [NativeTypeName("UINT32")] uint licenseDataLength, byte* licenseData)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSource*, IMediaStreamDescriptor*, uint, byte*, uint, byte*, int>)(lpVtbl[31]))((IMediaStreamSource*)Unsafe.AsPointer(ref this), streamDescriptor, keyIdentifierLength, keyIdentifier, licenseDataLength, licenseData);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceClosedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceClosedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Starting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceStartingEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceStartingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Starting(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_Paused([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_Paused(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_SampleRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSampleRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSampleRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_SampleRequested(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_SwitchStreamsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSwitchStreamsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSwitchStreamsRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_SwitchStreamsRequested(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT NotifyError([NativeTypeName("ABI::Windows::Media::Core::MediaStreamSourceErrorStatus")] MediaStreamSourceErrorStatus errorStatus);

        [VtblIndex(17)]
        HRESULT AddStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor);

        [VtblIndex(18)]
        HRESULT put_MediaProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* value);

        [VtblIndex(19)]
        HRESULT get_MediaProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")] IMediaProtectionManager** value);

        [VtblIndex(20)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(21)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(22)]
        HRESULT put_CanSeek([NativeTypeName("boolean")] byte value);

        [VtblIndex(23)]
        HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT put_BufferTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(25)]
        HRESULT get_BufferTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(26)]
        HRESULT SetBufferedRange([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan startOffset, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan endOffset);

        [VtblIndex(27)]
        HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Storage::FileProperties::IMusicProperties **")] IMusicProperties** value);

        [VtblIndex(28)]
        HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Storage::FileProperties::IVideoProperties **")] IVideoProperties** value);

        [VtblIndex(29)]
        HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(30)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(31)]
        HRESULT AddProtectionKey([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* streamDescriptor, [NativeTypeName("UINT32")] uint keyIdentifierLength, byte* keyIdentifier, [NativeTypeName("UINT32")] uint licenseDataLength, byte* licenseData);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceClosedEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceStartingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceStartingEventArgs>>*, EventRegistrationToken*, int> add_Starting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Starting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Paused;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Paused;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSampleRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSampleRequestedEventArgs>>*, EventRegistrationToken*, int> add_SampleRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SampleRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSource_Windows__CMedia__CCore__CMediaStreamSourceSwitchStreamsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSource>, Pointer<IMediaStreamSourceSwitchStreamsRequestedEventArgs>>*, EventRegistrationToken*, int> add_SwitchStreamsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SwitchStreamsRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MediaStreamSourceErrorStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamSourceErrorStatus, int> NotifyError;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor*, int> AddStreamDescriptor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager*, int> put_MediaProtectionManager;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager**, int> get_MediaProtectionManager;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanSeek;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSeek;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_BufferTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_BufferTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, TimeSpan, int> SetBufferedRange;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::IMusicProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMusicProperties**, int> get_MusicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::IVideoProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoProperties**, int> get_VideoProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *, UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor*, uint, byte*, uint, byte*, int> AddProtectionKey;
    }
}
