// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC110B6D-57E8-4148-A9C6-91015AB2F3A5")]
    [NativeTypeName("struct IPropertyStoreFactory : IUnknown")]
    public unsafe partial struct IPropertyStoreFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyStoreFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyStoreFactory*, uint>)(lpVtbl[1]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyStoreFactory*, uint>)(lpVtbl[2]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("IUnknown *")] IUnknown* pUnkFactory, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, pUnkFactory, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, [NativeTypeName("UINT")] uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyStoreFactory*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[4]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
        }
    }
}
