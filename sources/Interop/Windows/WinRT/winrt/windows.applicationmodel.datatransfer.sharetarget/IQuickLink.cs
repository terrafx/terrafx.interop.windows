// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.sharetarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink"]/*' />
[Guid("603E4308-F0BE-4ADC-ACC9-8B27AB9CF556")]
[NativeTypeName("struct IQuickLink : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQuickLink : IQuickLink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQuickLink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, Guid*, void**, int>)(lpVtbl[0]))((IQuickLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, uint>)(lpVtbl[1]))((IQuickLink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, uint>)(lpVtbl[2]))((IQuickLink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, uint*, Guid**, int>)(lpVtbl[3]))((IQuickLink*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, HSTRING*, int>)(lpVtbl[4]))((IQuickLink*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, TrustLevel*, int>)(lpVtbl[5]))((IQuickLink*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, HSTRING*, int>)(lpVtbl[6]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, HSTRING, int>)(lpVtbl[7]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, IRandomAccessStreamReference**, int>)(lpVtbl[8]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.put_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, IRandomAccessStreamReference*, int>)(lpVtbl[9]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, HSTRING*, int>)(lpVtbl[10]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, HSTRING, int>)(lpVtbl[11]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.get_SupportedDataFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedDataFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, IVector<HSTRING>**, int>)(lpVtbl[12]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IQuickLink.xml' path='doc/member[@name="IQuickLink.get_SupportedFileTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SupportedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IQuickLink*, IVector<HSTRING>**, int>)(lpVtbl[13]))((IQuickLink*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(9)]
        HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(10)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_SupportedDataFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(13)]
        HRESULT get_SupportedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Thumbnail;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SupportedDataFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SupportedFileTypes;
    }
}
