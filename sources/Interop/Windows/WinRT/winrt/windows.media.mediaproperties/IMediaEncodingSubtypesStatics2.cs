// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingSubtypesStatics2.xml' path='doc/member[@name="IMediaEncodingSubtypesStatics2"]/*' />
[Guid("4B7CD23D-42FF-4D33-8531-0626BEE4B52D")]
[NativeTypeName("struct IMediaEncodingSubtypesStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingSubtypesStatics2 : IMediaEncodingSubtypesStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingSubtypesStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, uint>)(lpVtbl[1]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, uint>)(lpVtbl[2]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingSubtypesStatics2.xml' path='doc/member[@name="IMediaEncodingSubtypesStatics2.get_Vp9"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Vp9(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, HSTRING*, int>)(lpVtbl[6]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingSubtypesStatics2.xml' path='doc/member[@name="IMediaEncodingSubtypesStatics2.get_L8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_L8(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, HSTRING*, int>)(lpVtbl[7]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingSubtypesStatics2.xml' path='doc/member[@name="IMediaEncodingSubtypesStatics2.get_L16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_L16(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, HSTRING*, int>)(lpVtbl[8]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingSubtypesStatics2.xml' path='doc/member[@name="IMediaEncodingSubtypesStatics2.get_D16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_D16(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingSubtypesStatics2*, HSTRING*, int>)(lpVtbl[9]))((IMediaEncodingSubtypesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Vp9(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_L8(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_L16(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_D16(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Vp9;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_L8;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_L16;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_D16;
    }
}
