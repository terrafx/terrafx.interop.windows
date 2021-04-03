// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CE-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IComThreadingInfo : IUnknown")]
    public unsafe partial struct IComThreadingInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IComThreadingInfo*, Guid*, void**, int>)(lpVtbl[0]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IComThreadingInfo*, uint>)(lpVtbl[1]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IComThreadingInfo*, uint>)(lpVtbl[2]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentApartmentType(APTTYPE* pAptType)
        {
            return ((delegate* unmanaged<IComThreadingInfo*, APTTYPE*, int>)(lpVtbl[3]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pAptType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentThreadType(THDTYPE* pThreadType)
        {
            return ((delegate* unmanaged<IComThreadingInfo*, THDTYPE*, int>)(lpVtbl[4]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pThreadType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguidLogicalThreadId)
        {
            return ((delegate* unmanaged<IComThreadingInfo*, Guid*, int>)(lpVtbl[5]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pguidLogicalThreadId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<IComThreadingInfo*, Guid*, int>)(lpVtbl[6]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), rguid);
        }
    }
}
