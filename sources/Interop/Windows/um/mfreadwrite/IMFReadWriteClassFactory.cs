// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7FE2E12-661C-40DA-92F9-4F002AB67627")]
    [NativeTypeName("struct IMFReadWriteClassFactory : IUnknown")]
    public unsafe partial struct IMFReadWriteClassFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFReadWriteClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFReadWriteClassFactory*, uint>)(lpVtbl[1]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFReadWriteClassFactory*, uint>)(lpVtbl[2]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceFromURL([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFReadWriteClassFactory*, Guid*, ushort*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[3]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), clsid, pwszURL, pAttributes, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceFromObject([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFReadWriteClassFactory*, Guid*, IUnknown*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[4]))((IMFReadWriteClassFactory*)Unsafe.AsPointer(ref this), clsid, punkObject, pAttributes, riid, ppvObject);
        }
    }
}
