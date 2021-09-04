// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB87E1BC-3233-11D2-AEC9-00C04FB68820")]
    [NativeTypeName("struct IWbemStatusCodeText : IUnknown")]
    public unsafe partial struct IWbemStatusCodeText
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemStatusCodeText*, Guid*, void**, int>)(lpVtbl[0]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemStatusCodeText*, uint>)(lpVtbl[1]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemStatusCodeText*, uint>)(lpVtbl[2]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorCodeText([NativeTypeName("HRESULT")] int hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText)
        {
            return ((delegate* unmanaged<IWbemStatusCodeText*, int, uint, int, ushort**, int>)(lpVtbl[3]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), hRes, LocaleId, lFlags, MessageText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFacilityCodeText([NativeTypeName("HRESULT")] int hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText)
        {
            return ((delegate* unmanaged<IWbemStatusCodeText*, int, uint, int, ushort**, int>)(lpVtbl[4]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), hRes, LocaleId, lFlags, MessageText);
        }
    }
}
