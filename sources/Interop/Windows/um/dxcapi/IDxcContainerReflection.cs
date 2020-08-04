// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2C21B26-8350-4BDC-976A-331CE6F4C54C")]
    public unsafe partial struct IDxcContainerReflection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint>)(lpVtbl[1]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint>)(lpVtbl[2]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pContainer)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint*, int>)(lpVtbl[4]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[5]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartContent([NativeTypeName("UINT32")] uint idx, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint, IDxcBlob**, int>)(lpVtbl[6]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[7]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), kind, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcContainerReflection*, uint, Guid*, void**, int>)(lpVtbl[8]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, iid, ppvObject);
        }
    }
}
