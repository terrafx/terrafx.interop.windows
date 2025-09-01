// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskSourceRequestedArgs.xml' path='doc/member[@name="IPrintTaskSourceRequestedArgs"]/*' />
[Guid("F9F067BE-F456-41F0-9C98-5CE73E851410")]
[NativeTypeName("struct IPrintTaskSourceRequestedArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskSourceRequestedArgs : IPrintTaskSourceRequestedArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTaskSourceRequestedArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, uint>)(lpVtbl[1]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, uint>)(lpVtbl[2]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskSourceRequestedArgs.xml' path='doc/member[@name="IPrintTaskSourceRequestedArgs.get_Deadline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, WinRTDateTime*, int>)(lpVtbl[6]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskSourceRequestedArgs.xml' path='doc/member[@name="IPrintTaskSourceRequestedArgs.SetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSource([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintDocumentSource *")] IPrintDocumentSource* source)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, IPrintDocumentSource*, int>)(lpVtbl[7]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), source);
    }

    /// <include file='IPrintTaskSourceRequestedArgs.xml' path='doc/member[@name="IPrintTaskSourceRequestedArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedDeferral **")] IPrintTaskSourceRequestedDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskSourceRequestedArgs*, IPrintTaskSourceRequestedDeferral**, int>)(lpVtbl[8]))((IPrintTaskSourceRequestedArgs*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT SetSource([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintDocumentSource *")] IPrintDocumentSource* source);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedDeferral **")] IPrintTaskSourceRequestedDeferral** deferral);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Deadline;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintDocumentSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintDocumentSource*, int> SetSource;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTaskSourceRequestedDeferral**, int> GetDeferral;
    }
}
