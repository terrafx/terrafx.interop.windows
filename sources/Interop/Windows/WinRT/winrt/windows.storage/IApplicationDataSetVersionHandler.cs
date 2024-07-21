// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationDataSetVersionHandler.xml' path='doc/member[@name="IApplicationDataSetVersionHandler"]/*' />
[Guid("A05791E6-CC9F-4687-ACAB-A364FD785463")]
[NativeTypeName("struct IApplicationDataSetVersionHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationDataSetVersionHandler : IApplicationDataSetVersionHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDataSetVersionHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataSetVersionHandler*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataSetVersionHandler*, uint>)(lpVtbl[1]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataSetVersionHandler*, uint>)(lpVtbl[2]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationDataSetVersionHandler.xml' path='doc/member[@name="IApplicationDataSetVersionHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::ISetVersionRequest *")] ISetVersionRequest* setVersionRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataSetVersionHandler*, ISetVersionRequest*, int>)(lpVtbl[3]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this), setVersionRequest);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::ISetVersionRequest *")] ISetVersionRequest* setVersionRequest);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::ISetVersionRequest *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISetVersionRequest*, int> Invoke;
    }
}
