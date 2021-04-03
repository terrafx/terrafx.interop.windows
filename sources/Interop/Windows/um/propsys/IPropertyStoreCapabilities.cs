// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8E2D566-186E-4D49-BF41-6909EAD56ACC")]
    [NativeTypeName("struct IPropertyStoreCapabilities : IUnknown")]
    public unsafe partial struct IPropertyStoreCapabilities
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyStoreCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyStoreCapabilities*, uint>)(lpVtbl[1]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyStoreCapabilities*, uint>)(lpVtbl[2]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPropertyWritable([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyStoreCapabilities*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), key);
        }
    }
}
