// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA0CD0F9-14A2-4F09-8C2A-85CC48979345")]
    [NativeTypeName("struct ISpRecoCategory : IUnknown")]
    public unsafe partial struct ISpRecoCategory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpRecoCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpRecoCategory*, uint>)(lpVtbl[1]))((ISpRecoCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpRecoCategory*, uint>)(lpVtbl[2]))((ISpRecoCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("SPCATEGORYTYPE *")] SPCATEGORYTYPE* peCategoryType)
        {
            return ((delegate* stdcall<ISpRecoCategory*, SPCATEGORYTYPE*, int>)(lpVtbl[3]))((ISpRecoCategory*)Unsafe.AsPointer(ref this), peCategoryType);
        }
    }
}
