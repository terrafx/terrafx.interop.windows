// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskRequest.xml' path='doc/member[@name="IPrintTaskRequest"]/*' />
[Guid("6FF61E2E-2722-4240-A67C-F364849A17F3")]
[NativeTypeName("struct IPrintTaskRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskRequest : IPrintTaskRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, uint>)(lpVtbl[1]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, uint>)(lpVtbl[2]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskRequest.xml' path='doc/member[@name="IPrintTaskRequest.get_Deadline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, DateTime*, int>)(lpVtbl[6]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskRequest.xml' path='doc/member[@name="IPrintTaskRequest.CreatePrintTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreatePrintTask(HSTRING title, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *")] IPrintTaskSourceRequestedHandler* handler, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTask **")] IPrintTask** task)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, HSTRING, IPrintTaskSourceRequestedHandler*, IPrintTask**, int>)(lpVtbl[7]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), title, handler, task);
    }

    /// <include file='IPrintTaskRequest.xml' path='doc/member[@name="IPrintTaskRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **")] IPrintTaskRequestedDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskRequest*, IPrintTaskRequestedDeferral**, int>)(lpVtbl[8]))((IPrintTaskRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(7)]
        HRESULT CreatePrintTask(HSTRING title, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *")] IPrintTaskSourceRequestedHandler* handler, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTask **")] IPrintTask** task);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **")] IPrintTaskRequestedDeferral** deferral);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_Deadline;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *, ABI::Windows::Graphics::Printing::IPrintTask **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IPrintTaskSourceRequestedHandler*, IPrintTask**, int> CreatePrintTask;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTaskRequestedDeferral**, int> GetDeferral;
    }
}
