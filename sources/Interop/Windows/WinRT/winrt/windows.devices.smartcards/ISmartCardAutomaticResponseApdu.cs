// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu"]/*' />
[Guid("52152BAB-C63E-4531-A857-D756D99B986A")]
[NativeTypeName("struct ISmartCardAutomaticResponseApdu : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAutomaticResponseApdu : ISmartCardAutomaticResponseApdu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAutomaticResponseApdu));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, uint>)(lpVtbl[1]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, uint>)(lpVtbl[2]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.get_CommandApdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer**, int>)(lpVtbl[6]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.put_CommandApdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer*, int>)(lpVtbl[7]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.get_CommandApduBitMask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CommandApduBitMask([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer**, int>)(lpVtbl[8]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.put_CommandApduBitMask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CommandApduBitMask([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer*, int>)(lpVtbl[9]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.get_ShouldMatchLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ShouldMatchLength([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, byte*, int>)(lpVtbl[10]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.put_ShouldMatchLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ShouldMatchLength([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, byte, int>)(lpVtbl[11]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.get_AppletId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppletId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer**, int>)(lpVtbl[12]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.put_AppletId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AppletId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer*, int>)(lpVtbl[13]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.get_ResponseApdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ResponseApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer**, int>)(lpVtbl[14]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu.put_ResponseApdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ResponseApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu*, IBuffer*, int>)(lpVtbl[15]))((ISmartCardAutomaticResponseApdu*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT put_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(8)]
        HRESULT get_CommandApduBitMask([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT put_CommandApduBitMask([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(10)]
        HRESULT get_ShouldMatchLength([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ShouldMatchLength([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_AppletId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(13)]
        HRESULT put_AppletId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(14)]
        HRESULT get_ResponseApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(15)]
        HRESULT put_ResponseApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_CommandApdu;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_CommandApdu;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_CommandApduBitMask;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_CommandApduBitMask;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShouldMatchLength;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShouldMatchLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_AppletId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_AppletId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_ResponseApdu;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_ResponseApdu;
    }
}
