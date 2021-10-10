// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCB821A8-1039-441E-9F1C-B1759C2F3CEC")]
    [NativeTypeName("struct IDMLDispatchable : IDMLPageable")]
    [NativeInheritance("IDMLPageable")]
    public unsafe partial struct IDMLDispatchable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDispatchable*, uint>)(lpVtbl[1]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLDispatchable*, uint>)(lpVtbl[2]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, ushort*, int>)(lpVtbl[6]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public DML_BINDING_PROPERTIES GetBindingProperties()
        {
            DML_BINDING_PROPERTIES result;
            return *((delegate* unmanaged<IDMLDispatchable*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*>)(lpVtbl[8]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
