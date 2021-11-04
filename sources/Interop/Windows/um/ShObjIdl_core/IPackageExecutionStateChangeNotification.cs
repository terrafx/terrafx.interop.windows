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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPackageExecutionStateChangeNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, Guid*, void**, int>)(lpVtbl[0]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint>)(lpVtbl[1]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint>)(lpVtbl[2]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStateChanged([NativeTypeName("LPCWSTR")] ushort* pszPackageFullName, PACKAGE_EXECUTION_STATE pesNewState)
        {
            return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, ushort*, PACKAGE_EXECUTION_STATE, int>)(lpVtbl[3]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), pszPackageFullName, pesNewState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPackageExecutionStateChangeNotification*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, PACKAGE_EXECUTION_STATE) __attribute__((stdcall))")]
            public delegate* unmanaged<IPackageExecutionStateChangeNotification*, ushort*, PACKAGE_EXECUTION_STATE, int> OnStateChanged;
        }
    }
}
