// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent"]/*' />
[Guid("CCF1A05F-D4B5-483A-B06E-E0DB1EC420E4")]
[NativeTypeName("struct IIndexableContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIndexableContent : IIndexableContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIndexableContent);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, Guid*, void**, int>)(lpVtbl[0]))((IIndexableContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, uint>)(lpVtbl[1]))((IIndexableContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, uint>)(lpVtbl[2]))((IIndexableContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, uint*, Guid**, int>)(lpVtbl[3]))((IIndexableContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, HSTRING*, int>)(lpVtbl[4]))((IIndexableContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, TrustLevel*, int>)(lpVtbl[5]))((IIndexableContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, HSTRING*, int>)(lpVtbl[6]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, HSTRING, int>)(lpVtbl[7]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **")] IMap<HSTRING, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, IMap<HSTRING, Pointer<IInspectable>>**, int>)(lpVtbl[8]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.get_Stream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, IRandomAccessStream**, int>)(lpVtbl[9]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.put_Stream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, IRandomAccessStream*, int>)(lpVtbl[10]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.get_StreamContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StreamContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, HSTRING*, int>)(lpVtbl[11]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIndexableContent.xml' path='doc/member[@name="IIndexableContent.put_StreamContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_StreamContentType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndexableContent*, HSTRING, int>)(lpVtbl[12]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **")] IMap<HSTRING, Pointer<IInspectable>>** value);

        [VtblIndex(9)]
        HRESULT get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value);

        [VtblIndex(10)]
        HRESULT put_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(11)]
        HRESULT get_StreamContentType(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_StreamContentType(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream**, int> get_Stream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, int> put_Stream;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StreamContentType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_StreamContentType;
    }
}
