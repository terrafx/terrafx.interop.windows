// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("152B8A3B-B9B9-4685-B56E-974847BC7545")]
    [NativeTypeName("struct ICorrelationVectorSource : IUnknown")]
    public unsafe partial struct ICorrelationVectorSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICorrelationVectorSource*, Guid*, void**, int>)(lpVtbl[0]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICorrelationVectorSource*, uint>)(lpVtbl[1]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICorrelationVectorSource*, uint>)(lpVtbl[2]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CorrelationVector([NativeTypeName("HSTRING *")] IntPtr* cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorSource*, IntPtr*, int>)(lpVtbl[3]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this), cv);
        }
    }
}
