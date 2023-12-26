// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings2.xml' path='doc/member[@name="IMediaCaptureInitializationSettings2"]/*' />
[Guid("404E0626-C9DC-43E9-AEE4-E6BF1B57B44C")]
[NativeTypeName("struct IMediaCaptureInitializationSettings2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings2 : IMediaCaptureInitializationSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureInitializationSettings2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings2.xml' path='doc/member[@name="IMediaCaptureInitializationSettings2.put_MediaCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, MediaCategory, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings2.xml' path='doc/member[@name="IMediaCaptureInitializationSettings2.get_MediaCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory *")] MediaCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, MediaCategory*, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings2.xml' path='doc/member[@name="IMediaCaptureInitializationSettings2.put_AudioProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, AudioProcessing, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings2.xml' path='doc/member[@name="IMediaCaptureInitializationSettings2.get_AudioProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings2*, AudioProcessing*, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory value);

        [VtblIndex(7)]
        HRESULT get_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory *")] MediaCategory* value);

        [VtblIndex(8)]
        HRESULT put_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing value);

        [VtblIndex(9)]
        HRESULT get_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, int> put_MediaCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory*, int> get_MediaCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::AudioProcessing) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioProcessing, int> put_AudioProcessing;

        [NativeTypeName("HRESULT (ABI::Windows::Media::AudioProcessing *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioProcessing*, int> get_AudioProcessing;
    }
}
