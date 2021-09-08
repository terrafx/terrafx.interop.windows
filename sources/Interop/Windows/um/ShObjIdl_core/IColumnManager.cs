// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8EC27BB-3F3B-4042-B10A-4ACFD924D453")]
    [NativeTypeName("struct IColumnManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IColumnManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IColumnManager*, Guid*, void**, int>)(lpVtbl[0]))((IColumnManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IColumnManager*, uint>)(lpVtbl[1]))((IColumnManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IColumnManager*, uint>)(lpVtbl[2]))((IColumnManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetColumnInfo([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const CM_COLUMNINFO *")] CM_COLUMNINFO* pcmci)
        {
            return ((delegate* unmanaged<IColumnManager*, PROPERTYKEY*, CM_COLUMNINFO*, int>)(lpVtbl[3]))((IColumnManager*)Unsafe.AsPointer(ref this), propkey, pcmci);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnInfo([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, CM_COLUMNINFO* pcmci)
        {
            return ((delegate* unmanaged<IColumnManager*, PROPERTYKEY*, CM_COLUMNINFO*, int>)(lpVtbl[4]))((IColumnManager*)Unsafe.AsPointer(ref this), propkey, pcmci);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnCount(CM_ENUM_FLAGS dwFlags, [NativeTypeName("UINT *")] uint* puCount)
        {
            return ((delegate* unmanaged<IColumnManager*, CM_ENUM_FLAGS, uint*, int>)(lpVtbl[5]))((IColumnManager*)Unsafe.AsPointer(ref this), dwFlags, puCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumns(CM_ENUM_FLAGS dwFlags, PROPERTYKEY* rgkeyOrder, [NativeTypeName("UINT")] uint cColumns)
        {
            return ((delegate* unmanaged<IColumnManager*, CM_ENUM_FLAGS, PROPERTYKEY*, uint, int>)(lpVtbl[6]))((IColumnManager*)Unsafe.AsPointer(ref this), dwFlags, rgkeyOrder, cColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetColumns([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgkeyOrder, [NativeTypeName("UINT")] uint cVisible)
        {
            return ((delegate* unmanaged<IColumnManager*, PROPERTYKEY*, uint, int>)(lpVtbl[7]))((IColumnManager*)Unsafe.AsPointer(ref this), rgkeyOrder, cVisible);
        }
    }
}
