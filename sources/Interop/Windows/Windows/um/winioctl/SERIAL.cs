// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SERIAL
{
    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_NUMBER_LENGTH"]/*' />
    [NativeTypeName("#define SERIAL_NUMBER_LENGTH 32")]
    public const int SERIAL_NUMBER_LENGTH = 32;

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_LSRMST_ESCAPE"]/*' />
    [NativeTypeName("#define SERIAL_LSRMST_ESCAPE ((BYTE )0x00)")]
    public const byte SERIAL_LSRMST_ESCAPE = ((byte)(0x00));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_LSRMST_LSR_DATA"]/*' />
    [NativeTypeName("#define SERIAL_LSRMST_LSR_DATA ((BYTE )0x01)")]
    public const byte SERIAL_LSRMST_LSR_DATA = ((byte)(0x01));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_LSRMST_LSR_NODATA"]/*' />
    [NativeTypeName("#define SERIAL_LSRMST_LSR_NODATA ((BYTE )0x02)")]
    public const byte SERIAL_LSRMST_LSR_NODATA = ((byte)(0x02));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_LSRMST_MST"]/*' />
    [NativeTypeName("#define SERIAL_LSRMST_MST ((BYTE )0x03)")]
    public const byte SERIAL_LSRMST_MST = ((byte)(0x03));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_FIFO_ENABLE"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_FIFO_ENABLE ((DWORD)0x00000001)")]
    public const uint SERIAL_IOC_FCR_FIFO_ENABLE = ((uint)(0x00000001));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_RCVR_RESET"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_RESET ((DWORD)0x00000002)")]
    public const uint SERIAL_IOC_FCR_RCVR_RESET = ((uint)(0x00000002));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_XMIT_RESET"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_XMIT_RESET ((DWORD)0x00000004)")]
    public const uint SERIAL_IOC_FCR_XMIT_RESET = ((uint)(0x00000004));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_DMA_MODE"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_DMA_MODE ((DWORD)0x00000008)")]
    public const uint SERIAL_IOC_FCR_DMA_MODE = ((uint)(0x00000008));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_RES1"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_RES1 ((DWORD)0x00000010)")]
    public const uint SERIAL_IOC_FCR_RES1 = ((uint)(0x00000010));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_RES2"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_RES2 ((DWORD)0x00000020)")]
    public const uint SERIAL_IOC_FCR_RES2 = ((uint)(0x00000020));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_RCVR_TRIGGER_LSB"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_TRIGGER_LSB ((DWORD)0x00000040)")]
    public const uint SERIAL_IOC_FCR_RCVR_TRIGGER_LSB = ((uint)(0x00000040));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_FCR_RCVR_TRIGGER_MSB"]/*' />
    [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_TRIGGER_MSB ((DWORD)0x00000080)")]
    public const uint SERIAL_IOC_FCR_RCVR_TRIGGER_MSB = ((uint)(0x00000080));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_MCR_DTR"]/*' />
    [NativeTypeName("#define SERIAL_IOC_MCR_DTR ((DWORD)0x00000001)")]
    public const uint SERIAL_IOC_MCR_DTR = ((uint)(0x00000001));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_MCR_RTS"]/*' />
    [NativeTypeName("#define SERIAL_IOC_MCR_RTS ((DWORD)0x00000002)")]
    public const uint SERIAL_IOC_MCR_RTS = ((uint)(0x00000002));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_MCR_OUT1"]/*' />
    [NativeTypeName("#define SERIAL_IOC_MCR_OUT1 ((DWORD)0x00000004)")]
    public const uint SERIAL_IOC_MCR_OUT1 = ((uint)(0x00000004));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_MCR_OUT2"]/*' />
    [NativeTypeName("#define SERIAL_IOC_MCR_OUT2 ((DWORD)0x00000008)")]
    public const uint SERIAL_IOC_MCR_OUT2 = ((uint)(0x00000008));

    /// <include file='SERIAL.xml' path='doc/member[@name="SERIAL.SERIAL_IOC_MCR_LOOP"]/*' />
    [NativeTypeName("#define SERIAL_IOC_MCR_LOOP ((DWORD)0x00000010)")]
    public const uint SERIAL_IOC_MCR_LOOP = ((uint)(0x00000010));
}
