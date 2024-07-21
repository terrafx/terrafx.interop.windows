// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellExecuteHookA.xml' path='doc/member[@name="IShellExecuteHookA"]/*' />
[Guid("000214F5-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellExecuteHookA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellExecuteHookA : IShellExecuteHookA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellExecuteHookA));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExecuteHookA*, Guid*, void**, int>)(lpVtbl[0]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExecuteHookA*, uint>)(lpVtbl[1]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExecuteHookA*, uint>)(lpVtbl[2]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellExecuteHookA.xml' path='doc/member[@name="IShellExecuteHookA.Execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Execute([NativeTypeName("LPSHELLEXECUTEINFOA")] SHELLEXECUTEINFOA* pei)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellExecuteHookA*, SHELLEXECUTEINFOA*, int>)(lpVtbl[3]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this), pei);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Execute([NativeTypeName("LPSHELLEXECUTEINFOA")] SHELLEXECUTEINFOA* pei);
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

        [NativeTypeName("HRESULT (LPSHELLEXECUTEINFOA) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SHELLEXECUTEINFOA*, int> Execute;
    }
}
