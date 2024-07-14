// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource"]/*' />
[Guid("BD4F8897-1423-4C3E-82C5-0FB1AF94F715")]
[NativeTypeName("struct IMediaPlayerSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerSource : IMediaPlayerSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, uint>)(lpVtbl[1]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, uint>)(lpVtbl[2]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource.get_ProtectionManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")] IMediaProtectionManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, IMediaProtectionManager**, int>)(lpVtbl[6]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource.put_ProtectionManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, IMediaProtectionManager*, int>)(lpVtbl[7]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource.SetFileSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
    public HRESULT SetFileSource([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, IStorageFile*, int>)(lpVtbl[8]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), file);
    }

    /// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource.SetStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
    public HRESULT SetStreamSource([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, IRandomAccessStream*, int>)(lpVtbl[9]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), stream);
    }

    /// <include file='IMediaPlayerSource.xml' path='doc/member[@name="IMediaPlayerSource.SetMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
    public HRESULT SetMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* source)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSource*, IMediaSource*, int>)(lpVtbl[10]))((IMediaPlayerSource*)Unsafe.AsPointer(ref this), source);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")] IMediaProtectionManager** value);

        [VtblIndex(7)]
        HRESULT put_ProtectionManager([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* value);

        [VtblIndex(8)]
        [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
        HRESULT SetFileSource([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file);

        [VtblIndex(9)]
        [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
        HRESULT SetStreamSource([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream);

        [VtblIndex(10)]
        [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
        HRESULT SetMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* source);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager**, int> get_ProtectionManager;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager*, int> put_ProtectionManager;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> SetFileSource;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, int> SetStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource *) __attribute__((stdcall))")]
        [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource*, int> SetMediaSource;
    }
}
