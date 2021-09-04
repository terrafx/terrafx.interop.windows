// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2659B475-EEB8-48B7-8F07-B378810F48CF")]
    [NativeTypeName("struct IShellItemFilter : IUnknown")]
    public unsafe partial struct IShellItemFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItemFilter*, Guid*, void**, int>)(lpVtbl[0]))((IShellItemFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItemFilter*, uint>)(lpVtbl[1]))((IShellItemFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItemFilter*, uint>)(lpVtbl[2]))((IShellItemFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IncludeItem(IShellItem* psi)
        {
            return ((delegate* unmanaged<IShellItemFilter*, IShellItem*, int>)(lpVtbl[3]))((IShellItemFilter*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumFlagsForItem(IShellItem* psi, [NativeTypeName("SHCONTF *")] uint* pgrfFlags)
        {
            return ((delegate* unmanaged<IShellItemFilter*, IShellItem*, uint*, int>)(lpVtbl[4]))((IShellItemFilter*)Unsafe.AsPointer(ref this), psi, pgrfFlags);
        }
    }
}
