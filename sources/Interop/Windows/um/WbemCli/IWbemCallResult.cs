// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44ACA675-E8FC-11D0-A07C-00C04FB68820")]
    [NativeTypeName("struct IWbemCallResult : IUnknown")]
    public unsafe partial struct IWbemCallResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemCallResult*, Guid*, void**, int>)(lpVtbl[0]))((IWbemCallResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemCallResult*, uint>)(lpVtbl[1]))((IWbemCallResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemCallResult*, uint>)(lpVtbl[2]))((IWbemCallResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultObject([NativeTypeName("long")] int lTimeout, IWbemClassObject** ppResultObject)
        {
            return ((delegate* unmanaged<IWbemCallResult*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, ppResultObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultString([NativeTypeName("long")] int lTimeout, [NativeTypeName("BSTR *")] ushort** pstrResultString)
        {
            return ((delegate* unmanaged<IWbemCallResult*, int, ushort**, int>)(lpVtbl[4]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, pstrResultString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultServices([NativeTypeName("long")] int lTimeout, IWbemServices** ppServices)
        {
            return ((delegate* unmanaged<IWbemCallResult*, int, IWbemServices**, int>)(lpVtbl[5]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, ppServices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCallStatus([NativeTypeName("long")] int lTimeout, [NativeTypeName("long *")] int* plStatus)
        {
            return ((delegate* unmanaged<IWbemCallResult*, int, int*, int>)(lpVtbl[6]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, plStatus);
        }
    }
}
