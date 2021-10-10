// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3CB4A69D-BB6F-4D2B-95B7-452D2C155DB5")]
    [NativeTypeName("struct IKsFormatSupport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IKsFormatSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKsFormatSupport*, Guid*, void**, int>)(lpVtbl[0]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[1]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[2]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, [NativeTypeName("BOOL *")] int* pbSupported)
        {
            return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT*, uint, int*, int>)(lpVtbl[3]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), pKsFormat, cbFormat, pbSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat)
        {
            return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT**, int>)(lpVtbl[4]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), ppKsFormat);
        }
    }
}
