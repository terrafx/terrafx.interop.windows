// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F03340-547D-101B-8E65-08002B2BD119")]
    [NativeTypeName("struct ICreateErrorInfo : IUnknown")]
    public unsafe partial struct ICreateErrorInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICreateErrorInfo*, uint>)(lpVtbl[1]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICreateErrorInfo*, uint>)(lpVtbl[2]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, Guid*, int>)(lpVtbl[3]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, ushort*, int>)(lpVtbl[4]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, ushort*, int>)(lpVtbl[5]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, ushort*, int>)(lpVtbl[6]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* stdcall<ICreateErrorInfo*, uint, int>)(lpVtbl[7]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }
    }
}
