// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73885-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IReferenceClock2 : IReferenceClock")]
    public unsafe partial struct IReferenceClock2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IReferenceClock2*, Guid*, void**, int>)(lpVtbl[0]))((IReferenceClock2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IReferenceClock2*, uint>)(lpVtbl[1]))((IReferenceClock2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IReferenceClock2*, uint>)(lpVtbl[2]))((IReferenceClock2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTime)
        {
            return ((delegate* stdcall<IReferenceClock2*, long*, int>)(lpVtbl[3]))((IReferenceClock2*)Unsafe.AsPointer(ref this), pTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdviseTime([NativeTypeName("REFERENCE_TIME")] long baseTime, [NativeTypeName("REFERENCE_TIME")] long streamTime, [NativeTypeName("HEVENT")] nuint hEvent, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock2*, long, long, nuint, nuint*, int>)(lpVtbl[4]))((IReferenceClock2*)Unsafe.AsPointer(ref this), baseTime, streamTime, hEvent, pdwAdviseCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdvisePeriodic([NativeTypeName("REFERENCE_TIME")] long startTime, [NativeTypeName("REFERENCE_TIME")] long periodTime, [NativeTypeName("HSEMAPHORE")] nuint hSemaphore, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock2*, long, long, nuint, nuint*, int>)(lpVtbl[5]))((IReferenceClock2*)Unsafe.AsPointer(ref this), startTime, periodTime, hSemaphore, pdwAdviseCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD_PTR")] nuint dwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock2*, nuint, int>)(lpVtbl[6]))((IReferenceClock2*)Unsafe.AsPointer(ref this), dwAdviseCookie);
        }
    }
}
