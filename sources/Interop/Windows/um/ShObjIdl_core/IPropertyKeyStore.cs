// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75BD59AA-F23B-4963-ABA4-0B355752A91B")]
    [NativeTypeName("struct IPropertyKeyStore : IUnknown")]
    public unsafe partial struct IPropertyKeyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, uint>)(lpVtbl[1]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, uint>)(lpVtbl[2]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeyCount(int* keyCount)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, int*, int>)(lpVtbl[3]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), keyCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeyAt(int index, PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, int, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), index, pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int>)(lpVtbl[5]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteKey(int index)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, int, int>)(lpVtbl[6]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsKeyInStore([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int>)(lpVtbl[7]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int>)(lpVtbl[8]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
        }
    }
}
