// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45D37C3F-5140-444A-AE24-400789F3CBF3")]
    [NativeTypeName("struct IControlInterface : IUnknown")]
    public unsafe partial struct IControlInterface
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IControlInterface*, Guid*, void**, int>)(lpVtbl[0]))((IControlInterface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IControlInterface*, uint>)(lpVtbl[1]))((IControlInterface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IControlInterface*, uint>)(lpVtbl[2]))((IControlInterface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
        {
            return ((delegate* stdcall<IControlInterface*, ushort**, int>)(lpVtbl[3]))((IControlInterface*)Unsafe.AsPointer(ref this), ppwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIID([NativeTypeName("GUID *")] Guid* pIID)
        {
            return ((delegate* stdcall<IControlInterface*, Guid*, int>)(lpVtbl[4]))((IControlInterface*)Unsafe.AsPointer(ref this), pIID);
        }
    }
}
