// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextSourceResolveResultEventArgs.xml' path='doc/member[@name="ITimedTextSourceResolveResultEventArgs"]/*' />
[Guid("48907C9C-DCD8-4C33-9AD3-6CDCE7B1C566")]
[NativeTypeName("struct ITimedTextSourceResolveResultEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSourceResolveResultEventArgs : ITimedTextSourceResolveResultEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSourceResolveResultEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, uint>)(lpVtbl[1]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, uint>)(lpVtbl[2]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextSourceResolveResultEventArgs.xml' path='doc/member[@name="ITimedTextSourceResolveResultEventArgs.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Media::Core::ITimedMetadataTrackError **")] ITimedMetadataTrackError** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, ITimedMetadataTrackError**, int>)(lpVtbl[6]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSourceResolveResultEventArgs.xml' path='doc/member[@name="ITimedTextSourceResolveResultEventArgs.get_Tracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Tracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IVectorView<Pointer<ITimedMetadataTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceResolveResultEventArgs*, IVectorView<Pointer<ITimedMetadataTrack>>**, int>)(lpVtbl[7]))((ITimedTextSourceResolveResultEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Media::Core::ITimedMetadataTrackError **")] ITimedMetadataTrackError** value);

        [VtblIndex(7)]
        HRESULT get_Tracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IVectorView<Pointer<ITimedMetadataTrack>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedMetadataTrackError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedMetadataTrackError**, int> get_Error;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ITimedMetadataTrack>>**, int> get_Tracks;
    }
}
