// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISingleSelectMediaTrackList.xml' path='doc/member[@name="ISingleSelectMediaTrackList"]/*' />
[Guid("77206F1F-C34F-494F-8077-2BAD9FF4ECF1")]
[NativeTypeName("struct ISingleSelectMediaTrackList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISingleSelectMediaTrackList : ISingleSelectMediaTrackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISingleSelectMediaTrackList);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, Guid*, void**, int>)(lpVtbl[0]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, uint>)(lpVtbl[1]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, uint>)(lpVtbl[2]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, uint*, Guid**, int>)(lpVtbl[3]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, HSTRING*, int>)(lpVtbl[4]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, TrustLevel*, int>)(lpVtbl[5]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISingleSelectMediaTrackList.xml' path='doc/member[@name="ISingleSelectMediaTrackList.add_SelectedIndexChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SelectedIndexChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CISingleSelectMediaTrackList_IInspectable_t *")] ITypedEventHandler<Pointer<ISingleSelectMediaTrackList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, ITypedEventHandler<Pointer<ISingleSelectMediaTrackList>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISingleSelectMediaTrackList.xml' path='doc/member[@name="ISingleSelectMediaTrackList.remove_SelectedIndexChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SelectedIndexChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, EventRegistrationToken, int>)(lpVtbl[7]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISingleSelectMediaTrackList.xml' path='doc/member[@name="ISingleSelectMediaTrackList.put_SelectedIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SelectedIndex([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, int, int>)(lpVtbl[8]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISingleSelectMediaTrackList.xml' path='doc/member[@name="ISingleSelectMediaTrackList.get_SelectedIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SelectedIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISingleSelectMediaTrackList*, int*, int>)(lpVtbl[9]))((ISingleSelectMediaTrackList*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SelectedIndexChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CISingleSelectMediaTrackList_IInspectable_t *")] ITypedEventHandler<Pointer<ISingleSelectMediaTrackList>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SelectedIndexChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT put_SelectedIndex([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_SelectedIndex([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CISingleSelectMediaTrackList_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISingleSelectMediaTrackList>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SelectedIndexChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SelectedIndexChanged;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_SelectedIndex;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_SelectedIndex;
    }
}
