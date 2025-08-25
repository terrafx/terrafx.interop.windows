// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowXpsDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowXpsDataAvailableEventArgs"]/*' />
[Guid("4D11C331-54D1-434E-BE0E-82C5FA58E5B2")]
[NativeTypeName("struct IPrintWorkflowXpsDataAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowXpsDataAvailableEventArgs : IPrintWorkflowXpsDataAvailableEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowXpsDataAvailableEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowXpsDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowXpsDataAvailableEventArgs.get_Operation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Operation([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **")] IPrintWorkflowSubmittedOperation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, IPrintWorkflowSubmittedOperation**, int>)(lpVtbl[6]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowXpsDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowXpsDataAvailableEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowXpsDataAvailableEventArgs*, IDeferral**, int>)(lpVtbl[7]))((IPrintWorkflowXpsDataAvailableEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Operation([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **")] IPrintWorkflowSubmittedOperation** value);

        [VtblIndex(7)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowSubmittedOperation**, int> get_Operation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
