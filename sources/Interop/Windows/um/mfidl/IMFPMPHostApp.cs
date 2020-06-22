// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84D2054A-3AA1-4728-A3B0-440A418CF49C")]
    public unsafe partial struct IMFPMPHostApp
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFPMPHostApp*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFPMPHostApp*, uint>)(lpVtbl[1]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFPMPHostApp*, uint>)(lpVtbl[2]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockProcess()
        {
            return ((delegate* stdcall<IMFPMPHostApp*, int>)(lpVtbl[3]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockProcess()
        {
            return ((delegate* stdcall<IMFPMPHostApp*, int>)(lpVtbl[4]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ActivateClassById([NativeTypeName("LPCWSTR")] ushort* id, [NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IMFPMPHostApp*, ushort*, IStream*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), id, pStream, riid, ppv);
        }
    }
}
