// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IRoSimpleMetaDataBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int SetWinRtInterface([NativeTypeName("GUID")] Guid iid)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, int>)(lpVtbl[0]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), iid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("HRESULT")]
        public int SetDelegate([NativeTypeName("GUID")] Guid iid)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, int>)(lpVtbl[1]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), iid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("HRESULT")]
        public int SetInterfaceGroupSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, Guid*, int>)(lpVtbl[2]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, defaultInterfaceName, defaultInterfaceIID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetInterfaceGroupParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("PCWSTR *")] ushort** defaultInterfaceNameElements)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int>)(lpVtbl[3]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, elementCount, defaultInterfaceNameElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetRuntimeClassSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, Guid*, int>)(lpVtbl[4]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, defaultInterfaceName, defaultInterfaceIID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetRuntimeClassParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("const PCWSTR *")] ushort** defaultInterfaceNameElements)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int>)(lpVtbl[5]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, elementCount, defaultInterfaceNameElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetStruct([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint numFields, [NativeTypeName("const PCWSTR *")] ushort** fieldTypeNames)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int>)(lpVtbl[6]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, numFields, fieldTypeNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetEnum([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* baseType)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, int>)(lpVtbl[7]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, baseType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetParameterizedInterface([NativeTypeName("GUID")] Guid piid, [NativeTypeName("UINT32")] uint numArgs)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, uint, int>)(lpVtbl[8]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), piid, numArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetParameterizedDelegate([NativeTypeName("GUID")] Guid piid, [NativeTypeName("UINT32")] uint numArgs)
        {
            return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, uint, int>)(lpVtbl[9]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), piid, numArgs);
        }
    }
}
