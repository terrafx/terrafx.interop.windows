// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define S_SYNCMGR_MISSINGITEMS MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0201)")]
        public const int S_SYNCMGR_MISSINGITEMS = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0201))));

        [NativeTypeName("#define S_SYNCMGR_RETRYSYNC MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0202)")]
        public const int S_SYNCMGR_RETRYSYNC = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0202))));

        [NativeTypeName("#define S_SYNCMGR_CANCELITEM MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0203)")]
        public const int S_SYNCMGR_CANCELITEM = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0203))));

        [NativeTypeName("#define S_SYNCMGR_CANCELALL MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0204)")]
        public const int S_SYNCMGR_CANCELALL = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0204))));

        [NativeTypeName("#define S_SYNCMGR_ITEMDELETED MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0210)")]
        public const int S_SYNCMGR_ITEMDELETED = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0210))));

        [NativeTypeName("#define S_SYNCMGR_ENUMITEMS MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0211)")]
        public const int S_SYNCMGR_ENUMITEMS = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0211))));

        [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTEXT 0x0001")]
        public const int SYNCMGRPROGRESSITEM_STATUSTEXT = 0x0001;

        [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTYPE 0x0002")]
        public const int SYNCMGRPROGRESSITEM_STATUSTYPE = 0x0002;

        [NativeTypeName("#define SYNCMGRPROGRESSITEM_PROGVALUE 0x0004")]
        public const int SYNCMGRPROGRESSITEM_PROGVALUE = 0x0004;

        [NativeTypeName("#define SYNCMGRPROGRESSITEM_MAXVALUE 0x0008")]
        public const int SYNCMGRPROGRESSITEM_MAXVALUE = 0x0008;

        [NativeTypeName("#define SYNCMGRLOGERROR_ERRORFLAGS 0x0001")]
        public const int SYNCMGRLOGERROR_ERRORFLAGS = 0x0001;

        [NativeTypeName("#define SYNCMGRLOGERROR_ERRORID 0x0002")]
        public const int SYNCMGRLOGERROR_ERRORID = 0x0002;

        [NativeTypeName("#define SYNCMGRLOGERROR_ITEMID 0x0004")]
        public const int SYNCMGRLOGERROR_ITEMID = 0x0004;

        [NativeTypeName("#define SYNCMGRITEM_ITEMFLAGMASK 0x007F")]
        public const int SYNCMGRITEM_ITEMFLAGMASK = 0x007F;

        [NativeTypeName("#define MAX_SYNCMGRITEMNAME ( 128 )")]
        public const int MAX_SYNCMGRITEMNAME = (128);

        [NativeTypeName("#define SYNCMGRHANDLERFLAG_MASK 0x000f")]
        public const int SYNCMGRHANDLERFLAG_MASK = 0x000f;

        [NativeTypeName("#define MAX_SYNCMGRHANDLERNAME ( 32 )")]
        public const int MAX_SYNCMGRHANDLERNAME = (32);

        [NativeTypeName("#define SYNCMGRREGISTERFLAGS_MASK 0x07")]
        public const int SYNCMGRREGISTERFLAGS_MASK = 0x07;

        public static ref readonly Guid IID_ISyncMgrSynchronizeCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISyncMgrEnumItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISyncMgrSynchronize
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISyncMgrSynchronizeInvoke
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISyncMgrRegister
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_SyncMgr
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0xDF, 0x95, 0x62,
                    0xEE, 0x35,
                    0xD1, 0x11,
                    0x87,
                    0x07,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x33,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
