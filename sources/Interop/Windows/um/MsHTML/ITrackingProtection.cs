// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510803-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ITrackingProtection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITrackingProtection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITrackingProtection*, Guid*, void**, int>)(lpVtbl[0]))((ITrackingProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITrackingProtection*, uint>)(lpVtbl[1]))((ITrackingProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITrackingProtection*, uint>)(lpVtbl[2]))((ITrackingProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int EvaluateUrl([NativeTypeName("BSTR")] ushort* bstrUrl, BOOL* pfAllowed)
        {
            return ((delegate* unmanaged<ITrackingProtection*, ushort*, BOOL*, int>)(lpVtbl[3]))((ITrackingProtection*)Unsafe.AsPointer(ref this), bstrUrl, pfAllowed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnabled(BOOL* pfEnabled)
        {
            return ((delegate* unmanaged<ITrackingProtection*, BOOL*, int>)(lpVtbl[4]))((ITrackingProtection*)Unsafe.AsPointer(ref this), pfEnabled);
        }
    }
}
