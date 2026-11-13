// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T* __MFP_CAST_EVENT<T>(MFP_EVENT_HEADER* pHdr, MFP_EVENT_TYPE eventType)
        where T : unmanaged
        => (pHdr->eEventType == eventType) ? (T*)pHdr : null;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_PLAY_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_PLAY_EVENT* MFP_GET_PLAY_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_PLAY_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_PLAY);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_PAUSE_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_PAUSE_EVENT* MFP_GET_PAUSE_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_PAUSE_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_PAUSE);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_STOP_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_STOP_EVENT* MFP_GET_STOP_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_STOP_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_STOP);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_POSITION_SET_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_POSITION_SET_EVENT* MFP_GET_POSITION_SET_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_POSITION_SET_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_POSITION_SET);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_RATE_SET_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_RATE_SET_EVENT* MFP_GET_RATE_SET_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_RATE_SET_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_RATE_SET);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_MEDIAITEM_CREATED_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_MEDIAITEM_CREATED_EVENT* MFP_GET_MEDIAITEM_CREATED_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_MEDIAITEM_CREATED_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_CREATED);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_MEDIAITEM_SET_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_MEDIAITEM_SET_EVENT* MFP_GET_MEDIAITEM_SET_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_MEDIAITEM_SET_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_SET);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_FRAME_STEP_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_FRAME_STEP_EVENT* MFP_GET_FRAME_STEP_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_FRAME_STEP_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_FRAME_STEP);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_MEDIAITEM_CLEARED_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_MEDIAITEM_CLEARED_EVENT* MFP_GET_MEDIAITEM_CLEARED_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_MEDIAITEM_CLEARED_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_CLEARED);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_MF_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_MF_EVENT* MFP_GET_MF_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_MF_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_MF);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_ERROR_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_ERROR_EVENT* MFP_GET_ERROR_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_ERROR_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_ERROR);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_PLAYBACK_ENDED_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_PLAYBACK_ENDED_EVENT* MFP_GET_PLAYBACK_ENDED_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_PLAYBACK_ENDED_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_PLAYBACK_ENDED);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFP_GET_ACQUIRE_USER_CREDENTIAL_EVENT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MFP_ACQUIRE_USER_CREDENTIAL_EVENT* MFP_GET_ACQUIRE_USER_CREDENTIAL_EVENT(MFP_EVENT_HEADER* pHdr)
        => __MFP_CAST_EVENT<MFP_ACQUIRE_USER_CREDENTIAL_EVENT>(pHdr, MFP_EVENT_TYPE.MFP_EVENT_TYPE_ACQUIRE_USER_CREDENTIAL);
}
