// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1BB12A62-2AD8-432B-8CCF-0C2C52AFCD5B")]
    [NativeTypeName("struct IPackageExecutionStateChangeNotification : IUnknown")]
    public unsafe partial struct IPackageExecutionStateChangeNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, Guid*, void**, int>)(lpVtbl[0]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint>)(lpVtbl[1]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint>)(lpVtbl[2]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStateChanged([NativeTypeName("LPCWSTR")] ushort* pszPackageFullName, PACKAGE_EXECUTION_STATE pesNewState)
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, ushort*, PACKAGE_EXECUTION_STATE, int>)(lpVtbl[3]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), pszPackageFullName, pesNewState);
        }
    }
}
