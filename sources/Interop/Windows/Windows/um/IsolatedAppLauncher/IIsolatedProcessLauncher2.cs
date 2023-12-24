// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IIsolatedProcessLauncher2.xml' path='doc/member[@name="IIsolatedProcessLauncher2"]/*' />
[Guid("780E4416-5E72-4123-808E-66DC6479FEEF")]
[NativeTypeName("struct IIsolatedProcessLauncher2 : IIsolatedProcessLauncher")]
[NativeInheritance("IIsolatedProcessLauncher")]
public unsafe partial struct IIsolatedProcessLauncher2 : IIsolatedProcessLauncher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIsolatedProcessLauncher2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, Guid*, void**, int>)(lpVtbl[0]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, uint>)(lpVtbl[1]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, uint>)(lpVtbl[2]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IIsolatedProcessLauncher.LaunchProcess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchProcess([NativeTypeName("LPCWSTR")] char* process, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* workingDirectory)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, char*, char*, char*, int>)(lpVtbl[3]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), process, arguments, workingDirectory);
    }

    /// <inheritdoc cref="IIsolatedProcessLauncher.ShareDirectory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShareDirectory([NativeTypeName("LPCWSTR")] char* hostPath, [NativeTypeName("LPCWSTR")] char* containerPath, BOOL readOnly)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, char*, char*, BOOL, int>)(lpVtbl[4]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), hostPath, containerPath, readOnly);
    }

    /// <inheritdoc cref="IIsolatedProcessLauncher.GetContainerGuid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerGuid(Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, Guid*, int>)(lpVtbl[5]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref="IIsolatedProcessLauncher.AllowSetForegroundAccess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllowSetForegroundAccess(uint pid)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, uint, int>)(lpVtbl[6]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), pid);
    }

    /// <inheritdoc cref="IIsolatedProcessLauncher.IsContainerRunning" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsContainerRunning(BOOL* running)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, BOOL*, int>)(lpVtbl[7]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), running);
    }

    /// <include file='IIsolatedProcessLauncher2.xml' path='doc/member[@name="IIsolatedProcessLauncher2.LaunchProcess2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchProcess2([NativeTypeName("LPCWSTR")] char* process, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* workingDirectory, [NativeTypeName("const GUID &")] Guid* correlationGuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher2*, char*, char*, char*, Guid*, int>)(lpVtbl[8]))((IIsolatedProcessLauncher2*)Unsafe.AsPointer(ref this), process, arguments, workingDirectory, correlationGuid);
    }

    public interface Interface : IIsolatedProcessLauncher.Interface
    {
        [VtblIndex(8)]
        HRESULT LaunchProcess2([NativeTypeName("LPCWSTR")] char* process, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* workingDirectory, [NativeTypeName("const GUID &")] Guid* correlationGuid);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, int> LaunchProcess;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, BOOL, int> ShareDirectory;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerGuid;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> AllowSetForegroundAccess;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> IsContainerRunning;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, Guid*, int> LaunchProcess2;
    }
}
