// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8445C581-0CAC-4A38-ABFE-9B2CE2826455")]
    [NativeTypeName("struct ISpPhoneConverter : ISpObjectWithToken")]
    [NativeInheritance("ISpObjectWithToken")]
    public unsafe partial struct ISpPhoneConverter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, uint>)(lpVtbl[1]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, uint>)(lpVtbl[2]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjectToken(ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, ISpObjectToken*, int>)(lpVtbl[3]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectToken(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, ISpObjectToken**, int>)(lpVtbl[4]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int PhoneToId([NativeTypeName("LPCWSTR")] ushort* pszPhone, [NativeTypeName("SPPHONEID *")] ushort* pId)
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pszPhone, pId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IdToPhone([NativeTypeName("PCSPPHONEID")] ushort* pId, [NativeTypeName("WCHAR *")] ushort* pszPhone)
        {
            return ((delegate* unmanaged<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[6]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pId, pszPhone);
        }
    }
}
