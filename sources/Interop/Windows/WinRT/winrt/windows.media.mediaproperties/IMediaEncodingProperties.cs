// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProperties.xml' path='doc/member[@name="IMediaEncodingProperties"]/*' />
[Guid("B4002AF6-ACD4-4E5A-A24B-5D7498A8B8C4")]
[NativeTypeName("struct IMediaEncodingProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProperties : IMediaEncodingProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaEncodingProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, uint>)(lpVtbl[1]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, uint>)(lpVtbl[2]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProperties.xml' path='doc/member[@name="IMediaEncodingProperties.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **")] IMap<Guid, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, IMap<Guid, Pointer<IInspectable>>**, int>)(lpVtbl[6]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProperties.xml' path='doc/member[@name="IMediaEncodingProperties.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, HSTRING*, int>)(lpVtbl[7]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProperties.xml' path='doc/member[@name="IMediaEncodingProperties.put_Subtype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Subtype(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, HSTRING, int>)(lpVtbl[8]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProperties.xml' path='doc/member[@name="IMediaEncodingProperties.get_Subtype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Subtype(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProperties*, HSTRING*, int>)(lpVtbl[9]))((IMediaEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **")] IMap<Guid, Pointer<IInspectable>>** value);

        [VtblIndex(7)]
        HRESULT get_Type(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_Subtype(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_Subtype(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<Guid, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Type;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subtype;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subtype;
    }
}
