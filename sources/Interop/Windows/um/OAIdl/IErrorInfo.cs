// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CF2B120-547D-101B-8E65-08002B2BD119")]
    public unsafe partial struct IErrorInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((IErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IErrorInfo*, uint>)(lpVtbl[1]))((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IErrorInfo*, uint>)(lpVtbl[2]))((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pGUID)
        {
            return ((delegate* stdcall<IErrorInfo*, Guid*, int>)(lpVtbl[3]))((IErrorInfo*)Unsafe.AsPointer(ref this), pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource)
        {
            return ((delegate* stdcall<IErrorInfo*, ushort**, int>)(lpVtbl[4]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription)
        {
            return ((delegate* stdcall<IErrorInfo*, ushort**, int>)(lpVtbl[5]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* stdcall<IErrorInfo*, ushort**, int>)(lpVtbl[6]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext)
        {
            return ((delegate* stdcall<IErrorInfo*, uint*, int>)(lpVtbl[7]))((IErrorInfo*)Unsafe.AsPointer(ref this), pdwHelpContext);
        }
    }
}
