// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4A073526-6103-4E21-B7BC-F519D1524E5D")]
    [NativeTypeName("struct IGetServiceIds : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGetServiceIds
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGetServiceIds*, Guid*, void**, int>)(lpVtbl[0]))((IGetServiceIds*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGetServiceIds*, uint>)(lpVtbl[1]))((IGetServiceIds*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGetServiceIds*, uint>)(lpVtbl[2]))((IGetServiceIds*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetServiceIds([NativeTypeName("ULONG *")] uint* serviceIdCount, [NativeTypeName("GUID **")] Guid** serviceIds)
        {
            return ((delegate* unmanaged<IGetServiceIds*, uint*, Guid**, int>)(lpVtbl[3]))((IGetServiceIds*)Unsafe.AsPointer(ref this), serviceIdCount, serviceIds);
        }
    }
}
