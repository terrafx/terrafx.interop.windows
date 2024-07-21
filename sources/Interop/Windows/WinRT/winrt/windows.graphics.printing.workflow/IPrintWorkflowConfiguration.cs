// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowConfiguration.xml' path='doc/member[@name="IPrintWorkflowConfiguration"]/*' />
[Guid("D0AAC4ED-FD4B-5DF5-4BB6-8D0D159EBE3F")]
[NativeTypeName("struct IPrintWorkflowConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowConfiguration : IPrintWorkflowConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowConfiguration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, uint>)(lpVtbl[1]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, uint>)(lpVtbl[2]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowConfiguration.xml' path='doc/member[@name="IPrintWorkflowConfiguration.get_SourceAppDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceAppDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, HSTRING*, int>)(lpVtbl[6]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowConfiguration.xml' path='doc/member[@name="IPrintWorkflowConfiguration.get_JobTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_JobTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, HSTRING*, int>)(lpVtbl[7]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowConfiguration.xml' path='doc/member[@name="IPrintWorkflowConfiguration.get_SessionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SessionId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowConfiguration*, HSTRING*, int>)(lpVtbl[8]))((IPrintWorkflowConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceAppDisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_JobTitle(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_SessionId(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceAppDisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_JobTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SessionId;
    }
}
