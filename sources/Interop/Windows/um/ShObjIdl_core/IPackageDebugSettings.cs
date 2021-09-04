// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F27C3930-8029-4AD1-94E3-3DBA417810C1")]
    [NativeTypeName("struct IPackageDebugSettings : IUnknown")]
    public unsafe partial struct IPackageDebugSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, Guid*, void**, int>)(lpVtbl[0]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, uint>)(lpVtbl[1]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, uint>)(lpVtbl[2]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("LPCWSTR")] ushort* debuggerCommandLine, [NativeTypeName("PZZWSTR")] ushort* environment)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, ushort*, ushort*, int>)(lpVtbl[3]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, debuggerCommandLine, environment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[4]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[5]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[6]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TerminateAllProcesses([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[7]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, uint, int>)(lpVtbl[8]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), sessionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumerateBackgroundTasks([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG *")] uint* taskCount, [NativeTypeName("LPCGUID *")] Guid** taskIds, [NativeTypeName("LPCWSTR **")] ushort*** taskNames)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, uint*, Guid**, ushort***, int>)(lpVtbl[9]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, taskCount, taskIds, taskNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, Guid*, int>)(lpVtbl[10]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), taskId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[11]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[12]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG")] uint sessionId)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, uint, int>)(lpVtbl[13]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, sessionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, int>)(lpVtbl[14]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageExecutionState([NativeTypeName("LPCWSTR")] ushort* packageFullName, PACKAGE_EXECUTION_STATE* packageExecutionState)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, PACKAGE_EXECUTION_STATE*, int>)(lpVtbl[15]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, packageExecutionState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterForPackageStateChanges([NativeTypeName("LPCWSTR")] ushort* packageFullName, IPackageExecutionStateChangeNotification* pPackageExecutionStateChangeNotification, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, ushort*, IPackageExecutionStateChangeNotification*, uint*, int>)(lpVtbl[16]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), packageFullName, pPackageExecutionStateChangeNotification, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IPackageDebugSettings*, uint, int>)(lpVtbl[17]))((IPackageDebugSettings*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
