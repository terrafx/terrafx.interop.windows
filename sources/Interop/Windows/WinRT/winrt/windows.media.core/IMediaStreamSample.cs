// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample"]/*' />
[Guid("5C8DB627-4B80-4361-9837-6CB7481AD9D6")]
[NativeTypeName("struct IMediaStreamSample : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSample : IMediaStreamSample.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSample));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, uint>)(lpVtbl[1]))((IMediaStreamSample*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, uint>)(lpVtbl[2]))((IMediaStreamSample*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.add_Processed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Processed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSample_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaStreamSample>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, ITypedEventHandler<Pointer<IMediaStreamSample>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.remove_Processed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Processed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_Buffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Buffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, IBuffer**, int>)(lpVtbl[8]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TimeSpan*, int>)(lpVtbl[9]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_ExtendedProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ExtendedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **")] IMap<Guid, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, IMap<Guid, Pointer<IInspectable>>**, int>)(lpVtbl[10]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_Protection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Protection([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSampleProtectionProperties **")] IMediaStreamSampleProtectionProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, IMediaStreamSampleProtectionProperties**, int>)(lpVtbl[11]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.put_DecodeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DecodeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TimeSpan, int>)(lpVtbl[12]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_DecodeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DecodeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TimeSpan*, int>)(lpVtbl[13]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TimeSpan, int>)(lpVtbl[14]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, TimeSpan*, int>)(lpVtbl[15]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.put_KeyFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_KeyFrame([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, byte, int>)(lpVtbl[16]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_KeyFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_KeyFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, byte*, int>)(lpVtbl[17]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.put_Discontinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_Discontinuous([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, byte, int>)(lpVtbl[18]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSample.xml' path='doc/member[@name="IMediaStreamSample.get_Discontinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Discontinuous([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSample*, byte*, int>)(lpVtbl[19]))((IMediaStreamSample*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Processed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSample_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaStreamSample>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Processed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Buffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT get_ExtendedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **")] IMap<Guid, Pointer<IInspectable>>** value);

        [VtblIndex(11)]
        HRESULT get_Protection([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSampleProtectionProperties **")] IMediaStreamSampleProtectionProperties** value);

        [VtblIndex(12)]
        HRESULT put_DecodeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(13)]
        HRESULT get_DecodeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(14)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(15)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(16)]
        HRESULT put_KeyFrame([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_KeyFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT put_Discontinuous([NativeTypeName("boolean")] byte value);

        [VtblIndex(19)]
        HRESULT get_Discontinuous([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaStreamSample_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaStreamSample>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Processed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Processed;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Buffer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<Guid, Pointer<IInspectable>>**, int> get_ExtendedProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSampleProtectionProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSampleProtectionProperties**, int> get_Protection;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DecodeTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DecodeTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeyFrame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeyFrame;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Discontinuous;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Discontinuous;
    }
}
