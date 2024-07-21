// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowTarget.xml' path='doc/member[@name="IPrintWorkflowTarget"]/*' />
[Guid("29DA276C-0A73-5AED-4F3D-970D3251F057")]
[NativeTypeName("struct IPrintWorkflowTarget : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowTarget : IPrintWorkflowTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowTarget));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, uint>)(lpVtbl[1]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, uint>)(lpVtbl[2]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowTarget.xml' path='doc/member[@name="IPrintWorkflowTarget.get_TargetAsStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetAsStream([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowStreamTarget **")] IPrintWorkflowStreamTarget** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, IPrintWorkflowStreamTarget**, int>)(lpVtbl[6]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowTarget.xml' path='doc/member[@name="IPrintWorkflowTarget.get_TargetAsXpsObjectModelPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TargetAsXpsObjectModelPackage([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelTargetPackage **")] IPrintWorkflowObjectModelTargetPackage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowTarget*, IPrintWorkflowObjectModelTargetPackage**, int>)(lpVtbl[7]))((IPrintWorkflowTarget*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetAsStream([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowStreamTarget **")] IPrintWorkflowStreamTarget** value);

        [VtblIndex(7)]
        HRESULT get_TargetAsXpsObjectModelPackage([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelTargetPackage **")] IPrintWorkflowObjectModelTargetPackage** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowStreamTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowStreamTarget**, int> get_TargetAsStream;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelTargetPackage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowObjectModelTargetPackage**, int> get_TargetAsXpsObjectModelPackage;
    }
}
