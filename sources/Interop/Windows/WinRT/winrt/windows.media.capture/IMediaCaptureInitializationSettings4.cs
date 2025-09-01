// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4"]/*' />
[Guid("F502A537-4CB7-4D28-95ED-4F9F012E0518")]
[NativeTypeName("struct IMediaCaptureInitializationSettings4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings4 : IMediaCaptureInitializationSettings4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaCaptureInitializationSettings4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.get_VideoProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoProfile([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfile **")] IMediaCaptureVideoProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfile**, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.put_VideoProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_VideoProfile([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfile *")] IMediaCaptureVideoProfile* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfile*, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.get_PreviewMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PreviewMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription**, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.put_PreviewMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PreviewMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription*, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.get_RecordMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RecordMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription**, int>)(lpVtbl[10]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.put_RecordMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RecordMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription*, int>)(lpVtbl[11]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.get_PhotoMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PhotoMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription**, int>)(lpVtbl[12]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings4.xml' path='doc/member[@name="IMediaCaptureInitializationSettings4.put_PhotoMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PhotoMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings4*, IMediaCaptureVideoProfileMediaDescription*, int>)(lpVtbl[13]))((IMediaCaptureInitializationSettings4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoProfile([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfile **")] IMediaCaptureVideoProfile** value);

        [VtblIndex(7)]
        HRESULT put_VideoProfile([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfile *")] IMediaCaptureVideoProfile* value);

        [VtblIndex(8)]
        HRESULT get_PreviewMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value);

        [VtblIndex(9)]
        HRESULT put_PreviewMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value);

        [VtblIndex(10)]
        HRESULT get_RecordMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value);

        [VtblIndex(11)]
        HRESULT put_RecordMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value);

        [VtblIndex(12)]
        HRESULT get_PhotoMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **")] IMediaCaptureVideoProfileMediaDescription** value);

        [VtblIndex(13)]
        HRESULT put_PhotoMediaDescription([NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *")] IMediaCaptureVideoProfileMediaDescription* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfile**, int> get_VideoProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfile*, int> put_VideoProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription**, int> get_PreviewMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription*, int> put_PreviewMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription**, int> get_RecordMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription*, int> put_RecordMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription**, int> get_PhotoMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IMediaCaptureVideoProfileMediaDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCaptureVideoProfileMediaDescription*, int> put_PhotoMediaDescription;
    }
}
