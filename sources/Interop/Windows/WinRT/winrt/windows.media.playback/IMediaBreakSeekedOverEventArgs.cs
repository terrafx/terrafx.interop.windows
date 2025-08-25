// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBreakSeekedOverEventArgs.xml' path='doc/member[@name="IMediaBreakSeekedOverEventArgs"]/*' />
[Guid("E5AA6746-0606-4492-B9D3-C3C8FDE0A4EA")]
[NativeTypeName("struct IMediaBreakSeekedOverEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreakSeekedOverEventArgs : IMediaBreakSeekedOverEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaBreakSeekedOverEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, uint>)(lpVtbl[1]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, uint>)(lpVtbl[2]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBreakSeekedOverEventArgs.xml' path='doc/member[@name="IMediaBreakSeekedOverEventArgs.get_SeekedOverBreaks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SeekedOverBreaks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **")] IVectorView<Pointer<IMediaBreak>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, IVectorView<Pointer<IMediaBreak>>**, int>)(lpVtbl[6]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSeekedOverEventArgs.xml' path='doc/member[@name="IMediaBreakSeekedOverEventArgs.get_OldPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OldPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, TimeSpan*, int>)(lpVtbl[7]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSeekedOverEventArgs.xml' path='doc/member[@name="IMediaBreakSeekedOverEventArgs.get_NewPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NewPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSeekedOverEventArgs*, TimeSpan*, int>)(lpVtbl[8]))((IMediaBreakSeekedOverEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SeekedOverBreaks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **")] IVectorView<Pointer<IMediaBreak>>** value);

        [VtblIndex(7)]
        HRESULT get_OldPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_NewPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaBreak>>**, int> get_SeekedOverBreaks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_OldPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_NewPosition;
    }
}
