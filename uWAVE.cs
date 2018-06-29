
namespace uWAVE_Host
{
    public enum LocalErrorID
    {
        LOC_ERR_NO_ERROR = 0,
        LOC_ERR_INVALID_SYNTAX = 1,
        LOC_ERR_UNSUPPORTED = 2,
        LOC_ERR_TRANSMITTER_BUSY = 3,
        LOC_ERR_ARGUMENT_OUT_OF_RANGE = 4,
        LOC_ERR_INVALID_OPERATION = 5,
        LOC_ERR_UNKNOWN_FIELD_ID = 6,
        LOC_ERR_VALUE_UNAVAILIBLE = 7,
        LOC_ERR_RECEIVER_BUSY = 8,
        LOC_ERR_TX_BUFFER_OVERRUN = 9,
        LOC_ERR_CHKSUM_ERROR = 10,
        LOC_ERR_UNKNOWN
    }

    public enum RC_REQUEST_ID
    {
        RC_PING = 0,
        RC_PONG = 1,
        RC_USR_CMD_000 = 2,
        RC_USR_CMD_001 = 3,
        RC_USR_CMD_002 = 4,
        RC_USR_CMD_003 = 5,
        RC_USR_CMD_004 = 6,
        RC_USR_CMD_005 = 7,
        RC_USR_CMD_006 = 8,
        RC_USR_CMD_007 = 9,
        RC_USR_CMD_008 = 10,
        RC_USR_CMD_009 = 11,
        RC_USR_CMD_010 = 12,
        RC_USR_CMD_011 = 13,
        RC_USR_CMD_012 = 14,
        RC_USR_CMD_ACK = 15,        
        RC_INVALID
    }

    public enum LOC_ACT_ID
    {
        LAC_DC_INCOMING = 0,
        LAC_DC_OUTCOMING = 1,
        LAC_RC_REQUEST = 2,
        LAC_SACTION = 3,
        LAC_LC_REQUEST = 4,
        LAC_INVALID
    }
           
    public static class uWAVE
    {
        public static readonly int MaxChIDs = 30;

        public static string BCDVersionToStr(int versionData)
        {
            return string.Format("{0}.{1}", (versionData >> 0x08).ToString(), (versionData & 0xff).ToString("X2"));
        }
    }
}
