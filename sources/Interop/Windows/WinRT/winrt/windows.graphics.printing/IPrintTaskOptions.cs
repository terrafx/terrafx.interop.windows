// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskOptions.xml' path='doc/member[@name="IPrintTaskOptions"]/*' />
[Guid("5A0A66BB-D289-41BB-96DD-57E28338AE3F")]
[NativeTypeName("struct IPrintTaskOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskOptions : IPrintTaskOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, uint>)(lpVtbl[1]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, uint>)(lpVtbl[2]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskOptions.xml' path='doc/member[@name="IPrintTaskOptions.put_Bordering"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Bordering([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBordering")] PrintBordering value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, PrintBordering, int>)(lpVtbl[6]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptions.xml' path='doc/member[@name="IPrintTaskOptions.get_Bordering"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bordering([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBordering *")] PrintBordering* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, PrintBordering*, int>)(lpVtbl[7]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptions.xml' path='doc/member[@name="IPrintTaskOptions.GetPagePrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPagePrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageInfo *")] IPrintPageInfo* printPageInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** printTicket)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptions*, IPrintPageInfo*, IRandomAccessStream**, int>)(lpVtbl[8]))((IPrintTaskOptions*)Unsafe.AsPointer(ref this), printPageInfo, printTicket);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Bordering([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBordering")] PrintBordering value);

        [VtblIndex(7)]
        HRESULT get_Bordering([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBordering *")] PrintBordering* value);

        [VtblIndex(8)]
        HRESULT GetPagePrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageInfo *")] IPrintPageInfo* printPageInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** printTicket);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintBordering) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintBordering, int> put_Bordering;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintBordering *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintBordering*, int> get_Bordering;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintPageInfo *, ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintPageInfo*, IRandomAccessStream**, int> GetPagePrintTicket;
    }
}
