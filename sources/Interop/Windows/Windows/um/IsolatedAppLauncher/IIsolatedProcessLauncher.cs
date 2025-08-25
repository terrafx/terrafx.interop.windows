// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher"]/*' />
[Guid("1AA24232-9A91-4201-88CB-122F9D6522E0")]
[NativeTypeName("struct IIsolatedProcessLauncher : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIsolatedProcessLauncher : IIsolatedProcessLauncher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIsolatedProcessLauncher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, Guid*, void**, int>)(lpVtbl[0]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, uint>)(lpVtbl[1]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, uint>)(lpVtbl[2]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher.LaunchProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchProcess([NativeTypeName("LPCWSTR")] char* process, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* workingDirectory)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, char*, char*, char*, int>)(lpVtbl[3]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), process, arguments, workingDirectory);
    }

    /// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher.ShareDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShareDirectory([NativeTypeName("LPCWSTR")] char* hostPath, [NativeTypeName("LPCWSTR")] char* containerPath, BOOL readOnly)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, char*, char*, BOOL, int>)(lpVtbl[4]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), hostPath, containerPath, readOnly);
    }

    /// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher.GetContainerGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerGuid(Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, Guid*, int>)(lpVtbl[5]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), guid);
    }

    /// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher.AllowSetForegroundAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllowSetForegroundAccess(uint pid)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, uint, int>)(lpVtbl[6]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), pid);
    }

    /// <include file='IIsolatedProcessLauncher.xml' path='doc/member[@name="IIsolatedProcessLauncher.IsContainerRunning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsContainerRunning(BOOL* running)
    {
        return ((delegate* unmanaged[MemberFunction]<IIsolatedProcessLauncher*, BOOL*, int>)(lpVtbl[7]))((IIsolatedProcessLauncher*)Unsafe.AsPointer(ref this), running);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LaunchProcess([NativeTypeName("LPCWSTR")] char* process, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* workingDirectory);

        [VtblIndex(4)]
        HRESULT ShareDirectory([NativeTypeName("LPCWSTR")] char* hostPath, [NativeTypeName("LPCWSTR")] char* containerPath, BOOL readOnly);

        [VtblIndex(5)]
        HRESULT GetContainerGuid(Guid* guid);

        [VtblIndex(6)]
        HRESULT AllowSetForegroundAccess(uint pid);

        [VtblIndex(7)]
        HRESULT IsContainerRunning(BOOL* running);
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
    }
}
