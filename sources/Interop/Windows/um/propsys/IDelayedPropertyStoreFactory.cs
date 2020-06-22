// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("40D4577F-E237-4BDB-BD69-58F089431B6A")]
    public unsafe partial struct IDelayedPropertyStoreFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, uint>)(lpVtbl[1]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, uint>)(lpVtbl[2]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("IUnknown *")] IUnknown* pUnkFactory, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, pUnkFactory, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, [NativeTypeName("UINT")] uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[4]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDelayedPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("DWORD")] uint dwStoreId, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDelayedPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, uint, Guid*, void**, int>)(lpVtbl[5]))((IDelayedPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, dwStoreId, riid, ppv);
        }
    }
}
