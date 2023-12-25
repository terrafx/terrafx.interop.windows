// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedMetadataPresentationModeChangedEventArgs.xml' path='doc/member[@name="ITimedMetadataPresentationModeChangedEventArgs"]/*' />
[Guid("D1636099-65DF-45AE-8CEF-DC0B53FDC2BB")]
[NativeTypeName("struct ITimedMetadataPresentationModeChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataPresentationModeChangedEventArgs : ITimedMetadataPresentationModeChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedMetadataPresentationModeChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, uint>)(lpVtbl[1]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, uint>)(lpVtbl[2]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedMetadataPresentationModeChangedEventArgs.xml' path='doc/member[@name="ITimedMetadataPresentationModeChangedEventArgs.get_Track"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Track([NativeTypeName("ABI::Windows::Media::Core::ITimedMetadataTrack **")] ITimedMetadataTrack** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, ITimedMetadataTrack**, int>)(lpVtbl[6]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataPresentationModeChangedEventArgs.xml' path='doc/member[@name="ITimedMetadataPresentationModeChangedEventArgs.get_OldPresentationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OldPresentationMode([NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, TimedMetadataTrackPresentationMode*, int>)(lpVtbl[7]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataPresentationModeChangedEventArgs.xml' path='doc/member[@name="ITimedMetadataPresentationModeChangedEventArgs.get_NewPresentationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NewPresentationMode([NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataPresentationModeChangedEventArgs*, TimedMetadataTrackPresentationMode*, int>)(lpVtbl[8]))((ITimedMetadataPresentationModeChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Track([NativeTypeName("ABI::Windows::Media::Core::ITimedMetadataTrack **")] ITimedMetadataTrack** value);

        [VtblIndex(7)]
        HRESULT get_OldPresentationMode([NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value);

        [VtblIndex(8)]
        HRESULT get_NewPresentationMode([NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedMetadataTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedMetadataTrack**, int> get_Track;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedMetadataTrackPresentationMode*, int> get_OldPresentationMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedMetadataTrackPresentationMode*, int> get_NewPresentationMode;
    }
}
