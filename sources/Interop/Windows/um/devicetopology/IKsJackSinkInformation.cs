// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D9BD72ED-290F-4581-9FF3-61027A8FE532")]
    public unsafe partial struct IKsJackSinkInformation
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IKsJackSinkInformation*, Guid*, void**, int>)(lpVtbl[0]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IKsJackSinkInformation*, uint>)(lpVtbl[1]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IKsJackSinkInformation*, uint>)(lpVtbl[2]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJackSinkInformation([NativeTypeName("KSJACK_SINK_INFORMATION *")] KSJACK_SINK_INFORMATION* pJackSinkInformation)
        {
            return ((delegate* stdcall<IKsJackSinkInformation*, KSJACK_SINK_INFORMATION*, int>)(lpVtbl[3]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this), pJackSinkInformation);
        }
    }
}
