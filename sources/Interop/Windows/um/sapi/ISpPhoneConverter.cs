// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8445C581-0CAC-4A38-ABFE-9B2CE2826455")]
    [NativeTypeName("struct ISpPhoneConverter : ISpObjectWithToken")]
    public unsafe partial struct ISpPhoneConverter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpPhoneConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpPhoneConverter*, uint>)(lpVtbl[1]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpPhoneConverter*, uint>)(lpVtbl[2]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjectToken([NativeTypeName("ISpObjectToken *")] ISpObjectToken* pToken)
        {
            return ((delegate* stdcall<ISpPhoneConverter*, ISpObjectToken*, int>)(lpVtbl[3]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pToken);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectToken([NativeTypeName("ISpObjectToken **")] ISpObjectToken** ppToken)
        {
            return ((delegate* stdcall<ISpPhoneConverter*, ISpObjectToken**, int>)(lpVtbl[4]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), ppToken);
        }

        [return: NativeTypeName("HRESULT")]
        public int PhoneToId([NativeTypeName("LPCWSTR")] ushort* pszPhone, [NativeTypeName("SPPHONEID *")] ushort* pId)
        {
            return ((delegate* stdcall<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pszPhone, pId);
        }

        [return: NativeTypeName("HRESULT")]
        public int IdToPhone([NativeTypeName("PCSPPHONEID")] ushort* pId, [NativeTypeName("WCHAR *")] ushort* pszPhone)
        {
            return ((delegate* stdcall<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[6]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pId, pszPhone);
        }
    }
}
