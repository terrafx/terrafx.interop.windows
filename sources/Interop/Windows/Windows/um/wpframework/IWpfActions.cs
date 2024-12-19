// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWpfActions.xml' path='doc/member[@name="IWpfActions"]/*' />
[NativeTypeName("struct IWpfActions : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfActions : IWpfActions.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfActions*, uint>)(lpVtbl[0]))((IWpfActions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfActions*, uint>)(lpVtbl[1]))((IWpfActions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWpfActions.xml' path='doc/member[@name="IWpfActions.RecycleWorkerProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void RecycleWorkerProcess([NativeTypeName("PCWSTR")] char* pszReason)
    {
        ((delegate* unmanaged[MemberFunction]<IWpfActions*, char*, void>)(lpVtbl[2]))((IWpfActions*)Unsafe.AsPointer(ref this), pszReason);
    }

    /// <include file='IWpfActions.xml' path='doc/member[@name="IWpfActions.FailWorkerProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void FailWorkerProcess([NativeTypeName("PCWSTR")] char* pszReason, HRESULT hrFailureToReport, [Optional] BOOL fFailOnNextPing)
    {
        ((delegate* unmanaged[MemberFunction]<IWpfActions*, char*, HRESULT, BOOL, void>)(lpVtbl[3]))((IWpfActions*)Unsafe.AsPointer(ref this), pszReason, hrFailureToReport, fFailOnNextPing);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        void RecycleWorkerProcess([NativeTypeName("PCWSTR")] char* pszReason);

        [VtblIndex(3)]
        void FailWorkerProcess([NativeTypeName("PCWSTR")] char* pszReason, HRESULT hrFailureToReport, [Optional] BOOL fFailOnNextPing);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void> RecycleWorkerProcess;

        [NativeTypeName("void (PCWSTR, HRESULT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HRESULT, BOOL, void> FailWorkerProcess;
    }
}
