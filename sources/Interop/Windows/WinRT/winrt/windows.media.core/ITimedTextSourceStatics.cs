// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextSourceStatics.xml' path='doc/member[@name="ITimedTextSourceStatics"]/*' />
[Guid("7E311853-9ABA-4AC4-BB98-2FB176C3BFDD")]
[NativeTypeName("struct ITimedTextSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSourceStatics : ITimedTextSourceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedTextSourceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, uint>)(lpVtbl[1]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, uint>)(lpVtbl[2]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextSourceStatics.xml' path='doc/member[@name="ITimedTextSourceStatics.CreateFromStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, IRandomAccessStream*, ITimedTextSource**, int>)(lpVtbl[6]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), stream, value);
    }

    /// <include file='ITimedTextSourceStatics.xml' path='doc/member[@name="ITimedTextSourceStatics.CreateFromUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, IUriRuntimeClass*, ITimedTextSource**, int>)(lpVtbl[7]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), uri, value);
    }

    /// <include file='ITimedTextSourceStatics.xml' path='doc/member[@name="ITimedTextSourceStatics.CreateFromStreamWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStreamWithLanguage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, IRandomAccessStream*, HSTRING, ITimedTextSource**, int>)(lpVtbl[8]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), stream, defaultLanguage, value);
    }

    /// <include file='ITimedTextSourceStatics.xml' path='doc/member[@name="ITimedTextSourceStatics.CreateFromUriWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromUriWithLanguage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSourceStatics*, IUriRuntimeClass*, HSTRING, ITimedTextSource**, int>)(lpVtbl[9]))((ITimedTextSourceStatics*)Unsafe.AsPointer(ref this), uri, defaultLanguage, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value);

        [VtblIndex(7)]
        HRESULT CreateFromUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value);

        [VtblIndex(8)]
        HRESULT CreateFromStreamWithLanguage([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value);

        [VtblIndex(9)]
        HRESULT CreateFromUriWithLanguage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING defaultLanguage, [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, ITimedTextSource**, int> CreateFromStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, ITimedTextSource**, int> CreateFromUri;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, HSTRING, ITimedTextSource**, int> CreateFromStreamWithLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, HSTRING, ITimedTextSource**, int> CreateFromUriWithLanguage;
    }
}
