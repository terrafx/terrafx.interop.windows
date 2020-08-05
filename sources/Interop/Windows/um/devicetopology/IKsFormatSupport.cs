// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3CB4A69D-BB6F-4D2B-95B7-452D2C155DB5")]
    [NativeTypeName("struct IKsFormatSupport : IUnknown")]
    public unsafe partial struct IKsFormatSupport
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IKsFormatSupport*, Guid*, void**, int>)(lpVtbl[0]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IKsFormatSupport*, uint>)(lpVtbl[1]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IKsFormatSupport*, uint>)(lpVtbl[2]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, [NativeTypeName("BOOL *")] int* pbSupported)
        {
            return ((delegate* stdcall<IKsFormatSupport*, KSDATAFORMAT*, uint, int*, int>)(lpVtbl[3]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), pKsFormat, cbFormat, pbSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat)
        {
            return ((delegate* stdcall<IKsFormatSupport*, KSDATAFORMAT**, int>)(lpVtbl[4]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), ppKsFormat);
        }
    }
}
