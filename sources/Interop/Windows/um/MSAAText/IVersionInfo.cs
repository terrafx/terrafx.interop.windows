// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("401518EC-DB00-4611-9B29-2A0E4B9AFA85")]
    [NativeTypeName("struct IVersionInfo : IUnknown")]
    public unsafe partial struct IVersionInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVersionInfo*, uint>)(lpVtbl[1]))((IVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVersionInfo*, uint>)(lpVtbl[2]))((IVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubcomponentCount([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("ULONG *")] uint* ulCount)
        {
            return ((delegate* unmanaged<IVersionInfo*, uint, uint*, int>)(lpVtbl[3]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, ulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImplementationID([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("GUID *")] Guid* implid)
        {
            return ((delegate* unmanaged<IVersionInfo*, uint, Guid*, int>)(lpVtbl[4]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, implid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuildVersion([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("DWORD *")] uint* pdwMajor, [NativeTypeName("DWORD *")] uint* pdwMinor)
        {
            return ((delegate* unmanaged<IVersionInfo*, uint, uint*, uint*, int>)(lpVtbl[5]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pdwMajor, pdwMinor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr)
        {
            return ((delegate* unmanaged<IVersionInfo*, uint, ushort**, int>)(lpVtbl[6]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pImplStr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInstanceDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr)
        {
            return ((delegate* unmanaged<IVersionInfo*, uint, ushort**, int>)(lpVtbl[7]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pImplStr);
        }
    }
}
