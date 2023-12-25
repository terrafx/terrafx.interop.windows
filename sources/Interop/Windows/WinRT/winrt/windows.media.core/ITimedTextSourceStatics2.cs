// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextSourceStatics2.xml' path='doc/member[@name="ITimedTextSourceStatics2"]/*' />
[Guid("B66B7602-923E-43FA-9633-587075812DB5")]
[NativeTypeName("struct ITimedTextSourceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSourceStatics2 : ITimedTextSourceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSourceStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, uint>)(lpVtbl[1]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, uint>)(lpVtbl[2]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextSourceStatics2.xml' path='doc/member[@name="ITimedTextSourceStatics2.CreateFromStreamWithIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromStreamWithIndex([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* indexStream, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, IRandomAccessStream*, IRandomAccessStream*, ITimedTextSource**, int>)(lpVtbl[6]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), stream, indexStream, result);
    }

    /// <include file='ITimedTextSourceStatics2.xml' path='doc/member[@name="ITimedTextSourceStatics2.CreateFromUriWithIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUriWithIndex([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* indexUri, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, IUriRuntimeClass*, IUriRuntimeClass*, ITimedTextSource**, int>)(lpVtbl[7]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), uri, indexUri, result);
    }

    /// <include file='ITimedTextSourceStatics2.xml' path='doc/member[@name="ITimedTextSourceStatics2.CreateFromStreamWithIndexAndLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStreamWithIndexAndLanguage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* indexStream, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, IRandomAccessStream*, IRandomAccessStream*, HSTRING, ITimedTextSource**, int>)(lpVtbl[8]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), stream, indexStream, defaultLanguage, result);
    }

    /// <include file='ITimedTextSourceStatics2.xml' path='doc/member[@name="ITimedTextSourceStatics2.CreateFromUriWithIndexAndLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromUriWithIndexAndLanguage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* indexUri, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics2*, IUriRuntimeClass*, IUriRuntimeClass*, HSTRING, ITimedTextSource**, int>)(lpVtbl[9]))((ITimedTextSourceStatics2*)Unsafe.AsPointer(ref this), uri, indexUri, defaultLanguage, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromStreamWithIndex([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* indexStream, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result);

        [VtblIndex(7)]
        HRESULT CreateFromUriWithIndex([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* indexUri, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result);

        [VtblIndex(8)]
        HRESULT CreateFromStreamWithIndexAndLanguage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* indexStream, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result);

        [VtblIndex(9)]
        HRESULT CreateFromUriWithIndexAndLanguage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* indexUri, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IRandomAccessStream*, ITimedTextSource**, int> CreateFromStreamWithIndex;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IUriRuntimeClass*, ITimedTextSource**, int> CreateFromUriWithIndex;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IRandomAccessStream*, HSTRING, ITimedTextSource**, int> CreateFromStreamWithIndexAndLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IUriRuntimeClass*, HSTRING, ITimedTextSource**, int> CreateFromUriWithIndexAndLanguage;
    }
}
