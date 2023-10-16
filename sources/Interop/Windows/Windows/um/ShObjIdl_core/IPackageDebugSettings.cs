// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings"]/*' />
[Guid("F27C3930-8029-4AD1-94E3-3DBA417810C1")]
[NativeTypeName("struct IPackageDebugSettings : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPackageDebugSettings : IPackageDebugSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageDebugSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, Guid*, void**, int>)(lpVtbl[0]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, uint>)(lpVtbl[1]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, uint>)(lpVtbl[2]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.EnableDebugging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableDebugging([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("LPCWSTR")] char* debuggerCommandLine, [NativeTypeName("PZZWSTR")] char* environment)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, char*, char*, int>)(lpVtbl[3]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, debuggerCommandLine, environment);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.DisableDebugging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[4]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.Suspend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Suspend([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[5]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[6]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.TerminateAllProcesses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[7]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.SetTargetSessionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, uint, int>)(lpVtbl[8]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), sessionId);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.EnumerateBackgroundTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumerateBackgroundTasks([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("ULONG *")] uint* taskCount, [NativeTypeName("LPCGUID *")] Guid** taskIds, [NativeTypeName("LPCWSTR **")] char*** taskNames)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, uint*, Guid**, char***, int>)(lpVtbl[9]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, taskCount, taskIds, taskNames);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.ActivateBackgroundTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, Guid*, int>)(lpVtbl[10]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), taskId);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.StartServicing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartServicing([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[11]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.StopServicing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopServicing([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[12]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.StartSessionRedirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartSessionRedirection([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, uint, int>)(lpVtbl[13]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, sessionId);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.StopSessionRedirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] char* packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, int>)(lpVtbl[14]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.GetPackageExecutionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPackageExecutionState([NativeTypeName("LPCWSTR")] char* packageFullName, PACKAGE_EXECUTION_STATE* packageExecutionState)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, PACKAGE_EXECUTION_STATE*, int>)(lpVtbl[15]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, packageExecutionState);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.RegisterForPackageStateChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterForPackageStateChanges([NativeTypeName("LPCWSTR")] char* packageFullName, IPackageExecutionStateChangeNotification* pPackageExecutionStateChangeNotification, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, char*, IPackageExecutionStateChangeNotification*, uint*, int>)(lpVtbl[16]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, pPackageExecutionStateChangeNotification, pdwCookie);
    }

    /// <include file='IPackageDebugSettings.xml' path='doc/member[@name="IPackageDebugSettings.UnregisterForPackageStateChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageDebugSettings*, uint, int>)(lpVtbl[17]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnableDebugging([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("LPCWSTR")] char* debuggerCommandLine, [NativeTypeName("PZZWSTR")] char* environment);

        [VtblIndex(4)]
        HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(5)]
        HRESULT Suspend([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(6)]
        HRESULT Resume([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(7)]
        HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(8)]
        HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId);

        [VtblIndex(9)]
        HRESULT EnumerateBackgroundTasks([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("ULONG *")] uint* taskCount, [NativeTypeName("LPCGUID *")] Guid** taskIds, [NativeTypeName("LPCWSTR **")] char*** taskNames);

        [VtblIndex(10)]
        HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId);

        [VtblIndex(11)]
        HRESULT StartServicing([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(12)]
        HRESULT StopServicing([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(13)]
        HRESULT StartSessionRedirection([NativeTypeName("LPCWSTR")] char* packageFullName, [NativeTypeName("ULONG")] uint sessionId);

        [VtblIndex(14)]
        HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] char* packageFullName);

        [VtblIndex(15)]
        HRESULT GetPackageExecutionState([NativeTypeName("LPCWSTR")] char* packageFullName, PACKAGE_EXECUTION_STATE* packageExecutionState);

        [VtblIndex(16)]
        HRESULT RegisterForPackageStateChanges([NativeTypeName("LPCWSTR")] char* packageFullName, IPackageExecutionStateChangeNotification* pPackageExecutionStateChangeNotification, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(17)]
        HRESULT UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, PZZWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, int> EnableDebugging;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DisableDebugging;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> Suspend;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> Resume;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> TerminateAllProcesses;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetTargetSessionId;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, LPCGUID *, LPCWSTR **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, Guid**, char***, int> EnumerateBackgroundTasks;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> ActivateBackgroundTask;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> StartServicing;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> StopServicing;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> StartSessionRedirection;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> StopSessionRedirection;

        [NativeTypeName("HRESULT (LPCWSTR, PACKAGE_EXECUTION_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PACKAGE_EXECUTION_STATE*, int> GetPackageExecutionState;

        [NativeTypeName("HRESULT (LPCWSTR, IPackageExecutionStateChangeNotification *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IPackageExecutionStateChangeNotification*, uint*, int> RegisterForPackageStateChanges;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> UnregisterForPackageStateChanges;
    }
}
