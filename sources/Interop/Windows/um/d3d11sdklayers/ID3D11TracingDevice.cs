// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1911C771-1587-413E-A7E0-FB26C3DE0268")]
    public unsafe partial struct ID3D11TracingDevice
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11TracingDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11TracingDevice*, uint>)(lpVtbl[1]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11TracingDevice*, uint>)(lpVtbl[2]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetShaderTrackingOptionsByType([NativeTypeName("UINT")] uint ResourceTypeFlags, [NativeTypeName("UINT")] uint Options)
        {
            return ((delegate* stdcall<ID3D11TracingDevice*, uint, uint, int>)(lpVtbl[3]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), ResourceTypeFlags, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetShaderTrackingOptions([NativeTypeName("IUnknown *")] IUnknown* pShader, [NativeTypeName("UINT")] uint Options)
        {
            return ((delegate* stdcall<ID3D11TracingDevice*, IUnknown*, uint, int>)(lpVtbl[4]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), pShader, Options);
        }
    }
}
