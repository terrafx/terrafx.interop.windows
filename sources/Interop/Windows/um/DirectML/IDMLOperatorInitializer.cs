// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("427C1113-435C-469C-8676-4D5DD072F813")]
    [NativeTypeName("struct IDMLOperatorInitializer : IDMLDispatchable")]
    public unsafe partial struct IDMLOperatorInitializer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, Guid*, void**, int>)(lpVtbl[0]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, uint>)(lpVtbl[1]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, uint>)(lpVtbl[2]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, ushort*, int>)(lpVtbl[6]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, Guid*, void**, int>)(lpVtbl[7]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DML_BINDING_PROPERTIES GetBindingProperties()
        {
            DML_BINDING_PROPERTIES result;
            return *((delegate* stdcall<IDMLOperatorInitializer*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*>)(lpVtbl[8]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators)
        {
            return ((delegate* stdcall<IDMLOperatorInitializer*, uint, IDMLCompiledOperator**, int>)(lpVtbl[9]))((IDMLOperatorInitializer*)Unsafe.AsPointer(ref this), operatorCount, operators);
        }
    }
}
