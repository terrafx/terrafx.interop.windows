// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8E2D566-186E-4D49-BF41-6909EAD56ACC")]
    public unsafe partial struct IPropertyStoreCapabilities
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyStoreCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyStoreCapabilities*, uint>)(lpVtbl[1]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyStoreCapabilities*, uint>)(lpVtbl[2]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPropertyWritable([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* stdcall<IPropertyStoreCapabilities*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), key);
        }
    }
}
