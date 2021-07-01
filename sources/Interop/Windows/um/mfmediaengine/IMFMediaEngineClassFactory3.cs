// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3787614F-65F7-4003-B673-EAD8293A0E60")]
    [NativeTypeName("struct IMFMediaEngineClassFactory3 : IUnknown")]
    public unsafe partial struct IMFMediaEngineClassFactory3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaKeySystemAccess([NativeTypeName("BSTR")] ushort* keySystem, IPropertyStore** ppSupportedConfigurationsArray, [NativeTypeName("UINT")] uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, ushort*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this), keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
        }
    }
}
